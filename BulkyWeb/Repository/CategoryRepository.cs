using System.Linq.Expressions;
using BulkyWeb.Data;
using BulkyWeb.Models;
using BulkyWeb.Repository.IRepository;

namespace BulkyWeb.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db) {
            _db = db;
        }   

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
