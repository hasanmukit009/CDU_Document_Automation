using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DMS.Web.Data.Migrations
{
    public partial class addUnitInformationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DMS_UNIT_INFO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitCode = table.Column<string>(nullable: true),
                    UnitTitle = table.Column<string>(nullable: true),
                    CreditPoints = table.Column<string>(nullable: true),
                    Prerequisites = table.Column<string>(nullable: true),
                    Semester = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    Mode = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    LearningMethod = table.Column<string>(nullable: true),
                    UnitCoordinator = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    UnitDescription = table.Column<string>(nullable: true),
                    LearningOutComes = table.Column<string>(nullable: true),
                    AssessmentOverview = table.Column<string>(nullable: true),
                    TeachingAndLearningApproach_HowUnitRun = table.Column<string>(nullable: true),
                    TeachingAndLearningApproach_LecturerRole = table.Column<string>(nullable: true),
                    TeachingAndLearningApproach_StudentParticipation = table.Column<string>(nullable: true),
                    Resources_RequiredTextbooks = table.Column<string>(nullable: true),
                    Resources_Learnline = table.Column<string>(nullable: true),
                    Resources_eReserveCourseReadings = table.Column<string>(nullable: true),
                    Resources_AdditionalResources = table.Column<string>(nullable: true),
                    LearningSchedule = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    AssignedTo = table.Column<string>(nullable: true),
                    AssignedBy = table.Column<string>(nullable: true),
                    AssignedDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    FeedbackByUC = table.Column<string>(nullable: true),
                    FeedbackByCC = table.Column<string>(nullable: true),
                    FeedbackByAdmin = table.Column<string>(nullable: true),
                    FeedbackByReviewer = table.Column<string>(nullable: true),
                    FeedbackByApprover = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMS_UNIT_INFO", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DMS_UNIT_INFO");
        }
    }
}
