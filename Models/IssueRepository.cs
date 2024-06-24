
namespace Nowadays.Models
{
    public class IssueRepository : IIssueRepository
    {

        NowadaysContext context = new NowadaysContext();

        public IssueRepository()
        {
        }

    }
}