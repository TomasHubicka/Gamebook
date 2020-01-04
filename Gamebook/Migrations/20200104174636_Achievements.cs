using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gamebook.Migrations
{
    public partial class Achievements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "achievements",
                table: "users");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "login",
                table: "users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "achievements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    win = table.Column<bool>(nullable: false),
                    lose1 = table.Column<bool>(nullable: false),
                    lose2 = table.Column<bool>(nullable: false),
                    lose3 = table.Column<bool>(nullable: false),
                    lose4 = table.Column<bool>(nullable: false),
                    lose5 = table.Column<bool>(nullable: false),
                    lose6 = table.Column<bool>(nullable: false),
                    lose7 = table.Column<bool>(nullable: false),
                    lose8 = table.Column<bool>(nullable: false),
                    lose9 = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_achievements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_achievements_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "achievements",
                columns: new[] { "Id", "UserId", "lose1", "lose2", "lose3", "lose4", "lose5", "lose6", "lose7", "lose8", "lose9", "win" },
                values: new object[] { 1, 1, false, false, false, false, false, false, false, false, false, false });

            migrationBuilder.CreateIndex(
                name: "IX_achievements_UserId",
                table: "achievements",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "achievements");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "users",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "login",
                table: "users",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "achievements",
                table: "users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "achievements",
                value: "0,0,0,0,0,0,0,0,0,0,0,0");
        }
    }
}
