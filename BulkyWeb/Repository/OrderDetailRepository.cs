using System.Linq.Expressions;
using BulkyWeb.Data;
using BulkyWeb.Models;
using BulkyWeb.Repository.IRepository;

namespace BulkyWeb.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private ApplicationDbContext _db;

        public OrderDetailRepository(ApplicationDbContext db) : base(db) {
            _db = db;
        }   

        public void Update(OrderDetail obj)
        {
            _db.OrderDetails.Update(obj);
        }
    }
}
