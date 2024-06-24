
namespace Nowadays.Models
{
    public class ReportRepository : IReportRepository
    {

        NowadaysContext context = new NowadaysContext();

        public ReportRepository()
        {
        }

    }
}