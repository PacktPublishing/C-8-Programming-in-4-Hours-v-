using System;
using System.Collections.Generic;
using IssuesBusinessLogic.Entities;
using IssueTrackerInfrastructure;

namespace IssuesBusinessLogic
{
    public class IssuesBiz : IssueBizContract
    {
        //Initial Data
        List<IssueBase> allIssues = new List<IssueBase>() {
            new EngineeringIssue { IssueID = 101, IssueTitle = "Browser Issue for Web portal", IssueDescription = "User is unable to load web site on IE.", IssuePriority = Priority.Medium, IssueStatus = Status.Open
            },
            new ServiceIssue { IssueID = 102, IssueTitle = "Need Customer Service Email", IssueDescription = "User needs email IT support as the call waiting is quite long. ", IssuePriority = Priority.High, IssueStatus = Status.Open
            },
            new OperationalIssue { IssueID = 103, IssueTitle = "Shipping Service in not available on weekends", IssueDescription = "Need to have some arrangements for shipping over weekends for running business 24X7", IssuePriority = Priority.High, IssueStatus = Status.InProgress
            }
        };

        //Log Helper Class object.
        private LogHelper _objLogHelper;
        public IssuesBiz(LogHelper logHelper)
        {
            _objLogHelper = logHelper;
        }

        //Method to Add new Issue
        public int AddIssue(IssueBase issue)
        {
            allIssues.Add(issue);

            //Log this infomation.
            if (issue.IssueTitle.Length > 15)
                _objLogHelper.LogInfo($"{issue.IssueTitle.Substring(0, 15)} ... Added.");
            else
                _objLogHelper.LogInfo($"{issue.IssueTitle} ... Added.");


            return issue.IssueID;
        }

        /// <summary>
        /// Method to Resolve the issue
        /// </summary>
        /// <param name="issue"></param>
        public void ResolveIssue(IssueBase issue)
        {
            string message = issue.ResolveIssue();
            _objLogHelper.LogInfo(message);
        }

        /// <summary>
        /// Method to GetAllIssues
        /// </summary>
        /// <returns></returns>
        public List<IssueBase> GetAllIssues()
        {
            return allIssues;
        }

        /// <summary>
        /// Method to Get All Issue Types
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllIssueTypes()
        {
            List<string> allIssueTypes = new List<string>()
            {
                "Operational",
                "Service",
                "Engineering"
            };

            return allIssueTypes;
        }

        /// <summary>
        /// Method to get all issue priorities.
        /// </summary>
        /// <returns></returns>
        public List<Priority> GetAllPriority()
        {
            List<Priority> allPriorities = new List<Priority>()
            {
                Priority.Low,
                Priority.Medium,
                Priority.High
            };

            return allPriorities;
        }

        /// <summary>
        /// Method to get All Issue Status
        /// </summary>
        /// <returns></returns>
        public List<Status> GetAllStatus()
        {
            List<Status> allStatus = new List<Status>()
            {
                Status.Open,
                Status.InProgress,
                Status.Closed,
            };

            return allStatus;
        }

        /// <summary>
        /// Method to Update an issue
        /// </summary>
        /// <param name="updatedIssue"></param>
        /// <returns></returns>
        public int UpdateIssue(IssueBase updatedIssue)
        {  
            //Find the issue from the list, remove it and add the updated issue again to the list.
            foreach (var issue in allIssues)
            {
                if (issue.IssueID == updatedIssue.IssueID)
                {
                    allIssues.Remove(issue);//Remove Item from the list.
                    break;
                }
            }


            allIssues.Add(updatedIssue);

            //Log this information
            if (updatedIssue.IssueTitle.Length > 15)
                _objLogHelper.LogInfo($"{updatedIssue.IssueTitle.Substring(0, 15)} ... updated.");
            else
                _objLogHelper.LogInfo($"{updatedIssue.IssueTitle} ... updated.");

            return updatedIssue.IssueID;
        }

        //Method to return Issue Type for an issue object.
        public string GetIssueType(IssueBase issue)
        {
            string type = issue.GetType().Name;
            string result = "";
            switch (type)
            {
                case "EngineeringIssue":
                    result = "Engineering";
                    break;
                case "OperationalIssue":
                    result = "Operational";
                    break;
                case "ServiceIssue":
                    result = "Service";
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
