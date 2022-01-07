using Microsoft.EntityFrameworkCore.Migrations;

namespace BoilerPlateRouletteSolution.Migrations
{
    public partial class addedOddEvenTotalcolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "evenCount",
                table: "NumberStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "oddCount",
                table: "NumberStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "totalNumberCount",
                table: "NumberStats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "evenCount",
                table: "NumberStats");

            migrationBuilder.DropColumn(
                name: "oddCount",
                table: "NumberStats");

            migrationBuilder.DropColumn(
                name: "totalNumberCount",
                table: "NumberStats");
        }
    }
}
