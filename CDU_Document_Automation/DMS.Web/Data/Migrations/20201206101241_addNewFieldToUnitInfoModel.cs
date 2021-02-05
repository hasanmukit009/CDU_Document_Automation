using Microsoft.EntityFrameworkCore.Migrations;

namespace DMS.Web.Data.Migrations
{
    public partial class addNewFieldToUnitInfoModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssessmentOverview",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule",
                table: "DMS_UNIT_INFO");

            migrationBuilder.AddColumn<string>(
                name: "Assessment_Overview_Description_1",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Assessment_Overview_Description_2",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Assessment_Overview_Description_3",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Assessment_Overview_Description_4",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Assessment_Overview_Item_1",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Assessment_Overview_Item_2",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Assessment_Overview_Item_3",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Assessment_Overview_Item_4",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Assessment_Overview_Learning_Outcome_1",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Assessment_Overview_Learning_Outcome_2",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Assessment_Overview_Learning_Outcome_3",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Assessment_Overview_Learning_Outcome_4",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Assessment_Overview_Value_1",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Assessment_Overview_Value_2",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Assessment_Overview_Value_3",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Assessment_Overview_Value_4",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Assessments_1",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Assessments_10",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Assessments_11",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Assessments_12",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Assessments_13",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Assessments_14",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Assessments_15",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Assessments_2",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Assessments_3",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Assessments_4",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Assessments_5",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Assessments_6",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Assessments_7",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Assessments_8",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Assessments_9",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Topic_1",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Topic_10",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Topic_11",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Topic_12",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Topic_13",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Topic_14",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Topic_15",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Topic_2",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Topic_3",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Topic_4",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Topic_5",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Topic_6",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Topic_7",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Topic_8",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Topic_9",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Tutorial_1",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Tutorial_10",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Tutorial_11",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Tutorial_12",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Tutorial_13",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Tutorial_14",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Tutorial_15",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Tutorial_2",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Tutorial_3",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Tutorial_4",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Tutorial_5",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Tutorial_6",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Tutorial_7",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Tutorial_8",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Tutorial_9",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Week_1",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Week_10",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Week_11",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Week_12",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Week_13",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Week_14",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Week_15",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Week_2",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Week_3",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Week_4",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Week_5",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Week_6",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Week_7",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Week_8",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule_Week_9",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeachingAndLearningApproach",
                table: "DMS_UNIT_INFO",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Assessment_Overview_Description_1",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "Assessment_Overview_Description_2",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "Assessment_Overview_Description_3",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "Assessment_Overview_Description_4",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "Assessment_Overview_Item_1",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "Assessment_Overview_Item_2",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "Assessment_Overview_Item_3",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "Assessment_Overview_Item_4",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "Assessment_Overview_Learning_Outcome_1",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "Assessment_Overview_Learning_Outcome_2",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "Assessment_Overview_Learning_Outcome_3",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "Assessment_Overview_Learning_Outcome_4",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "Assessment_Overview_Value_1",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "Assessment_Overview_Value_2",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "Assessment_Overview_Value_3",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "Assessment_Overview_Value_4",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Assessments_1",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Assessments_10",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Assessments_11",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Assessments_12",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Assessments_13",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Assessments_14",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Assessments_15",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Assessments_2",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Assessments_3",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Assessments_4",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Assessments_5",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Assessments_6",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Assessments_7",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Assessments_8",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Assessments_9",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Topic_1",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Topic_10",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Topic_11",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Topic_12",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Topic_13",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Topic_14",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Topic_15",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Topic_2",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Topic_3",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Topic_4",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Topic_5",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Topic_6",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Topic_7",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Topic_8",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Topic_9",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Tutorial_1",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Tutorial_10",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Tutorial_11",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Tutorial_12",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Tutorial_13",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Tutorial_14",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Tutorial_15",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Tutorial_2",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Tutorial_3",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Tutorial_4",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Tutorial_5",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Tutorial_6",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Tutorial_7",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Tutorial_8",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Tutorial_9",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Week_1",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Week_10",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Week_11",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Week_12",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Week_13",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Week_14",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Week_15",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Week_2",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Week_3",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Week_4",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Week_5",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Week_6",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Week_7",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Week_8",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "LearningSchedule_Week_9",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "TeachingAndLearningApproach",
                table: "DMS_UNIT_INFO");

            migrationBuilder.AddColumn<string>(
                name: "AssessmentOverview",
                table: "DMS_UNIT_INFO",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LearningSchedule",
                table: "DMS_UNIT_INFO",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
