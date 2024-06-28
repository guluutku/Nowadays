
namespace Nowadays.Models
{
    public class ReportRepository : IReportRepository
    {

       NowadaysContext context = new NowadaysContext();

        public ReportRepository()
        {
        }

        Report IReportRepository.Add(Report report)
        {
            try
            {
                context.Add(report);
                context.SaveChanges();
                return report;
            }
            catch (Exception)
            {
                throw;
            }
        }

        Report IReportRepository.Delete(int reportId)
        {
            try
            {
                Report? report = context.Reports.FirstOrDefault(c => c.reportIDd == reportId);
                report!.isActive = false;
                context.SaveChanges();

                return report;
            }
            catch
            {
                throw;
            }
        }

        List<Report> IReportRepository.GetAllReports()
        {
            List<Report> reports = context.Reports.ToList();
            return reports;
        }

        Report IReportRepository.GetReport(int reportId)
        {
            var report = context.Reports.FirstOrDefault(c => c.reportIDd == reportId);
            return report!;
        }

        Report IReportRepository.Update(Report report)
        {
            try
            {
                context.Update(report);
                context.SaveChanges();
                return report;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}