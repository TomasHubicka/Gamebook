using Microsoft.EntityFrameworkCore.Migrations;

namespace Gamebook.Migrations
{
    public partial class linktext_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "linktext1",
                table: "roomTexts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "linktext2",
                table: "roomTexts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "linktext3",
                table: "roomTexts",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "linktext1", "linktext2", "linktext3" },
                values: new object[] { "left", "mid", "right" });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "linktext1", "linktext2", "linktext3" },
                values: new object[] { "left", "mid", "right" });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "linktext1", "linktext2", "linktext3" },
                values: new object[] { "left", "mid", "right" });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "linktext1", "linktext2", "linktext3" },
                values: new object[] { "left", "mid", "right" });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "linktext1", "linktext2", "linktext3" },
                values: new object[] { "left", "mid", "right" });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "linktext1", "linktext2", "linktext3" },
                values: new object[] { "left", "mid", "right" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "linktext1",
                table: "roomTexts");

            migrationBuilder.DropColumn(
                name: "linktext2",
                table: "roomTexts");

            migrationBuilder.DropColumn(
                name: "linktext3",
                table: "roomTexts");
        }
    }
}
