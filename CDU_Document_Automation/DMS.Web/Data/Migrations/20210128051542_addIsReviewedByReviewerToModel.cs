using Microsoft.EntityFrameworkCore.Migrations;

namespace DMS.Web.Data.Migrations
{
    public partial class addIsReviewedByReviewerToModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsReviewedByReviewer1",
                table: "DMS_UNIT_INFO",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsReviewedByReviewer2",
                table: "DMS_UNIT_INFO",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReviewedByReviewer1",
                table: "DMS_UNIT_INFO");

            migrationBuilder.DropColumn(
                name: "IsReviewedByReviewer2",
                table: "DMS_UNIT_INFO");
        }
    }
}
