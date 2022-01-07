using Microsoft.EntityFrameworkCore.Migrations;

namespace BoilerPlateRouletteSolution.Migrations
{
    public partial class changedColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "totalNumberCount",
                table: "NumberStats",
                newName: "TotalNumberCount");

            migrationBuilder.RenameColumn(
                name: "oddPercentage",
                table: "NumberStats",
                newName: "OddPercentage");

            migrationBuilder.RenameColumn(
                name: "oddCount",
                table: "NumberStats",
                newName: "OddCount");

            migrationBuilder.RenameColumn(
                name: "evenPercentage",
                table: "NumberStats",
                newName: "EvenPercentage");

            migrationBuilder.RenameColumn(
                name: "evenCount",
                table: "NumberStats",
                newName: "EvenCount");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalNumberCount",
                table: "NumberStats",
                newName: "totalNumberCount");

            migrationBuilder.RenameColumn(
                name: "OddPercentage",
                table: "NumberStats",
                newName: "oddPercentage");

            migrationBuilder.RenameColumn(
                name: "OddCount",
                table: "NumberStats",
                newName: "oddCount");

            migrationBuilder.RenameColumn(
                name: "EvenPercentage",
                table: "NumberStats",
                newName: "evenPercentage");

            migrationBuilder.RenameColumn(
                name: "EvenCount",
                table: "NumberStats",
                newName: "evenCount");
        }
    }
}
