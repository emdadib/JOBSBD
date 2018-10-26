using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JOBSBD.Models
{
    public class IndustryType
    {
        [Key]
        public int IndTypeId { get; set; }
        public string CompanyType { get; set; }
        public virtual Organization Organization { get; set; }
        public int OrgId { get; set; }
        public virtual ICollection<CompanyDetails> CompanyDetails { get; set; }
    }
}
