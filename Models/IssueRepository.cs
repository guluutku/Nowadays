
namespace Nowadays.Models
{
    public class IssueRepository : IIssueRepository
    {

        NowadaysContext context = new NowadaysContext();

        public IssueRepository()
        {
        }

        Issue IIssueRepository.Add(Issue issue)
        {
            try
            {
                context.Add(issue);
                context.SaveChanges();
                return issue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        Issue IIssueRepository.Delete(int issueId)
        {
            try
            {
                Issue? issue = context.Issues.FirstOrDefault(c => c.issueID == issueId);
                issue!.isActive = false;
                context.SaveChanges();

                return issue;
            }
            catch
            {
                throw;
            }
        }

        List<Issue> IIssueRepository.GetAllIssues()
        {
            List<Issue> issues = context.Issues.ToList();
            return issues;
        }

        Issue IIssueRepository.GetIssue(int issueId)
        {
            var issue = context.Issues.FirstOrDefault(c => c.issueID == issueId);
            return issue!;
        }


        Issue IIssueRepository.Update(Issue issue)
        {
            try
            {
                context.Update(issue);
                context.SaveChanges();
                return issue;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}