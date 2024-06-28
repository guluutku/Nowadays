using System;
namespace Nowadays.Models
{
    public interface IReportRepository
    {

        List<Report> GetAllReports();
        Report GetReport(int id);
        Report Delete(int id);
        Report Add(Report report);
        Report Update(Report report);

    }
}