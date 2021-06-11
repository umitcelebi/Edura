using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Edura.WebUI.Repository.Concrete.EntityFramework
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            EduraContext context = app.ApplicationServices.GetRequiredService<EduraContext>();
            context.Database.Migrate();

            if (!context.Products.Any())
            {
                var products =new []{
                    new Product(){ProductName = "Asus Laptop",Price = 8200,Image = "product1.jpg",IsHome = true,IsApproved = true,IsFeatured = false,Description = "Sony Playstation 5 Oyun Konsolu (Eurasia garantili) Yıldırım Hızı PlayStation konsolunun neler yapabileceğini baştan yazan özel CPU'nun, GPU'nun ve Entegre Giriş/Çıkış özellikli SSD'nin gücünden faydalanın. Ultra Yüksek Hızlı SSD Konsolunuzdaki PS5™ oyunlarının neredeyse anında yüklenme hızıyla oyun deneyiminizi en üst düzeye çıkarın. ",HtmlContent = "Sony Playstation 5 Oyun Konsolu (Eurasia garantili) Yıldırım Hızı PlayStation konsolunun neler yapabileceğini baştan yazan özel CPU'nun, GPU'nun ve Entegre Giriş/Çıkış özellikli SSD'nin gücünden faydalanın. Ultra Yüksek Hızlı SSD Konsolunuzdaki <b> PS5™ oyunlarının neredeyse anında yüklenme hızıyla </b> oyun deneyiminizi en üst düzeye çıkarın. ",DateAdded = DateTime.Now.AddDays(-10)},
                    new Product() { ProductName = "Monster Laptop", Price = 11000 ,Image = "product2.jpg",IsHome = true,IsApproved = true,IsFeatured = false,Description = "Sony Playstation 5 Oyun Konsolu (Eurasia garantili) Yıldırım Hızı PlayStation konsolunun neler yapabileceğini baştan yazan özel CPU'nun, GPU'nun ve Entegre Giriş/Çıkış özellikli SSD'nin gücünden faydalanın. Ultra Yüksek Hızlı SSD Konsolunuzdaki PS5™ oyunlarının neredeyse anında yüklenme hızıyla oyun deneyiminizi en üst düzeye çıkarın. ",HtmlContent = "Sony Playstation 5 Oyun Konsolu (Eurasia garantili) Yıldırım Hızı PlayStation konsolunun neler yapabileceğini baştan yazan özel CPU'nun, GPU'nun ve Entegre Giriş/Çıkış özellikli SSD'nin gücünden faydalanın. Ultra Yüksek Hızlı SSD Konsolunuzdaki <b> PS5™ oyunlarının neredeyse anında yüklenme hızıyla </b> oyun deneyiminizi en üst düzeye çıkarın. ",DateAdded = DateTime.Now.AddDays(-15)},
                    new Product() { ProductName = "Iphone X", Price = 8200 ,Image = "product3.jpg",IsHome = true,IsApproved = true,IsFeatured = false,Description = "Sony Playstation 5 Oyun Konsolu (Eurasia garantili) Yıldırım Hızı PlayStation konsolunun neler yapabileceğini baştan yazan özel CPU'nun, GPU'nun ve Entegre Giriş/Çıkış özellikli SSD'nin gücünden faydalanın. Ultra Yüksek Hızlı SSD Konsolunuzdaki PS5™ oyunlarının neredeyse anında yüklenme hızıyla oyun deneyiminizi en üst düzeye çıkarın. ",HtmlContent = "Sony Playstation 5 Oyun Konsolu (Eurasia garantili) Yıldırım Hızı PlayStation konsolunun neler yapabileceğini baştan yazan özel CPU'nun, GPU'nun ve Entegre Giriş/Çıkış özellikli SSD'nin gücünden faydalanın. Ultra Yüksek Hızlı SSD Konsolunuzdaki <b> PS5™ oyunlarının neredeyse anında yüklenme hızıyla </b> oyun deneyiminizi en üst düzeye çıkarın. ",DateAdded = DateTime.Now.AddDays(-5)},
                    new Product() { ProductName = "Xiaomi Mi10", Price = 4500 ,Image = "product4.jpg",IsHome = true,IsApproved = true,IsFeatured = false,Description = "Sony Playstation 5 Oyun Konsolu (Eurasia garantili) Yıldırım Hızı PlayStation konsolunun neler yapabileceğini baştan yazan özel CPU'nun, GPU'nun ve Entegre Giriş/Çıkış özellikli SSD'nin gücünden faydalanın. Ultra Yüksek Hızlı SSD Konsolunuzdaki PS5™ oyunlarının neredeyse anında yüklenme hızıyla oyun deneyiminizi en üst düzeye çıkarın. ",HtmlContent = "Sony Playstation 5 Oyun Konsolu (Eurasia garantili) Yıldırım Hızı PlayStation konsolunun neler yapabileceğini baştan yazan özel CPU'nun, GPU'nun ve Entegre Giriş/Çıkış özellikli SSD'nin gücünden faydalanın. Ultra Yüksek Hızlı SSD Konsolunuzdaki <b> PS5™ oyunlarının neredeyse anında yüklenme hızıyla </b> oyun deneyiminizi en üst düzeye çıkarın. ",DateAdded = DateTime.Now.AddDays(-2)},
                    new Product() { ProductName = "Samsung J20", Price = 5500 ,Image = "product3.jpg",IsHome = false,IsApproved = true,IsFeatured = true,Description = "Sony Playstation 5 Oyun Konsolu (Eurasia garantili) Yıldırım Hızı PlayStation konsolunun neler yapabileceğini baştan yazan özel CPU'nun, GPU'nun ve Entegre Giriş/Çıkış özellikli SSD'nin gücünden faydalanın. Ultra Yüksek Hızlı SSD Konsolunuzdaki PS5™ oyunlarının neredeyse anında yüklenme hızıyla oyun deneyiminizi en üst düzeye çıkarın. ",HtmlContent = "Sony Playstation 5 Oyun Konsolu (Eurasia garantili) Yıldırım Hızı PlayStation konsolunun neler yapabileceğini baştan yazan özel CPU'nun, GPU'nun ve Entegre Giriş/Çıkış özellikli SSD'nin gücünden faydalanın. Ultra Yüksek Hızlı SSD Konsolunuzdaki <b> PS5™ oyunlarının neredeyse anında yüklenme hızıyla </b> oyun deneyiminizi en üst düzeye çıkarın. ",DateAdded = DateTime.Now.AddDays(-3)},
                    new Product() { ProductName = "LG Televizyon", Price = 6400,Image = "product2.jpg",IsHome = false,IsApproved = true,IsFeatured = true,Description = "Sony Playstation 5 Oyun Konsolu (Eurasia garantili) Yıldırım Hızı PlayStation konsolunun neler yapabileceğini baştan yazan özel CPU'nun, GPU'nun ve Entegre Giriş/Çıkış özellikli SSD'nin gücünden faydalanın. Ultra Yüksek Hızlı SSD Konsolunuzdaki PS5™ oyunlarının neredeyse anında yüklenme hızıyla oyun deneyiminizi en üst düzeye çıkarın. ",HtmlContent = "Sony Playstation 5 Oyun Konsolu (Eurasia garantili) Yıldırım Hızı PlayStation konsolunun neler yapabileceğini baştan yazan özel CPU'nun, GPU'nun ve Entegre Giriş/Çıkış özellikli SSD'nin gücünden faydalanın. Ultra Yüksek Hızlı SSD Konsolunuzdaki <b> PS5™ oyunlarının neredeyse anında yüklenme hızıyla </b> oyun deneyiminizi en üst düzeye çıkarın. ",DateAdded = DateTime.Now}
                    };
                context.Products.AddRange(products);

                var categories = new[]
                {
                    new Category{CategoryName = "Computer"},
                    new Category{CategoryName = "Phone"},
                    new Category{CategoryName = "TV"},
                    new Category{CategoryName = "Game"}
                };
                context.Categories.AddRange(categories);

                var productCategory = new[]
                {
                    new ProductCategory {Product = products[0], Category = categories[0]},
                    new ProductCategory {Product = products[1], Category = categories[0]},
                    new ProductCategory {Product = products[2], Category = categories[1]},
                    new ProductCategory {Product = products[3], Category = categories[1]},
                    new ProductCategory {Product = products[4], Category = categories[1]},
                    new ProductCategory {Product = products[5], Category = categories[2]},
                };

                var Images = new[]
                {
                    new Image(){ImageName = "product1.jpg",Product = products[0]},
                    new Image(){ImageName = "product2.jpg",Product = products[0]},
                    new Image(){ImageName = "product3.jpg",Product = products[0]},
                    new Image(){ImageName = "product4.jpg",Product = products[0]},

                    new Image(){ImageName = "product1.jpg",Product = products[1]},
                    new Image(){ImageName = "product2.jpg",Product = products[1]},
                    new Image(){ImageName = "product3.jpg",Product = products[1]},
                    new Image(){ImageName = "product4.jpg",Product = products[1]},

                    new Image(){ImageName = "product1.jpg",Product = products[2]},
                    new Image(){ImageName = "product2.jpg",Product = products[2]},
                    new Image(){ImageName = "product3.jpg",Product = products[2]},
                    new Image(){ImageName = "product4.jpg",Product = products[2]},
                    
                    new Image(){ImageName = "product1.jpg",Product = products[3]},
                    new Image(){ImageName = "product2.jpg",Product = products[3]},
                    new Image(){ImageName = "product3.jpg",Product = products[3]},
                    new Image(){ImageName = "product4.jpg",Product = products[3]}
                };

                context.Images.AddRange(Images);

                var Attributes = new[]
                {
                    new ProductAttribute(){Attribute = "Display",Value ="15.6",Product = products[0]},
                    new ProductAttribute(){Attribute = "Processor",Value ="İntel ,7",Product = products[0]},
                    new ProductAttribute(){Attribute = "Ram Memory",Value ="8 GB",Product = products[0]},
                    new ProductAttribute(){Attribute = "Hard Disk",Value ="1 TB",Product = products[0]},
                    new ProductAttribute(){Attribute = "Color",Value ="Black",Product = products[0]},

                    new ProductAttribute(){Attribute = "Display",Value ="15.6",Product = products[1]},
                    new ProductAttribute(){Attribute = "Processor",Value ="İntel ,7",Product = products[1]},
                    new ProductAttribute(){Attribute = "Ram Memory",Value ="8 GB",Product = products[1]},
                    new ProductAttribute(){Attribute = "Hard Disk",Value ="1 TB",Product = products[1]},
                    new ProductAttribute(){Attribute = "Color",Value ="Black",Product = products[1]},

                    new ProductAttribute(){Attribute = "Display",Value ="15.6",Product = products[2]},
                    new ProductAttribute(){Attribute = "Processor",Value ="İntel ,7",Product = products[2]},
                    new ProductAttribute(){Attribute = "Ram Memory",Value ="8 GB",Product = products[2]},
                    new ProductAttribute(){Attribute = "Hard Disk",Value ="1 TB",Product = products[2]},
                    new ProductAttribute(){Attribute = "Color",Value ="Black",Product = products[2]},

                    new ProductAttribute(){Attribute = "Display",Value ="15.6",Product = products[3]},
                    new ProductAttribute(){Attribute = "Processor",Value ="İntel ,7",Product = products[3]},
                    new ProductAttribute(){Attribute = "Ram Memory",Value ="8 GB",Product = products[3]},
                    new ProductAttribute(){Attribute = "Hard Disk",Value ="1 TB",Product = products[3]},
                    new ProductAttribute(){Attribute = "Color",Value ="Black",Product = products[3]}
                };
                context.ProductAttributes.AddRange(Attributes);

                context.SaveChanges();
            }
            
        }
    }
}
