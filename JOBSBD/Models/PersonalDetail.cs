using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JOBSBD.Models
{
    public class PersonalDetail
    {
        [Key]
        public int PersonalID { get; set; }
        public string FullName { get; set; }
        public string FathersName { get; set; }
        public string MothersName { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Religion { get; set; }
        public string Nationality { get; set; }
        public string MaritalStatus { get; set; }
        public string UserPicture { get; set; }

        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Training> Trainings { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
    }
}
