using Microsoft.EntityFrameworkCore.Migrations;

namespace DMS.Web.Data.Migrations
{
    public partial class changeunitnumbertolevel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitNumber",
                table: "DMS_UNIT_DESC");

            migrationBuilder.AddColumn<string>(
                name: "UnitLevel",
                table: "DMS_UNIT_DESC",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitLevel",
                table: "DMS_UNIT_DESC");

            migrationBuilder.AddColumn<string>(
                name: "UnitNumber",
                table: "DMS_UNIT_DESC",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
