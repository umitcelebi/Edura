using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Repository.Abstract;

namespace Edura.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository _repository)
        {
            categoryRepository = _repository;
        }

        public IActionResult Index()
        {
            return View(categoryRepository.GetByName("Computer"));
        }
    }
}