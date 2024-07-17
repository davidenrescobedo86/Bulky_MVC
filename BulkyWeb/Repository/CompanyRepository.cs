using System.Linq.Expressions;
using BulkyWeb.Data;
using BulkyWeb.Models;
using BulkyWeb.Repository.IRepository;

namespace BulkyWeb.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private ApplicationDbContext _db;

        public CompanyRepository(ApplicationDbContext db) : base(db) {
            _db = db;
        }   

        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}
