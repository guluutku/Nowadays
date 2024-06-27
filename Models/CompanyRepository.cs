

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
                // TODO Exception'u düzelt
                // TODO 500 Interval Error veriyor
                // TODO 
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
            Company company = (Company)context.Companies.Where(c => c.companyID == companyId);
            company.isActive = false;
            context.SaveChanges();

            return company;
        }

        List<Company> ICompanyRepository.GetAllCompanies()
        {
            return new List<Company> { new Company(){
                companyID = 1,
                name = "Şirket",
                isActive = true,
                }
            };
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
