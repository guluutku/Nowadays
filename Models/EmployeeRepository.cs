
namespace Nowadays.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {

        NowadaysContext context = new NowadaysContext();

        public EmployeeRepository()
        {
        }

    }
}