﻿// <auto-generated />
using System;
using JOBSBD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JOBSBD.Migrations
{
    [DbContext(typeof(JOBSBDContext))]
    partial class JOBSBDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JOBSBD.Models.CandidateReq", b =>
                {
                    b.Property<int>("CanDidateRqID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalRequirements");

                    b.Property<int?>("AgeMax");

                    b.Property<int?>("AgeMin");

                    b.Property<string>("Area_Of_Experiance");

                    b.Property<string>("DegreeLevel");

                    b.Property<string>("DegreeName");

                    b.Property<bool?>("ExperienceNeeded");

                    b.Property<bool?>("FreshersApply");

                    b.Property<string>("Gender");

                    b.Property<int>("JobReqID");

                    b.Property<string>("MajorSubject");

                    b.Property<string>("PrefInstitution");

                    b.Property<string>("Skills");

                    b.Property<string>("Training_TradCourse");

                    b.HasKey("CanDidateRqID");

                    b.HasIndex("JobReqID");

                    b.ToTable("CandidateReqs");
                });

            modelBuilder.Entity("JOBSBD.Models.CompanyDetails", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BillingAddress");

                    b.Property<string>("City");

                    b.Property<string>("CompanyAddress");

                    b.Property<string>("CompanyLogo");

                    b.Property<string>("CompanyName");

                    b.Property<string>("ContactPersion");

                    b.Property<string>("Designation");

                    b.Property<int>("IndTypeId");

                    b.Property<string>("Mobile");

                    b.Property<string>("Phone");

                    b.Property<string>("webSite");

                    b.HasKey("CompanyID");

                    b.HasIndex("IndTypeId");

                    b.ToTable("CompanyDetails");
                });

            modelBuilder.Entity("JOBSBD.Models.Education", b =>
                {
                    b.Property<int>("EduID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Achievement");

                    b.Property<decimal?>("CGPA");

                    b.Property<int?>("Duration");

                    b.Property<string>("Exam_Degree_Title");

                    b.Property<string>("Group_Major_Subject");

                    b.Property<string>("Institute_University");

                    b.Property<int>("PersonalID");

                    b.Property<string>("Result");

                    b.Property<decimal?>("Scale");

                    b.Property<int?>("Year_Of_Passing");

                    b.HasKey("EduID");

                    b.HasIndex("PersonalID");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("JOBSBD.Models.Experience", b =>
                {
                    b.Property<int>("ExperienceID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company_Business");

                    b.Property<string>("Company_Name");

                    b.Property<string>("Department");

                    b.Property<string>("Designation");

                    b.Property<DateTime?>("End_Date");

                    b.Property<int>("PersonalID");

                    b.Property<string>("Skill");

                    b.Property<DateTime?>("start_Date");

                    b.HasKey("ExperienceID");

                    b.HasIndex("PersonalID");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("JOBSBD.Models.IndustryType", b =>
                {
                    b.Property<int>("IndTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyType");

                    b.Property<int>("OrgId");

                    b.HasKey("IndTypeId");

                    b.HasIndex("OrgId");

                    b.ToTable("IndustryTypes");
                });

            modelBuilder.Entity("JOBSBD.Models.JobCategory", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<int>("CompanyID");

                    b.HasKey("CategoryID");

                    b.HasIndex("CompanyID");

                    b.ToTable("JobCategories");
                });

            modelBuilder.Entity("JOBSBD.Models.JobDetails", b =>
                {
                    b.Property<int>("JobDetailsID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CV_Receiving_Option");

                    b.Property<int>("CategoryID");

                    b.Property<DateTime?>("DeadLine");

                    b.Property<int>("Employment_Status");

                    b.Property<int>("Job_Level");

                    b.Property<string>("Job_Title");

                    b.Property<int?>("No_Of_Vacancies");

                    b.Property<string>("Special_Instruction");

                    b.HasKey("JobDetailsID");

                    b.HasIndex("CategoryID");

                    b.ToTable("JobDetails");
                });

            modelBuilder.Entity("JOBSBD.Models.JobRequirement", b =>
                {
                    b.Property<int>("JobReqID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age_Maximum");

                    b.Property<int?>("Age_Minimum");

                    b.Property<string>("Company_Benefits");

                    b.Property<int?>("Festival_Bonus");

                    b.Property<bool?>("IsNegotiable");

                    b.Property<int>("JobDetailsID");

                    b.Property<string>("Job_Location");

                    b.Property<string>("Job_Responsibilities");

                    b.Property<string>("Other_Fecilities");

                    b.Property<int?>("Salary_Maximum");

                    b.Property<int?>("Salary_Minimum");

                    b.Property<int>("Salary_Type");

                    b.HasKey("JobReqID");

                    b.HasIndex("JobDetailsID");

                    b.ToTable("JobRequirements");
                });

            modelBuilder.Entity("JOBSBD.Models.Organization", b =>
                {
                    b.Property<int>("OrgId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OrganizationType");

                    b.HasKey("OrgId");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("JOBSBD.Models.PersonalDetail", b =>
                {
                    b.Property<int>("PersonalID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("FathersName");

                    b.Property<string>("FullName");

                    b.Property<string>("MaritalStatus");

                    b.Property<string>("MothersName");

                    b.Property<string>("Nationality");

                    b.Property<string>("Religion");

                    b.Property<string>("UserPicture");

                    b.HasKey("PersonalID");

                    b.ToTable("PersonalDetail");
                });

            modelBuilder.Entity("JOBSBD.Models.PublishJob", b =>
                {
                    b.Property<int>("PublishID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CanDidateRqID");

                    b.Property<DateTime>("PublishDate");

                    b.HasKey("PublishID");

                    b.HasIndex("CanDidateRqID");

                    b.ToTable("PublishJobs");
                });

            modelBuilder.Entity("JOBSBD.Models.Training", b =>
                {
                    b.Property<int>("TrainingID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country");

                    b.Property<string>("Duration");

                    b.Property<string>("Institute");

                    b.Property<string>("Location");

                    b.Property<int>("PersonalID");

                    b.Property<string>("Topics_Covered");

                    b.Property<string>("Training_Title");

                    b.Property<int?>("Training_Year");

                    b.HasKey("TrainingID");

                    b.HasIndex("PersonalID");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("JOBSBD.Models.CandidateReq", b =>
                {
                    b.HasOne("JOBSBD.Models.JobRequirement", "JobRequirement")
                        .WithMany("CandidateReqs")
                        .HasForeignKey("JobReqID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JOBSBD.Models.CompanyDetails", b =>
                {
                    b.HasOne("JOBSBD.Models.IndustryType", "IndustryType")
                        .WithMany("CompanyDetails")
                        .HasForeignKey("IndTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JOBSBD.Models.Education", b =>
                {
                    b.HasOne("JOBSBD.Models.PersonalDetail", "PersonalDetail")
                        .WithMany("Educations")
                        .HasForeignKey("PersonalID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JOBSBD.Models.Experience", b =>
                {
                    b.HasOne("JOBSBD.Models.PersonalDetail", "PersonalDetail")
                        .WithMany("Experiences")
                        .HasForeignKey("PersonalID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JOBSBD.Models.IndustryType", b =>
                {
                    b.HasOne("JOBSBD.Models.Organization", "Organization")
                        .WithMany("IndustryTypes")
                        .HasForeignKey("OrgId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JOBSBD.Models.JobCategory", b =>
                {
                    b.HasOne("JOBSBD.Models.CompanyDetails", "CompanyDetails")
                        .WithMany("JobCategories")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JOBSBD.Models.JobDetails", b =>
                {
                    b.HasOne("JOBSBD.Models.JobCategory", "JobCategory")
                        .WithMany("JobDetails")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JOBSBD.Models.JobRequirement", b =>
                {
                    b.HasOne("JOBSBD.Models.JobDetails", "JobDetails")
                        .WithMany("JobRequirements")
                        .HasForeignKey("JobDetailsID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JOBSBD.Models.PublishJob", b =>
                {
                    b.HasOne("JOBSBD.Models.CandidateReq", "CandidateReq")
                        .WithMany("PublishJobs")
                        .HasForeignKey("CanDidateRqID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JOBSBD.Models.Training", b =>
                {
                    b.HasOne("JOBSBD.Models.PersonalDetail", "PersonalDetail")
                        .WithMany("Trainings")
                        .HasForeignKey("PersonalID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
