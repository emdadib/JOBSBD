using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JOBSBD.Models
{
    public class CompanyDetails
    {
        [Key]
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string ContactPersion { get; set; }
        public string Designation { get; set; }
        public string Mobile { get; set; }
        public string webSite { get; set; }
        public string CompanyAddress { get; set; }
        public string City { get; set; }
        public string BillingAddress { get; set; }
        public string Phone { get; set; }
        public string CompanyLogo { get; set; }
        public virtual IndustryType IndustryType { get; set; }
        public int IndTypeId { get; set; }
        public virtual ICollection<JobCategory> JobCategories { get; set; }
    }
}
