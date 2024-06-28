using System;
namespace Nowadays.Models
{
    public interface ICompanyRepository
    {

        List<Company> GetAllCompanies();
        Company GetCompany(int id);
        Company Delete(int id);
        Company Add(Company company);
        Company Update(Company company);

    }
}