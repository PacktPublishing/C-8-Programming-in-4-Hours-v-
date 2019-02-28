using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesBusinessLogic.Entities
{
    /// <summary>
    /// Base Class(Abstrtact Class) for Issues
    /// </summary>
    public abstract class IssueBase
    {
        public int IssueID { get; set; }
        public string IssueTitle { get; set; }
        public string IssueDescription { get; set; }
        public Status IssueStatus { get; set; }
        public Priority IssuePriority { get; set; }

        /// <summary>
        /// This method will be implemented differently in different Issue types(e.g. Operational Issues, Service Issues or Engineering Issues.
        /// </summary>
        /// <returns>string</returns>
        protected internal abstract string ResolveIssue();
    }
}
