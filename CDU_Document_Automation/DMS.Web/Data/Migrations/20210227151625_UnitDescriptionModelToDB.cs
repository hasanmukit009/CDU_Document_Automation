using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DMS.Web.Data.Migrations
{
    public partial class UnitDescriptionModelToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DMS_UNIT_DESC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChangeRequest = table.Column<string>(nullable: true),
                    UnitCode = table.Column<string>(nullable: true),
                    UnitTitle = table.Column<string>(nullable: true),
                    UnitNumber = table.Column<string>(nullable: true),
                    OwningCollege = table.Column<string>(nullable: true),
                    OwningDiscipline = table.Column<string>(nullable: true),
                    CoreCourseCode = table.Column<string>(nullable: true),
                    SpecialistElectiveCourseCode = table.Column<string>(nullable: true),
                    CurrentUnitDescription = table.Column<string>(nullable: true),
                    TypeOfChangeRequest = table.Column<string>(nullable: true),
                    ProposedUnitDescription = table.Column<string>(nullable: true),
                    JustificatioRequestOutline = table.Column<string>(nullable: true),
                    DomesticStudentNumber = table.Column<string>(nullable: true),
                    InternationalStudentNumber = table.Column<string>(nullable: true),
                    ObligationsDetails = table.Column<string>(nullable: true),
                    RemovalEffectDetails = table.Column<string>(nullable: true),
                    Summary_Of_Consultation_With_Impacted_College = table.Column<string>(nullable: true),
                    UnitCoordinator = table.Column<string>(nullable: true),
                    FeedbackByUC = table.Column<string>(nullable: true),
                    CourseCoordinator = table.Column<string>(nullable: true),
                    AssignedCourseCoordinator = table.Column<string>(nullable: true),
                    FeedbackByCC = table.Column<string>(nullable: true),
                    Admin = table.Column<string>(nullable: true),
                    AssignedAdmin = table.Column<string>(nullable: true),
                    Reviewer1 = table.Column<string>(nullable: true),
                    FeedbackByReviewer1 = table.Column<string>(nullable: true),
                    AssignedReviewer1 = table.Column<string>(nullable: true),
                    IsReviewedByReviewer1 = table.Column<bool>(nullable: false),
                    Reviewer2 = table.Column<string>(nullable: true),
                    FeedbackByReviewer2 = table.Column<string>(nullable: true),
                    AssignedReviewer2 = table.Column<string>(nullable: true),
                    IsReviewedByReviewer2 = table.Column<bool>(nullable: false),
                    Approver = table.Column<string>(nullable: true),
                    FeedbackByApprover = table.Column<string>(nullable: true),
                    AssignedApprover = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    AssignedTo = table.Column<string>(nullable: true),
                    AssignedBy = table.Column<string>(nullable: true),
                    AssignedDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    ActivityLog = table.Column<string>(nullable: true),
                    CurrentPosition = table.Column<string>(nullable: true),
                    OrderByDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMS_UNIT_DESC", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DMS_UNIT_DESC");
        }
    }
}
