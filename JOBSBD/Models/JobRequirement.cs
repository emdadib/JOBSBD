using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JOBSBD.Models
{
    public class JobRequirement
    {
        [Key]
        public int JobReqID { get; set; }
        public string Job_Responsibilities { get; set; }
        public string Job_Location { get; set; }
        public Nullable<int> Salary_Minimum { get; set; }
        public Nullable<int> Salary_Maximum { get; set; }
        public SalaryType Salary_Type { get; set; }
        public Nullable<bool> IsNegotiable { get; set; }
        public string Company_Benefits { get; set; }
        public Nullable<int> Festival_Bonus { get; set; }
        public string Other_Fecilities { get; set; }
        public Nullable<int> Age_Minimum { get; set; }
        public Nullable<int> Age_Maximum { get; set; }
        public virtual JobDetails JobDetails { get; set; }
        public int JobDetailsID { get; set; }
        public virtual ICollection<CandidateReq> CandidateReqs { get; set; }
    }
    public enum SalaryType
    {
        Monthly, Hourly, Daily, Yearly
    }

  
}
