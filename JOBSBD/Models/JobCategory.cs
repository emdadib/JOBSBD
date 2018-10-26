using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JOBSBD.Models
{
    public class JobCategory
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
      
        public virtual ICollection<JobDetails>  JobDetails { get; set; }
        public virtual CompanyDetails CompanyDetails { get; set; }
        public int CompanyID { get; set; }

    }
}
