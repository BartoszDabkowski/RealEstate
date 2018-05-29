using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstate.Migrations
{
    public partial class ChangeHouseDecimalPlaces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Houses",
                type: "decimal(9, 6)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Houses",
                type: "decimal(9, 6)",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Houses",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9, 6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Houses",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9, 6)");
        }
    }
}
