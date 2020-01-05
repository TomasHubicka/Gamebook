using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gamebook.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "achievements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                });

            migrationBuilder.CreateTable(
                name: "roomTexts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    text = table.Column<string>(nullable: true),
                    linktext1 = table.Column<string>(nullable: true),
                    linktext2 = table.Column<string>(nullable: true),
                    linktext3 = table.Column<string>(nullable: true)
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
                    login = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: false),
                    sessionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "achievements",
                columns: new[] { "Id", "lose1", "lose2", "lose3", "lose4", "lose5", "lose6", "lose7", "lose8", "lose9", "win" },
                values: new object[] { 1, false, false, false, false, false, false, false, false, false, false });

            migrationBuilder.InsertData(
                table: "roomTexts",
                columns: new[] { "Id", "linktext1", "linktext2", "linktext3", "text" },
                values: new object[,]
                {
                    { 25, "", "", "", "i'm trying to fight the monster without a knife. the monster ripped me apart" },
                    { 24, "", "", "", "i'm trying to fight the monster, good thing i got this knife. the monster ripped me apart" },
                    { 23, "", "", "", "i pulled and it opened, so i ran, closed it behind me and the monster tried to push" },
                    { 22, "", "", "", "i'm pushing as hard as i can, i can't get through and die" },
                    { 21, "push", "pull", "", "i'm running, but there's a door, push or pull?" },
                    { 20, "", "", "", "the crowbar is heavy, can't run, ded" },
                    { 19, "run", "fight", "", "i have a flashlight, but i see a scawy monstew." },
                    { 18, "", "", "", "cool window, you looked so close that you fell out and died" },
                    { 17, "", "", "", "straight into basement" },
                    { 16, "left", "mid", "right", "entering kitchen uwu" },
                    { 15, "", "", "", "leave crowbar" },
                    { 14, "", "", "", "keep crowbar" },
                    { 13, "yes", "no", "", "hello Living room, keep crowbar" },
                    { 12, "living room", "Basement", "cool window, check it out", "going to hall 3" },
                    { 11, "", "", "", "entering bedroom, this is a fucky wucky" },
                    { 10, "bedroom", "even more hallway", "", "now entering: hall2" },
                    { 9, "bedroom", "even more hallway", "", "byebye knife, hall2" },
                    { 8, "bedroom", "even more hallway", "", "taking knife, hall2" },
                    { 7, "yes", "no", "", "entering kitchen uwu" },
                    { 6, "kitchen", "more hallway", "", "entering hall, cool af" },
                    { 5, "bedroom", "even more hallway", "", "bad crowbar, now hall2" },
                    { 4, "bedroom", "even more hallway", "", "cool crowbar, now hall2" },
                    { 3, "yes", "no", "", "found crowbar, take it?" },
                    { 2, "", "", "", "you turn around and leave, fuck you house" },
                    { 1, "turn around and leave", "Garage", "Hallway", "entering house bla bla story" },
                    { 26, "", "", "", "i don't have a flashlight and it's dark. i feel a breath on my back. a monster ripped me apart" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "login", "password", "sessionId" },
                values: new object[] { 1, "first", "first", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "achievements");

            migrationBuilder.DropTable(
                name: "roomTexts");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
