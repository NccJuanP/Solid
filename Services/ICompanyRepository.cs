using solid.Models;

namespace solid.Services
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAll();
        Company GetById(int Id);
        void Add(Company company);
        void Remove(int Id);
        void Update (Company company);
    }
}