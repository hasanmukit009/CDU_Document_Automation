using Microsoft.EntityFrameworkCore.Migrations;

namespace DMS.Web.Data.Migrations
{
    public partial class addCheckBoxTOModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsChangeToCoreUnitDescriptionContentChecked",
                table: "DMS_UNIT_DESC",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsGrammarOrFormattingAmendmentChecked",
                table: "DMS_UNIT_DESC",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsProvidingSpecificEnrolmentInformationChecked",
                table: "DMS_UNIT_DESC",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsChangeToCoreUnitDescriptionContentChecked",
                table: "DMS_UNIT_DESC");

            migrationBuilder.DropColumn(
                name: "IsGrammarOrFormattingAmendmentChecked",
                table: "DMS_UNIT_DESC");

            migrationBuilder.DropColumn(
                name: "IsProvidingSpecificEnrolmentInformationChecked",
                table: "DMS_UNIT_DESC");
        }
    }
}
