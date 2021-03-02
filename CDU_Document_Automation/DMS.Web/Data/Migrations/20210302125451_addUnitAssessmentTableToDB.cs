using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DMS.Web.Data.Migrations
{
    public partial class addUnitAssessmentTableToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DMS_UNIT_AssessmentItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChangeRequest = table.Column<string>(nullable: true),
                    UnitCode = table.Column<string>(nullable: true),
                    UnitTitle = table.Column<string>(nullable: true),
                    UnitLevel = table.Column<string>(nullable: true),
                    OwningCollege = table.Column<string>(nullable: true),
                    OwningDiscipline = table.Column<string>(nullable: true),
                    Semester_Year_of_Implementation = table.Column<string>(nullable: true),
                    Order_1 = table.Column<string>(nullable: true),
                    Order_2 = table.Column<string>(nullable: true),
                    Order_3 = table.Column<string>(nullable: true),
                    Order_4 = table.Column<string>(nullable: true),
                    Order_5 = table.Column<string>(nullable: true),
                    Order_6 = table.Column<string>(nullable: true),
                    Order_7 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_Item_Description_1 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_Item_Description_2 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_Item_Description_3 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_Item_Description_4 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_Item_Description_5 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_Item_Description_6 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_Item_Description_7 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_Percentage_1 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_Percentage_2 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_Percentage_3 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_Percentage_4 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_Percentage_5 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_Percentage_6 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_Percentage_7 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_ULO_1 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_ULO_2 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_ULO_3 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_ULO_4 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_ULO_5 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_ULO_6 = table.Column<string>(nullable: true),
                    Current_Accredited_Assessment_ULO_7 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_Description_1 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_Description_2 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_Description_3 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_Description_4 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_Description_5 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_Description_6 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_Description_7 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_Percentage_1 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_Percentage_2 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_Percentage_3 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_Percentage_4 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_Percentage_5 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_Percentage_6 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_Percentage_7 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_ULO_1 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_ULO_2 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_ULO_3 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_ULO_4 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_ULO_5 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_ULO_6 = table.Column<string>(nullable: true),
                    Proposed_Assessment_Items_ULO_7 = table.Column<string>(nullable: true),
                    Is_This_Unit_Currently_Accredited = table.Column<string>(nullable: true),
                    Is_This_Unit_Required = table.Column<string>(nullable: true),
                    JustificatioRequestOutline = table.Column<string>(nullable: true),
                    DomesticStudentNumber = table.Column<string>(nullable: true),
                    InternationalStudentNumber = table.Column<string>(nullable: true),
                    ReviewedCoreCourseList = table.Column<string>(nullable: true),
                    ReviewedSpecialistElectiveCourseList = table.Column<string>(nullable: true),
                    Provide_Summary_If_Student_Consultation_Was_Undertaken = table.Column<string>(nullable: true),
                    Provide_Summary_If_The_Proposed_Change_Response_To_Student = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_DMS_UNIT_AssessmentItem", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DMS_UNIT_AssessmentItem");
        }
    }
}
