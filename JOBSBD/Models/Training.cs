using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JOBSBD.Models
{
    public class Training
    {
        [Key]
        public int TrainingID { get; set; }
        public string Training_Title { get; set; }
        public string Country { get; set; }
        public string Topics_Covered { get; set; }
        public Nullable<int> Training_Year { get; set; }
        public string Institute { get; set; }
        public string Duration { get; set; }
        public string Location { get; set; }
       
        public virtual PersonalDetail PersonalDetail { get; set; }
        public int PersonalID { get; set; }

    }
}
