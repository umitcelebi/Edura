using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Edura.WebUI.Entity;
using Edura.WebUI.Repository.Concrete.EntityFramework;

namespace Edura.WebUI.Repository.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        List<Product> GetTop5Products();
    }
}
