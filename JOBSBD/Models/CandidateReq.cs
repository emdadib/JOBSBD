using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JOBSBD.Models
{
    public class CandidateReq
    {
        [Key]
        public int CanDidateRqID { get; set; }
        public string DegreeLevel { get; set; }
        public string DegreeName { get; set; }
        public string MajorSubject { get; set; }
        public string PrefInstitution { get; set; }
        public string Training_TradCourse { get; set; }
        public Nullable<bool> ExperienceNeeded { get; set; }
        public Nullable<bool> FreshersApply { get; set; }
        public string Area_Of_Experiance { get; set; }
        public string Skills { get; set; }
        public string AdditionalRequirements { get; set; }
        public string  Gender { get; set; }
        public Nullable<int> AgeMin { get; set; }
        public Nullable<int> AgeMax { get; set; }
        public virtual JobRequirement JobRequirement { get; set; }
        public int JobReqID { get; set; }
        public ICollection<PublishJob>  PublishJobs { get; set; }
    }

   
}
