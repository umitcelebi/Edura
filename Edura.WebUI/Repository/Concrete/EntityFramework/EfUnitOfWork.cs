using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Repository.Abstract;

namespace Edura.WebUI.Repository.Concrete.EntityFramework
{
    public class EfUnitOfWork:IUnitOfWork
    {
        private readonly EduraContext dbContext;

        public EfUnitOfWork(EduraContext _dbContext)
        {
            dbContext = _dbContext?? throw new ArgumentNullException("dbContext cannot be null");
        }

        private IProductRepository _Products;
        private ICategoryRepository _Categories;
        private IOrderRepository _Orders;

        public IProductRepository Products
        {
            get
            {
                return _Products?? (_Products=new EfProductRepository(dbContext));
            }

        }

        public ICategoryRepository Categories
        {
            get
            {
                return _Categories??(_Categories=new EfCategoryRepository(dbContext));
            }
        }

        public IOrderRepository Orders
        {
            get
            {
                return _Orders?? (_Orders = new EfOrderRepository(dbContext));
            }
        }

        public int SaveChanges()
        {
            try
            {
                return dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }

        
    }
}
