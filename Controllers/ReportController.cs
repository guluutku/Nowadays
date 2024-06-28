using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nowadays.Models;

namespace Nowadays.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReportController : ControllerBase
{

   IReportRepository reportRepository = new ReportRepository();

    /// <summary>
    /// Use this to get a list of all Reports
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("GetAllReports")]
    public IEnumerable<Report> GetAllReports()
    {
        return reportRepository.GetAllReports();

    }

    [HttpGet]
    [Route("GetReport")]
    public Report GetReport(int reportID)
    {
        return reportRepository.GetReport(reportID);
    }

    [HttpPost]
    [Route("AddReport")]
    public Report AddReport(Report report)
    {
        return reportRepository.Add(report);
    }

    [HttpPost]
    [Route("UpdateReport")]
    public Report UpdateReport(Report report)
    {
        return reportRepository.Update(report);
    }

    [HttpDelete]
    [Route("DeleteReport")]
    public Report DeleteReport(int reportID)
    {
        return reportRepository.Delete(reportID);
    }

}
