using Microsoft.EntityFrameworkCore.Migrations;

namespace Gamebook.Migrations
{
    public partial class finishedtexts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "linktext1", "text" },
                values: new object[] { "Outside", "You enter the presumably haunted house, looking for any clues of the incident that happened a year ago. As you look around you see that there are exactly 3 doors, one leads to the outside, one leads to a Garage and one leads to a Hallway. Which one do you choose?" });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 2,
                column: "text",
                value: "You go outside, decide that it isn't worth the risk of a monster or something and leave.");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "linktext1", "linktext2", "text" },
                values: new object[] { "Yes", "No", "You entered the garage and as you look around, you find a crowbar, thinking that it might be useful. Would you like to take it?" });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "linktext2", "text" },
                values: new object[] { "continue down the hallway", "You take the crowbar and exit through another door in the garage. You enter the Hallway. In the darkness, you hear someone sing behind a door to a bedroom. Where would you like to go?" });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 5,
                column: "text",
                value: "You decide to leave the crowbar there and exit through another door in the garage. You enter the Hallway. In the darkness, you hear someone sing behind a door to a bedroom. Where would you like to go?");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "linktext2", "text" },
                values: new object[] { "continue down the hallway hallway", "You enter the hallway. You see a door to a kitchen. Would you like to go in there, or continue down the hallway" });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 7,
                column: "text",
                value: "As you enter the kitchen, you notice a knife stuck in the wall. Would you like to take it?");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "linktext2", "text" },
                values: new object[] { "continue down the hallway", "You pull the knife out of the wall, and take it with you on an adventure to the hallway. You hear someone sing behind a door to a bedroom. Would you like to check it out or do you continue down the hallway?" });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "linktext2", "text" },
                values: new object[] { "continue down the hallway", "You leave the knife be and go to the hallway. You hear someone sing behind a door to a bedroom. Would you like to check it out or do you continue down the hallway?" });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "linktext2", "text" },
                values: new object[] { "continue down the hallway", "You enter a hallway. You hear someone sing behind a door to a bedroom. Do you want to see who's singing, or do you want to continue down the hallway" });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 11,
                column: "text",
                value: "You decide to enter the hallway. You immediatelly realise how big of a mistake that was. The song from a little girl standing in the middle of the room immediatelly stops and she looks straight at you with her black eyes. You pass out and never wake up again.");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 12,
                column: "text",
                value: "Ignoring the singing, you continue down the hallway only to find 3 things. a living room that's boarded up, probably accesible with a crowbar, stairs to the basement and a very cool open window that you feel extreme urge to check out. Which one do you choose?");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 13,
                column: "text",
                value: "You feel happy that you grabbed that crowbar, get in there and find a flashlight. Such an awesome source of light! Would you like to keep your crowbar?");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 14,
                column: "text",
                value: "You decide to keep your crowbar and continue down the stairs into the basement.");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 15,
                column: "text",
                value: "You decide to leave your crowbar there and continue down the stairs into the basement.");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "linktext1", "linktext2", "linktext3", "text" },
                values: new object[] { "", "", "", "You try to open the door to the living room, but you can't. If only you had that crowbar now. The only way to go is now to the basement." });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 17,
                column: "text",
                value: "Down to the basement you go!");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 18,
                column: "text",
                value: "You look out of the cool window. You looked so close that you fell out and died.");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 19,
                column: "text",
                value: "As you enter the basement, you suddenly see a not very friendly looking monster coming your way. Do you run or fight?");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 20,
                column: "text",
                value: "You decide to run, but the crowbar is so heavy that the monster catches up and rips you apart.");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 21,
                column: "text",
                value: "You're running as fast as you can and now there's a door. Will you push or pull?");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 22,
                column: "text",
                value: "You tried pushing, it didn't work and you don't have the time to try pulling now. The monster catched up to you and you died horribly.");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 23,
                column: "text",
                value: "You pulled and it opened, so you closed it behind you and ran. The monster didn't know how doors work and you got away. ");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 24,
                column: "text",
                value: "You decide that the knife you got is a really good weapon against a deadly monster. It wasn't and you died.");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 25,
                column: "text",
                value: "You suddenly feel like you can defeat the monster without any weapons. You try it and fail horribly. You died.");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 26,
                column: "text",
                value: "You don't have a flashlight and it's dark. You feel a breath on your back. A monster ripped you apart.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "linktext1", "text" },
                values: new object[] { "turn around and leave", "entering house bla bla story" });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 2,
                column: "text",
                value: "you turn around and leave, fuck you house");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "linktext1", "linktext2", "text" },
                values: new object[] { "yes", "no", "found crowbar, take it?" });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "linktext2", "text" },
                values: new object[] { "even more hallway", "cool crowbar, now hall2" });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 5,
                column: "text",
                value: "bad crowbar, now hall2");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "linktext2", "text" },
                values: new object[] { "more hallway", "entering hall, cool af" });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 7,
                column: "text",
                value: "entering kitchen uwu");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "linktext2", "text" },
                values: new object[] { "even more hallway", "taking knife, hall2" });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "linktext2", "text" },
                values: new object[] { "even more hallway", "byebye knife, hall2" });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "linktext2", "text" },
                values: new object[] { "even more hallway", "now entering: hall2" });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 11,
                column: "text",
                value: "entering bedroom, this is a fucky wucky");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 12,
                column: "text",
                value: "going to hall 3");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 13,
                column: "text",
                value: "hello Living room, keep crowbar");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 14,
                column: "text",
                value: "keep crowbar");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 15,
                column: "text",
                value: "leave crowbar");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "linktext1", "linktext2", "linktext3", "text" },
                values: new object[] { "left", "mid", "right", "entering kitchen uwu" });

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 17,
                column: "text",
                value: "straight into basement");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 18,
                column: "text",
                value: "cool window, you looked so close that you fell out and died");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 19,
                column: "text",
                value: "i have a flashlight, but i see a scawy monstew.");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 20,
                column: "text",
                value: "the crowbar is heavy, can't run, ded");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 21,
                column: "text",
                value: "i'm running, but there's a door, push or pull?");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 22,
                column: "text",
                value: "i'm pushing as hard as i can, i can't get through and die");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 23,
                column: "text",
                value: "i pulled and it opened, so i ran, closed it behind me and the monster tried to push");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 24,
                column: "text",
                value: "i'm trying to fight the monster, good thing i got this knife. the monster ripped me apart");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 25,
                column: "text",
                value: "i'm trying to fight the monster without a knife. the monster ripped me apart");

            migrationBuilder.UpdateData(
                table: "roomTexts",
                keyColumn: "Id",
                keyValue: 26,
                column: "text",
                value: "i don't have a flashlight and it's dark. i feel a breath on my back. a monster ripped me apart");
        }
    }
}
