using Microsoft.EntityFrameworkCore.Migrations;

namespace DMS.Web.Data.Migrations
{
    public partial class addcurrentpositionUIModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrentPosition",
                table: "DMS_UNIT_INFO",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentPosition",
                table: "DMS_UNIT_INFO");
        }
    }
}
