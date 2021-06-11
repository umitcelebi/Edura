﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Edura.WebUI.Entity;
using Edura.WebUI.Models;
using Edura.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore;

namespace Edura.WebUI.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository:EfGenericRepository<Category>,ICategoryRepository
    {
        public EfCategoryRepository(EduraContext context) : base(context)
        {
        }

        public EduraContext EduraContext
        {
            get
            {
                return context as EduraContext;
            }
        }

        public Category GetByName(string name)
        {
            return EduraContext.Categories.Where(c => c.CategoryName == name).FirstOrDefault();
        }

        public IQueryable<CategoryModel> GetAllWithProductCount()
        {
            return GetAll().Select(i => new CategoryModel()
            {
                CategoryId = i.CategoryId,
                CategoryName = i.CategoryName,
                Count = i.ProductCategories.Count()
            });
        }
    }
}
