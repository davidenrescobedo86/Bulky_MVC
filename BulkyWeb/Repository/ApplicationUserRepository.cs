using System.Linq.Expressions;
using BulkyWeb.Data;
using BulkyWeb.Models;
using BulkyWeb.Repository.IRepository;

namespace BulkyWeb.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db) : base(db) {
            _db = db;
        }   
    }
}
