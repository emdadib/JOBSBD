using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JOBSBD.Models
{
    public class Organization
    {
        [Key]
        public int OrgId { get; set; }
        public string OrganizationType { get; set; }
        public virtual ICollection<IndustryType> IndustryTypes { get; set; }
    }
}
