using System;

namespace IssuesBusinessLogic.Entities
{
    /// <summary>
    /// Child Class derived from IssueBase Class.
    /// </summary>
    public class OperationalIssue : IssueBase
    {
        /// <summary>
        /// Override ResolveIssue method
        /// </summary>
        /// <returns></returns>
        protected internal override string ResolveIssue()
        {            
            return $"Operational Issue-{this.IssueID} has been resolved.";
        }
    }
}
