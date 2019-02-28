using IssuesBusinessLogic.Entities;
using System.Collections.Generic;

namespace IssuesBusinessLogic
{
    /// <summary>
    /// Interface for Issues Business Logic Class.
    /// </summary>
    public interface IssueBizContract
    {
        List<IssueBase> GetAllIssues();
        List<string> GetAllIssueTypes();
        string GetIssueType(IssueBase issue);
        List<Status> GetAllStatus();
        List<Priority> GetAllPriority();
        int AddIssue(IssueBase issue);
        int UpdateIssue(IssueBase issue);
        void ResolveIssue(IssueBase issue);
    }
}
