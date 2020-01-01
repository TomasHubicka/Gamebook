using Microsoft.EntityFrameworkCore.Migrations;

namespace Gamebook.Migrations
{
    public partial class idk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "roomTexts",
                columns: new[] { "Id", "text1", "text2" },
                values: new object[,]
                {
                    { 1, "one", "1" },
                    { 2, "two", "2" },
                    { 3, "three", "3" },
                    { 4, "four", "4" },
                    { 5, "five", "5" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "achievements", "login", "password", "sessionId" },
                values: new object[] { 1, "0,0,0,0,0,0,0,0,0,0,0,0", "bewb", "pusspuss", 0 });
        }
    }
}
