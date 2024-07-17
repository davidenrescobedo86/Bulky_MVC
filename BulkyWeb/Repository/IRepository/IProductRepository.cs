using BulkyWeb.Models;

namespace BulkyWeb.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }
}
