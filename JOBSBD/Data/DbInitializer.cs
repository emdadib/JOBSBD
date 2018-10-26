using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JOBSBD.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace JOBSBD.Data
{
    public class DbInitializer
    {
        public static void Seed(JOBSBDContext context)
        {
            //JOBSBDContext context = applicationBuilder.ApplicationServices.GetRequiredService<JOBSBDContext>();
            //UserManager<IdentityUser> userManager = applicationBuilder.ApplicationServices.GetRequiredService<UserManager<IdentityUser>>();

        

            //Data In PersonalDetail
            var PerDetail = new List<PersonalDetail>
            {
                new PersonalDetail
                {
                    FullName ="Md. Emdadul Islam",
                    FathersName ="Md. Nurul Islam",
                    MothersName ="Ayesha Begum",
                    DateOfBirth = DateTime.Parse("1993-03-12"),
                    Nationality ="Bangladesh", Religion="Islam"
                }
            };
            PerDetail.ForEach(x => context.PersonalDetail.Add(x));
           
            //Data In Education
            var Edu = new List<Education>
            {
                new Education
                {
                    Exam_Degree_Title ="Bachelor of Theoretical Islamic Studies",
                    Group_Major_Subject ="Hadith",
                    Institute_University ="Islamic University Bangladesh",
                    Result ="2nd Class",
                    CGPA = decimal.Parse("3.67"),
                    Scale = decimal.Parse("4.00"),
                    Year_Of_Passing = 2015,
                    Duration = 3,
                    Achievement = "PASS",
                    PersonalID = PerDetail.Single(x => x.FullName == "Md. Emdadul Islam").PersonalID
                }
            };
            Edu.ForEach(x => context.Educations.Add(x));

            //Data In Experience
            var Exp = new List<Experience>
            {
                new Experience
                {
                    Company_Name ="Data Soft Ltd.",
                    Company_Business ="Software Firm",
                    Designation ="Assit. Programmer",
                    Department =".NET",
                    start_Date = DateTime.Parse("2017-01-01"),
                    End_Date = DateTime.Parse("2018-01-05"),
                    Skill = "Developeing ASP.NET Based Application, Dekstop App, Web based Apps ",
                    PersonalID = PerDetail.Single(x => x.FullName == "Md. Emdadul Islam").PersonalID
                }
            };
            Exp.ForEach(x => context.Experiences.Add(x));
       
            //Data In Training
            var Trains = new List<Training>
            {
                new Training
                {
                    Training_Title ="ESAD-CS",
                    Country ="Bangladesh",
                    Topics_Covered ="Asp.Net Web Framework, Asp.net Dekstop App, Etc.",
                    Training_Year = 2018,
                    Institute = "IDB-BISEW",
                    Duration = "1 Year",
                    Location = "Chittagong",
                    PersonalID = PerDetail.Single(x => x.FullName == "Md. Emdadul Islam").PersonalID
                }
            };
            Trains.ForEach(x => context.Trainings.Add(x));


            //Data In Organization
            var Org = new List<Organization>
            {
                new Organization {OrganizationType="Goverment"},
                new Organization {OrganizationType="Semi Goverment"},
                new Organization {OrganizationType="NGO"},
                new Organization {OrganizationType="Privte Firm/Company"},
                new Organization {OrganizationType="International Agencies"},
                new Organization {OrganizationType="Others"}
              
            };
            Org.ForEach(x => context.Organizations.Add(x));
          
            //Data In IndustryType
            var Industry = new List<IndustryType>
            {
                new IndustryType {OrgId= Org.Single(x => x.OrganizationType == "Goverment").OrgId, CompanyType="Govt./Autonomous"},
                new IndustryType {OrgId= Org.Single(x => x.OrganizationType == "Semi Goverment").OrgId, CompanyType="Semi-Govt./Autonomous"},
                new IndustryType {OrgId= Org.Single(x => x.OrganizationType == "NGO").OrgId,CompanyType="NGO/Development"},
                new IndustryType {OrgId= Org.Single(x => x.OrganizationType =="Privte Firm/Company").OrgId, CompanyType="Food & Beverage Industry"},
                new IndustryType {OrgId= Org.Single(x => x.OrganizationType =="International Agencies").OrgId, CompanyType="NGO/Development"},
              
            };
            Industry.ForEach(x => context.IndustryTypes.Add(x));


            //Data In CompanyDetails
            var CmpDetls = new List<CompanyDetails>
            {
                new CompanyDetails
                {
                    CompanyName="Meghna Group of Industries Ltd.",
                    ContactPersion ="Jahidul Islam",
                    Designation ="Marketing Officer",
                    Mobile ="0187274949",
                    webSite = "https://www.meghnagroup.biz/",
                    CompanyAddress = "Fresh Villa Fresh Villa, House # 15, Road # 34 Gulshan-1, Dhaka-1212, Bangladesh. ",
                    City = "Dhaka",
                    BillingAddress = "Fresh Villa Fresh Villa, House # 15, Road # 34 Gulshan-1, Dhaka-1212",
                    Phone = "+880-2-9887545",
                    IndTypeId = Industry.Single(x => x.CompanyType == "Food & Beverage Industry").IndTypeId
                }
            };
            CmpDetls.ForEach(x => context.CompanyDetails.Add(x));

            
            //Data In JobCategory
            var JobCtgry = new List<JobCategory>
            {
                new JobCategory
                {
                    CategoryName="Accounting/Finance",
                    CompanyID = CmpDetls.Single(x => x.CompanyName == "Meghna Group of Industries Ltd.").CompanyID
                } 
              
            };
            JobCtgry.ForEach(x => context.JobCategories.Add(x));
          

            //Data In JobRequirement
            var JobDetails = new List<JobDetails>
            {
                new JobDetails
                {
                    Job_Title ="Executive, Finance & Administration",
                    No_Of_Vacancies = 2,
                    Employment_Status = EmploymentStatus.FullTime,
                    DeadLine =DateTime.Parse("2018-09-30"),
                    CV_Receiving_Option = CVReceivingOption.ByEmail,
                    Special_Instruction = "Responsible for sales code creation, ",
                    Job_Level = JobLevel.Entry,
                    CategoryID = JobCtgry.Single(x => x.CategoryName == "Accounting/Finance").CategoryID
                }
            };
            JobDetails.ForEach(x => context.JobDetails.Add(x));
   

            //Data In JobRequirement
            var Req = new List<JobRequirement>
            {
                new JobRequirement
                {
                    Job_Responsibilities ="Responsible for sales code creation, maintenance and track revenue in operation and accounting software.",
                    Job_Location ="Chittagong",
                    Salary_Minimum = 20000,
                    Salary_Maximum =30000,
                    Salary_Type = SalaryType.Monthly,
                    IsNegotiable = true,
                    Company_Benefits = " Mobile_Bill, Medical_allowance, Performance_bonus, Provident_fund, Weekly_2_holidays,",
                    Festival_Bonus=2,
                    Other_Fecilities = "Insurance, Gratuity",
                    Age_Minimum = 25,
                    Age_Maximum = 35,
                    JobDetailsID = JobDetails.Single(x => x.Job_Title == "Executive, Finance & Administration").JobDetailsID
                }
            };
            Req.ForEach(x => context.JobRequirements.Add(x));
            context.SaveChanges();





        }
    }
}
