using System;
namespace Nowadays.Models
{
    public interface IIssueRepository
    {

        List<Issue> GetAllIssues();
        Issue GetIssue(int id);
        Issue Delete(int id);
        Issue Add(Issue issue);
        Issue Update(Issue issue);

    }
}
