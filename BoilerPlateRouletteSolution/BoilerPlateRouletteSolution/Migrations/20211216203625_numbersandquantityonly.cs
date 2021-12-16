using Microsoft.EntityFrameworkCore.Migrations;

namespace BoilerPlateRouletteSolution.Migrations
{
    public partial class numbersandquantityonly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "NumberStats");

            migrationBuilder.DropColumn(
                name: "Percentage",
                table: "NumberStats");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "NumberStats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Percentage",
                table: "NumberStats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
