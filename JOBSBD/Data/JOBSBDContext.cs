using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JOBSBD.Models;

namespace JOBSBD.Data
{
    public class JOBSBDContext : DbContext
    {
        public JOBSBDContext (DbContextOptions<JOBSBDContext> options)
            : base(options)
        {
        }

     

        public DbSet<PersonalDetail> PersonalDetail { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<IndustryType> IndustryTypes { get; set; }
        public DbSet<CompanyDetails> CompanyDetails { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<JobDetails> JobDetails { get; set; }
        public DbSet<JobRequirement> JobRequirements { get; set; }
        public DbSet<CandidateReq>  CandidateReqs { get; set; }
        public DbSet<PublishJob>  PublishJobs { get; set; }


    }
}
