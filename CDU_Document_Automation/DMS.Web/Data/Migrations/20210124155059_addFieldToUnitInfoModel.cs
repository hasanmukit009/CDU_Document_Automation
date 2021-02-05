using Microsoft.EntityFrameworkCore.Migrations;

namespace DMS.Web.Data.Migrations
{
    public partial class addFieldToUnitInfoModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeedbackByAdmin",
                table: "DMS_UNIT_INFO");

            migrationBuilder.AddColumn<string>(
                name: "Approver",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssignedApprover",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssignedReviewer1",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssignedReviewer2",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reviewer1",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reviewer2",
                table: "DMS_UNIT_INFO",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Approver",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "AssignedApprover",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "AssignedReviewer1",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "AssignedReviewer2",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "Reviewer1",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "Reviewer2",
                table: "DMS_UNIT_INFO");

            migrationBuilder.AddColumn<string>(
                name: "FeedbackByAdmin",
                table: "DMS_UNIT_INFO",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
