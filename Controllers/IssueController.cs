using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nowadays.Models;

namespace Nowadays.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IssueController : ControllerBase
{
    IIssueRepository issueRepository = new IssueRepository();

    /// <summary>
    /// Use this to get a list of all Issues
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("GetAllIssues")]
    public IEnumerable<Issue> GetAllIssues()
    {
        return issueRepository.GetAllIssues();

    }

    [HttpGet]
    [Route("GetIssue")]
    public Issue GetIssue(int issueID)
    {
        return issueRepository.GetIssue(issueID);
    }

    [HttpPost]
    [Route("AddIssue")]
    public Issue AddIssue(Issue issue)
    {
        return issueRepository.Add(issue);
    }

    [HttpPost]
    [Route("UpdateIssue")]
    public Issue UpdateIssue(Issue issue)
    {
        return issueRepository.Update(issue);
    }

    [HttpDelete]
    [Route("DeleteIssue")]
    public Issue DeleteIssue(int issueID)
    {
        return issueRepository.Delete(issueID);
    }

}
