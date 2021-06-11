using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Edura.WebUI.Entity;
using Edura.WebUI.Models;

namespace Edura.WebUI.Repository.Abstract
{
    public interface ICategoryRepository:IRepository<Category>
    {
        Category GetByName(string name);
        IQueryable<CategoryModel> GetAllWithProductCount();
    }
}
