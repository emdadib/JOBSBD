﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JOBSBD.Models
{
    public class Education
    {
        [Key]
        public int EduID { get; set; }
        public string Exam_Degree_Title { get; set; }
        public string Group_Major_Subject { get; set; }
        public string Institute_University { get; set; }
        public string Result { get; set; }
        public Nullable<decimal> CGPA { get; set; }
        public Nullable<decimal> Scale { get; set; }
        public Nullable<int> Year_Of_Passing { get; set; }
        public Nullable<int> Duration { get; set; }
        public string Achievement { get; set; }
        public virtual PersonalDetail PersonalDetail { get; set; }
        public int PersonalID { get; set; }



    }
}
