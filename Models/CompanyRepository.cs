
namespace Nowadays.Models
{
    public class CompanyRepository : ICompanyRepository
    {

        NowadaysContext context = new NowadaysContext();

        public CompanyRepository()
        {
        }

    }
}