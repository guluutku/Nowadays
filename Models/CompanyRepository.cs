

namespace Nowadays.Models
{
    public class CompanyRepository : ICompanyRepository
    {

        NowadaysContext context = new NowadaysContext();

        public CompanyRepository()
        {
        }

        Company ICompanyRepository.Add(Company company)
        {
            try
            {
                context.Add(company);
                context.SaveChanges();
                return company;
            }
            catch (Exception)
            {
                throw;
            }
        }

        Company ICompanyRepository.Delete(int companyId)
        {
            try
            {
                Company? company = context.Companies.FirstOrDefault(c => c.companyID == companyId);
                company!.isActive = false;
                context.SaveChanges();

                return company;
            }
            catch
            {
                throw;
            }
        }

        List<Company> ICompanyRepository.GetAllCompanies()
        {
            List<Company> companies = context.Companies.ToList();
            return companies;
        }

        Company ICompanyRepository.Update(Company company)
        {
            try
            {
                context.Update(company);
                context.SaveChanges();
                return company;
            }
            catch (Exception)
            {
                throw;
            }
        }

        Company ICompanyRepository.GetCompany(int companyId)
        {
            var company = context.Companies.FirstOrDefault(c => c.companyID == companyId);
            return company!;
        }

    }
}
