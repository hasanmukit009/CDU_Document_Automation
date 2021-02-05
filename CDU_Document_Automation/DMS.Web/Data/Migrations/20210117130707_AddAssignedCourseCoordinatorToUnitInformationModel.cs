using Microsoft.EntityFrameworkCore.Migrations;

namespace DMS.Web.Data.Migrations
{
    public partial class AddAssignedCourseCoordinatorToUnitInformationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssignedCourseCoordinator",
                table: "DMS_UNIT_INFO",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignedCourseCoordinator",
                table: "DMS_UNIT_INFO");
        }
    }
}
