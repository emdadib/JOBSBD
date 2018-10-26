using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JOBSBD.Models
{
    public class PublishJob
    {
        [Key]
        public int PublishID { get; set; }
        public DateTime PublishDate { get; set; }
        public virtual CandidateReq  CandidateReq { get; set; }
        public int CanDidateRqID { get; set; }
    }
}