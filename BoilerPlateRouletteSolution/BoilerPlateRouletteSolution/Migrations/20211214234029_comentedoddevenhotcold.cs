using Microsoft.EntityFrameworkCore.Migrations;

namespace BoilerPlateRouletteSolution.Migrations
{
    public partial class comentedoddevenhotcold : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EvenOdd",
                table: "NumberStats");

            migrationBuilder.DropColumn(
                name: "HotCold",
                table: "NumberStats");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EvenOdd",
                table: "NumberStats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HotCold",
                table: "NumberStats",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
