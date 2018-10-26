using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JOBSBD.Migrations
{
    public partial class Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndustryTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustryTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalDetail",
                columns: table => new
                {
                    PersonalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FathersName = table.Column<string>(nullable: true),
                    MothersName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    Religion = table.Column<string>(nullable: true),
                    Nationnality = table.Column<string>(nullable: true),
                    MaritalStatus = table.Column<string>(nullable: true),
                    UserPicture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDetail", x => x.PersonalID);
                });

            migrationBuilder.CreateTable(
                name: "CompanyDetails",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactPersion = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    webSite = table.Column<string>(nullable: true),
                    CompanyAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    BillingAddress = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    CompanyLogo = table.Column<string>(nullable: true),
                    IndustryTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyDetails", x => x.CompanyID);
                    table.ForeignKey(
                        name: "FK_CompanyDetails_IndustryTypes_IndustryTypeId",
                        column: x => x.IndustryTypeId,
                        principalTable: "IndustryTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    EduID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Laval_Of_Education = table.Column<string>(nullable: true),
                    Exam_Degree_Title = table.Column<string>(nullable: true),
                    Group_Major_Subject = table.Column<string>(nullable: true),
                    Institute_University = table.Column<string>(nullable: true),
                    Result = table.Column<string>(nullable: true),
                    CGPA = table.Column<decimal>(nullable: true),
                    Scale = table.Column<decimal>(nullable: true),
                    Year_Of_Passing = table.Column<int>(nullable: true),
                    Duration = table.Column<int>(nullable: true),
                    Achievement = table.Column<string>(nullable: true),
                    PersonalID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EduID);
                    table.ForeignKey(
                        name: "FK_Educations_PersonalDetail_PersonalID",
                        column: x => x.PersonalID,
                        principalTable: "PersonalDetail",
                        principalColumn: "PersonalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    ExperienceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EducationID = table.Column<int>(nullable: true),
                    Company_Name = table.Column<string>(nullable: true),
                    Company_Business = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    start_Date = table.Column<DateTime>(nullable: true),
                    End_Date = table.Column<DateTime>(nullable: true),
                    Skill = table.Column<string>(nullable: true),
                    PersonalID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.ExperienceID);
                    table.ForeignKey(
                        name: "FK_Experiences_PersonalDetail_PersonalID",
                        column: x => x.PersonalID,
                        principalTable: "PersonalDetail",
                        principalColumn: "PersonalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    TrainingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Training_Title = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Topics_Covered = table.Column<string>(nullable: true),
                    Training_Year = table.Column<int>(nullable: true),
                    Institute = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    PersonalID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.TrainingID);
                    table.ForeignKey(
                        name: "FK_Trainings_PersonalDetail_PersonalID",
                        column: x => x.PersonalID,
                        principalTable: "PersonalDetail",
                        principalColumn: "PersonalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobCategories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true),
                    CompanyID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategories", x => x.CategoryID);
                    table.ForeignKey(
                        name: "FK_JobCategories_CompanyDetails_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "CompanyDetails",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobDetails",
                columns: table => new
                {
                    JobDetailsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Job_Title = table.Column<string>(nullable: true),
                    No_Of_Vacancies = table.Column<int>(nullable: true),
                    Employment_Status = table.Column<string>(nullable: true),
                    DeadLine = table.Column<DateTime>(nullable: true),
                    CV_Receiving_Option = table.Column<bool>(nullable: true),
                    Special_Instruction = table.Column<string>(nullable: true),
                    Job_Level = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobDetails", x => x.JobDetailsID);
                    table.ForeignKey(
                        name: "FK_JobDetails_JobCategories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "JobCategories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobRequirements",
                columns: table => new
                {
                    JobReqID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Training_TradCourse = table.Column<string>(nullable: true),
                    Experiance_Needed = table.Column<bool>(nullable: true),
                    Area_Of_Experiance = table.Column<string>(nullable: true),
                    Skills = table.Column<string>(nullable: true),
                    Job_Responsibilities = table.Column<string>(nullable: true),
                    Job_Location = table.Column<string>(nullable: true),
                    Salary_Minimum = table.Column<string>(nullable: true),
                    Salary_Maximum = table.Column<string>(nullable: true),
                    Salary_Type = table.Column<string>(nullable: true),
                    Company_Benefits = table.Column<string>(nullable: true),
                    Festival_Bonus = table.Column<int>(nullable: true),
                    Other_Fecilities = table.Column<string>(nullable: true),
                    Age_Minimum = table.Column<int>(nullable: true),
                    Age_Maximum = table.Column<int>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRequirements", x => x.JobReqID);
                    table.ForeignKey(
                        name: "FK_JobRequirements_JobCategories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "JobCategories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDetails_IndustryTypeId",
                table: "CompanyDetails",
                column: "IndustryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_PersonalID",
                table: "Educations",
                column: "PersonalID");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_PersonalID",
                table: "Experiences",
                column: "PersonalID");

            migrationBuilder.CreateIndex(
                name: "IX_JobCategories_CompanyID",
                table: "JobCategories",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_JobDetails_CategoryID",
                table: "JobDetails",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_JobRequirements_CategoryID",
                table: "JobRequirements",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_PersonalID",
                table: "Trainings",
                column: "PersonalID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "JobDetails");

            migrationBuilder.DropTable(
                name: "JobRequirements");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "JobCategories");

            migrationBuilder.DropTable(
                name: "PersonalDetail");

            migrationBuilder.DropTable(
                name: "CompanyDetails");

            migrationBuilder.DropTable(
                name: "IndustryTypes");
        }
    }
}
