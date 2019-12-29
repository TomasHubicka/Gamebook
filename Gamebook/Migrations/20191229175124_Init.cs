﻿using Microsoft.EntityFrameworkCore.Migrations;

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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
                    login = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    achievements = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "roomTexts",
                columns: new[] { "Id", "text1", "text2" },
                values: new object[] { 1, "txt", "ryr" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "achievements", "login", "password" },
                values: new object[] { 1, "0,0,0,0,0,0,0,0,0,0,0,0", "bewb", "pusspuss" });
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
