using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Entity;
using Edura.WebUI.Infrastructure;
using Edura.WebUI.Models;
using Edura.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Authorization;

namespace Edura.WebUI.Controllers
{
    public class CartController : Controller
    {
        private IUnitOfWork repository;
        public CartController(IUnitOfWork _repository)
        {
            repository = _repository;
        }
        public IActionResult Index()
        {
            return View(GetCart());
        }
        
        public IActionResult AddToCart(int productId,int quantity=1)
        {
            var product = repository.Products.GetById(productId);
            if (product != null)
            {
                var cart = GetCart();

                cart.AddProduct(product,quantity);
                SaveCart(cart);
            }
            return RedirectToAction("Index");
        }
        public IActionResult RemoveFromCart(int productId)
        {
            var product = repository.Products.GetById(productId);
            if (product != null)
            {
                var cart = GetCart();
                cart.RemoveProduct(product);
                SaveCart(cart);
            }
            
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult Checkout(OrderDetails model)
        {
            var cart = GetCart();

            if (cart.Products.Count() == 0)
            {
                ModelState.AddModelError("UrunYokModel","Sepetinizde ürün bulunmamaktadır.");
            }

            if (ModelState.IsValid)
            {
                SaveOrder(cart, model);
                cart.ClearAll();
                SaveCart(cart);
                return View("Completed");
            }

            return View(model);
        }

        private void SaveOrder(Cart cart, OrderDetails model)
        {
            var order = new Order();

            order.OrderNumber = "A" + (new Random()).Next(11111, 99999).ToString();
            order.Total = cart.TotalPrice();
            order.OrderDate=DateTime.Now;
            order.OrderState = EnumOrderState.Waiting;
            order.Username = User.Identity.Name;

            order.Adres = model.Adres;
            order.AdresTanimi = model.AdresTanimi;
            order.Sehir = model.Sehir;
            order.Semt = model.Semt;
            order.Telefon = model.Telefon;

            foreach (var product in cart.Products)
            {
                var orderline = new OrderLine();
                orderline.Quantity = product.Quantity;
                orderline.Price = product.Product.Price;
                orderline.ProductId = product.Product.ProductId;

                order.OrderLines.Add(orderline);
            }
            repository.Orders.Add(order);
            repository.SaveChanges();
        }

        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetJson("Cart",cart);
        }

        private Cart GetCart()
        {
            return HttpContext.Session.GetJson<Cart>("Cart")??new Cart();
        }

        
    }
}
