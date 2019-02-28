using System;

namespace IssuesBusinessLogic.Entities
{
    /// <summary>
    /// Child Class derived from IssueBase Class.
    /// </summary>
    public class ServiceIssue : IssueBase
    {
        /// <summary>
        /// Override ResolveIssue method
        /// </summary>
        /// <returns></returns>
        protected internal override string ResolveIssue()
        {
            return $"Service Issue-{this.IssueID} has been resolved.";
        }
    }
}
