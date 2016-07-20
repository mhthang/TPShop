using TPShop.Data.Infrastructure;
using TPShop.Model.Models;

namespace TPShop.Data.Repositories
{
    public interface IProductRepository
    {
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}