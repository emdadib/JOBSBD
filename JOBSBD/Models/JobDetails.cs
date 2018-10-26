using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JOBSBD.Models
{
    public class JobDetails
    {
        [Key]
        public int JobDetailsID { get; set; }
        public string Job_Title { get; set; }
        public Nullable<int> No_Of_Vacancies { get; set; }
        public EmploymentStatus Employment_Status { get; set; }
        public Nullable<System.DateTime> DeadLine { get; set; }
        public CVReceivingOption CV_Receiving_Option { get; set; }
        public string Special_Instruction { get; set; }
        public JobLevel Job_Level { get; set; }
        public virtual ICollection<JobRequirement> JobRequirements { get; set; }
        public virtual JobCategory JobCategory { get; set; }
        public int CategoryID { get; set; }


    }

    public enum JobLevel
    {
        Mind, Top, Entry
    }

    public enum EmploymentStatus
    {
        FullTime, PartTime, Hourly, Negotiable
    }

    public enum CVReceivingOption
    {
        ByEmail, ByCourier, ByPost, WalkOnInterView
    }
}
