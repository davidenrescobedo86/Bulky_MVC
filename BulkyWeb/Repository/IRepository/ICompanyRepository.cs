using BulkyWeb.Models;

namespace BulkyWeb.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company obj);
    }
}
