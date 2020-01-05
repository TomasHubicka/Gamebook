using Microsoft.EntityFrameworkCore.Migrations;

namespace Gamebook.Migrations
{
    public partial class changedachievements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lose9",
                table: "achievements",
                newName: "TurnAround");

            migrationBuilder.RenameColumn(
                name: "lose8",
                table: "achievements",
                newName: "PushingNeverWorks");

            migrationBuilder.RenameColumn(
                name: "lose7",
                table: "achievements",
                newName: "KungFuFight");

            migrationBuilder.RenameColumn(
                name: "lose6",
                table: "achievements",
                newName: "KnifeFight");

            migrationBuilder.RenameColumn(
                name: "lose5",
                table: "achievements",
                newName: "ItsDark");

            migrationBuilder.RenameColumn(
                name: "lose4",
                table: "achievements",
                newName: "FallOut");

            migrationBuilder.RenameColumn(
                name: "lose3",
                table: "achievements",
                newName: "DoNothingAndDie");

            migrationBuilder.RenameColumn(
                name: "lose2",
                table: "achievements",
                newName: "CrowbarsAreHeavy");

            migrationBuilder.RenameColumn(
                name: "lose1",
                table: "achievements",
                newName: "BedroomAdventure");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TurnAround",
                table: "achievements",
                newName: "lose9");

            migrationBuilder.RenameColumn(
                name: "PushingNeverWorks",
                table: "achievements",
                newName: "lose8");

            migrationBuilder.RenameColumn(
                name: "KungFuFight",
                table: "achievements",
                newName: "lose7");

            migrationBuilder.RenameColumn(
                name: "KnifeFight",
                table: "achievements",
                newName: "lose6");

            migrationBuilder.RenameColumn(
                name: "ItsDark",
                table: "achievements",
                newName: "lose5");

            migrationBuilder.RenameColumn(
                name: "FallOut",
                table: "achievements",
                newName: "lose4");

            migrationBuilder.RenameColumn(
                name: "DoNothingAndDie",
                table: "achievements",
                newName: "lose3");

            migrationBuilder.RenameColumn(
                name: "CrowbarsAreHeavy",
                table: "achievements",
                newName: "lose2");

            migrationBuilder.RenameColumn(
                name: "BedroomAdventure",
                table: "achievements",
                newName: "lose1");
        }
    }
}
