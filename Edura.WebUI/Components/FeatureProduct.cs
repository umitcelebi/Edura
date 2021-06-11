using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edura.WebUI.Components
{
    public class FeatureProduct:ViewComponent
    {
        private IProductRepository repository;

        public FeatureProduct(IProductRepository _repository)
        {
            repository = _repository;
        }

        public IViewComponentResult Invoke()
        {
            return View(repository.GetAll().Where(p=>p.IsApproved&&p.IsFeatured));
        }
    }
}
