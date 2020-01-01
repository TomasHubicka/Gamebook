using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gamebook.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "roomTexts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    text1 = table.Column<string>(nullable: true),
                    text2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomTexts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    login = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    achievements = table.Column<string>(nullable: true),
                    sessionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "roomTexts");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
