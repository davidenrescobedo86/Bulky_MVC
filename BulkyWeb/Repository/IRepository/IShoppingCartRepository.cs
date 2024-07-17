using BulkyWeb.Models;

namespace BulkyWeb.Repository.IRepository
{
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        void Update(ShoppingCart obj);
    }
}
