using Microsoft.EntityFrameworkCore.Migrations;

namespace DMS.Web.Data.Migrations
{
    public partial class addAdminFieldToUIModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeedbackByReviewer",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "FeedbackByUC",
                table: "DMS_UNIT_INFO");

            migrationBuilder.AddColumn<string>(
                name: "Admin",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssignedAdmin",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeedbackByReviewer1",
                table: "DMS_UNIT_INFO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeedbackByReviewer2",
                table: "DMS_UNIT_INFO",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Admin",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "AssignedAdmin",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "FeedbackByReviewer1",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "FeedbackByReviewer2",
                table: "DMS_UNIT_INFO");

            migrationBuilder.AddColumn<string>(
                name: "FeedbackByReviewer",
                table: "DMS_UNIT_INFO",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeedbackByUC",
                table: "DMS_UNIT_INFO",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
