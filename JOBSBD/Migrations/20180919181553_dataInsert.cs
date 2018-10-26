using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JOBSBD.Migrations
{
    public partial class dataInsert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyDetails_IndustryTypes_IndustryTypeId",
                table: "CompanyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_JobRequirements_JobCategories_CategoryID",
                table: "JobRequirements");

            migrationBuilder.DropIndex(
                name: "IX_CompanyDetails_IndustryTypeId",
                table: "CompanyDetails");

            migrationBuilder.DropColumn(
                name: "Area_Of_Experiance",
                table: "JobRequirements");

            migrationBuilder.DropColumn(
                name: "Skills",
                table: "JobRequirements");

            migrationBuilder.DropColumn(
                name: "Training_TradCourse",
                table: "JobRequirements");

            migrationBuilder.DropColumn(
                name: "EducationID",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "Laval_Of_Education",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "IndustryTypeId",
                table: "CompanyDetails");

            migrationBuilder.RenameColumn(
                name: "Nationnality",
                table: "PersonalDetail",
                newName: "Nationality");

            migrationBuilder.RenameColumn(
                name: "Experiance_Needed",
                table: "JobRequirements",
                newName: "IsNegotiable");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "JobRequirements",
                newName: "JobDetailsID");

            migrationBuilder.RenameIndex(
                name: "IX_JobRequirements_CategoryID",
                table: "JobRequirements",
                newName: "IX_JobRequirements_JobDetailsID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "IndustryTypes",
                newName: "IndTypeId");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "PersonalDetail",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Salary_Type",
                table: "JobRequirements",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Salary_Minimum",
                table: "JobRequirements",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Salary_Maximum",
                table: "JobRequirements",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Job_Level",
                table: "JobDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Employment_Status",
                table: "JobDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CV_Receiving_Option",
                table: "JobDetails",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrgId",
                table: "IndustryTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "CompanyDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IndTypeId",
                table: "CompanyDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CandidateReqs",
                columns: table => new
                {
                    CanDidateRqID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DegreeLevel = table.Column<string>(nullable: true),
                    DegreeName = table.Column<string>(nullable: true),
                    MajorSubject = table.Column<string>(nullable: true),
                    PrefInstitution = table.Column<string>(nullable: true),
                    Training_TradCourse = table.Column<string>(nullable: true),
                    ExperienceNeeded = table.Column<bool>(nullable: true),
                    FreshersApply = table.Column<bool>(nullable: true),
                    Area_Of_Experiance = table.Column<string>(nullable: true),
                    Skills = table.Column<string>(nullable: true),
                    AdditionalRequirements = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    AgeMin = table.Column<int>(nullable: true),
                    AgeMax = table.Column<int>(nullable: true),
                    JobReqID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateReqs", x => x.CanDidateRqID);
                    table.ForeignKey(
                        name: "FK_CandidateReqs_JobRequirements_JobReqID",
                        column: x => x.JobReqID,
                        principalTable: "JobRequirements",
                        principalColumn: "JobReqID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    OrgId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrganizationType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.OrgId);
                });

            migrationBuilder.CreateTable(
                name: "PublishJobs",
                columns: table => new
                {
                    PublishID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    CanDidateRqID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublishJobs", x => x.PublishID);
                    table.ForeignKey(
                        name: "FK_PublishJobs_CandidateReqs_CanDidateRqID",
                        column: x => x.CanDidateRqID,
                        principalTable: "CandidateReqs",
                        principalColumn: "CanDidateRqID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustryTypes_OrgId",
                table: "IndustryTypes",
                column: "OrgId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDetails_IndTypeId",
                table: "CompanyDetails",
                column: "IndTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateReqs_JobReqID",
                table: "CandidateReqs",
                column: "JobReqID");

            migrationBuilder.CreateIndex(
                name: "IX_PublishJobs_CanDidateRqID",
                table: "PublishJobs",
                column: "CanDidateRqID");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyDetails_IndustryTypes_IndTypeId",
                table: "CompanyDetails",
                column: "IndTypeId",
                principalTable: "IndustryTypes",
                principalColumn: "IndTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryTypes_Organizations_OrgId",
                table: "IndustryTypes",
                column: "OrgId",
                principalTable: "Organizations",
                principalColumn: "OrgId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobRequirements_JobDetails_JobDetailsID",
                table: "JobRequirements",
                column: "JobDetailsID",
                principalTable: "JobDetails",
                principalColumn: "JobDetailsID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyDetails_IndustryTypes_IndTypeId",
                table: "CompanyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustryTypes_Organizations_OrgId",
                table: "IndustryTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_JobRequirements_JobDetails_JobDetailsID",
                table: "JobRequirements");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "PublishJobs");

            migrationBuilder.DropTable(
                name: "CandidateReqs");

            migrationBuilder.DropIndex(
                name: "IX_IndustryTypes_OrgId",
                table: "IndustryTypes");

            migrationBuilder.DropIndex(
                name: "IX_CompanyDetails_IndTypeId",
                table: "CompanyDetails");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "PersonalDetail");

            migrationBuilder.DropColumn(
                name: "OrgId",
                table: "IndustryTypes");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "CompanyDetails");

            migrationBuilder.DropColumn(
                name: "IndTypeId",
                table: "CompanyDetails");

            migrationBuilder.RenameColumn(
                name: "Nationality",
                table: "PersonalDetail",
                newName: "Nationnality");

            migrationBuilder.RenameColumn(
                name: "JobDetailsID",
                table: "JobRequirements",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "IsNegotiable",
                table: "JobRequirements",
                newName: "Experiance_Needed");

            migrationBuilder.RenameIndex(
                name: "IX_JobRequirements_JobDetailsID",
                table: "JobRequirements",
                newName: "IX_JobRequirements_CategoryID");

            migrationBuilder.RenameColumn(
                name: "IndTypeId",
                table: "IndustryTypes",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Salary_Type",
                table: "JobRequirements",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Salary_Minimum",
                table: "JobRequirements",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Salary_Maximum",
                table: "JobRequirements",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Area_Of_Experiance",
                table: "JobRequirements",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Skills",
                table: "JobRequirements",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Training_TradCourse",
                table: "JobRequirements",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Job_Level",
                table: "JobDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Employment_Status",
                table: "JobDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "CV_Receiving_Option",
                table: "JobDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "EducationID",
                table: "Experiences",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Laval_Of_Education",
                table: "Educations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IndustryTypeId",
                table: "CompanyDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDetails_IndustryTypeId",
                table: "CompanyDetails",
                column: "IndustryTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyDetails_IndustryTypes_IndustryTypeId",
                table: "CompanyDetails",
                column: "IndustryTypeId",
                principalTable: "IndustryTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobRequirements_JobCategories_CategoryID",
                table: "JobRequirements",
                column: "CategoryID",
                principalTable: "JobCategories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
