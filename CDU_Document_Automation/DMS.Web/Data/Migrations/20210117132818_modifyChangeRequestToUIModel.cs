using Microsoft.EntityFrameworkCore.Migrations;

namespace DMS.Web.Data.Migrations
{
    public partial class modifyChangeRequestToUIModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChangeReuqest",
                table: "DMS_UNIT_INFO");

            migrationBuilder.AddColumn<string>(
                name: "ChangeRequest",
                table: "DMS_UNIT_INFO",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChangeRequest",
                table: "DMS_UNIT_INFO");

            migrationBuilder.AddColumn<string>(
                name: "ChangeReuqest",
                table: "DMS_UNIT_INFO",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
