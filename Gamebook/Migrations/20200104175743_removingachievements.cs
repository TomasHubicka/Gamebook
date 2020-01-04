using Microsoft.EntityFrameworkCore.Migrations;

namespace Gamebook.Migrations
{
    public partial class removingachievements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_achievements_users_UserId",
                table: "achievements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_achievements",
                table: "achievements");

            migrationBuilder.DropIndex(
                name: "IX_achievements_UserId",
                table: "achievements");

            migrationBuilder.DeleteData(
                table: "achievements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "achievements");

            migrationBuilder.RenameTable(
                name: "achievements",
                newName: "Achievements");

            migrationBuilder.AddColumn<int>(
                name: "achievementsId",
                table: "users",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Achievements",
                table: "Achievements",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_users_achievementsId",
                table: "users",
                column: "achievementsId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_Achievements_achievementsId",
                table: "users",
                column: "achievementsId",
                principalTable: "Achievements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_Achievements_achievementsId",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_achievementsId",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Achievements",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "achievementsId",
                table: "users");

            migrationBuilder.RenameTable(
                name: "Achievements",
                newName: "achievements");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "achievements",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_achievements",
                table: "achievements",
                column: "Id");

            migrationBuilder.InsertData(
                table: "achievements",
                columns: new[] { "Id", "UserId", "lose1", "lose2", "lose3", "lose4", "lose5", "lose6", "lose7", "lose8", "lose9", "win" },
                values: new object[] { 1, 1, false, false, false, false, false, false, false, false, false, false });

            migrationBuilder.CreateIndex(
                name: "IX_achievements_UserId",
                table: "achievements",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_achievements_users_UserId",
                table: "achievements",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
