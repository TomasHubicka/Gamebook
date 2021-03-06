﻿// <auto-generated />
using Gamebook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gamebook.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gamebook.Model.Achievements", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BedroomAdventure");

                    b.Property<bool>("CrowbarsAreHeavy");

                    b.Property<bool>("DoNothingAndDie");

                    b.Property<bool>("FallOut");

                    b.Property<bool>("ItsDark");

                    b.Property<bool>("KnifeFight");

                    b.Property<bool>("KungFuFight");

                    b.Property<bool>("PushingNeverWorks");

                    b.Property<bool>("TurnAround");

                    b.Property<int>("UserId");

                    b.Property<bool>("win");

                    b.HasKey("Id");

                    b.ToTable("achievements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BedroomAdventure = false,
                            CrowbarsAreHeavy = false,
                            DoNothingAndDie = false,
                            FallOut = false,
                            ItsDark = false,
                            KnifeFight = false,
                            KungFuFight = false,
                            PushingNeverWorks = false,
                            TurnAround = false,
                            UserId = 0,
                            win = false
                        });
                });

            modelBuilder.Entity("Gamebook.Models.RoomTexts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("linktext1");

                    b.Property<string>("linktext2");

                    b.Property<string>("linktext3");

                    b.Property<string>("text");

                    b.HasKey("Id");

                    b.ToTable("roomTexts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            linktext1 = "Outside",
                            linktext2 = "Garage",
                            linktext3 = "Hallway",
                            text = "You enter the presumably haunted house, looking for any clues of the incident that happened a year ago. As you look around you see that there are exactly 3 doors, one leads to the outside, one leads to a Garage and one leads to a Hallway. Which one do you choose?"
                        },
                        new
                        {
                            Id = 2,
                            linktext1 = "",
                            linktext2 = "",
                            linktext3 = "",
                            text = "You go outside, decide that it isn't worth the risk of a monster or something and leave."
                        },
                        new
                        {
                            Id = 3,
                            linktext1 = "Yes",
                            linktext2 = "No",
                            linktext3 = "",
                            text = "You entered the garage and as you look around, you find a crowbar, thinking that it might be useful. Would you like to take it?"
                        },
                        new
                        {
                            Id = 4,
                            linktext1 = "bedroom",
                            linktext2 = "continue down the hallway",
                            linktext3 = "",
                            text = "You take the crowbar and exit through another door in the garage. You enter the Hallway. In the darkness, you hear someone sing behind a door to a bedroom. Where would you like to go?"
                        },
                        new
                        {
                            Id = 5,
                            linktext1 = "bedroom",
                            linktext2 = "even more hallway",
                            linktext3 = "",
                            text = "You decide to leave the crowbar there and exit through another door in the garage. You enter the Hallway. In the darkness, you hear someone sing behind a door to a bedroom. Where would you like to go?"
                        },
                        new
                        {
                            Id = 6,
                            linktext1 = "kitchen",
                            linktext2 = "continue down the hallway hallway",
                            linktext3 = "",
                            text = "You enter the hallway. You see a door to a kitchen. Would you like to go in there, or continue down the hallway"
                        },
                        new
                        {
                            Id = 7,
                            linktext1 = "yes",
                            linktext2 = "no",
                            linktext3 = "",
                            text = "As you enter the kitchen, you notice a knife stuck in the wall. Would you like to take it?"
                        },
                        new
                        {
                            Id = 8,
                            linktext1 = "bedroom",
                            linktext2 = "continue down the hallway",
                            linktext3 = "",
                            text = "You pull the knife out of the wall, and take it with you on an adventure to the hallway. You hear someone sing behind a door to a bedroom. Would you like to check it out or do you continue down the hallway?"
                        },
                        new
                        {
                            Id = 9,
                            linktext1 = "bedroom",
                            linktext2 = "continue down the hallway",
                            linktext3 = "",
                            text = "You leave the knife be and go to the hallway. You hear someone sing behind a door to a bedroom. Would you like to check it out or do you continue down the hallway?"
                        },
                        new
                        {
                            Id = 10,
                            linktext1 = "bedroom",
                            linktext2 = "continue down the hallway",
                            linktext3 = "",
                            text = "You enter a hallway. You hear someone sing behind a door to a bedroom. Do you want to see who's singing, or do you want to continue down the hallway"
                        },
                        new
                        {
                            Id = 11,
                            linktext1 = "",
                            linktext2 = "",
                            linktext3 = "",
                            text = "You decide to enter the hallway. You immediatelly realise how big of a mistake that was. The song from a little girl standing in the middle of the room immediatelly stops and she looks straight at you with her black eyes. You pass out and never wake up again."
                        },
                        new
                        {
                            Id = 12,
                            linktext1 = "living room",
                            linktext2 = "Basement",
                            linktext3 = "cool window, check it out",
                            text = "Ignoring the singing, you continue down the hallway only to find 3 things. a living room that's boarded up, probably accesible with a crowbar, stairs to the basement and a very cool open window that you feel extreme urge to check out. Which one do you choose?"
                        },
                        new
                        {
                            Id = 13,
                            linktext1 = "yes",
                            linktext2 = "no",
                            linktext3 = "",
                            text = "You feel happy that you grabbed that crowbar, get in there and find a flashlight. Such an awesome source of light! Would you like to keep your crowbar?"
                        },
                        new
                        {
                            Id = 14,
                            linktext1 = "",
                            linktext2 = "",
                            linktext3 = "",
                            text = "You decide to keep your crowbar and continue down the stairs into the basement."
                        },
                        new
                        {
                            Id = 15,
                            linktext1 = "",
                            linktext2 = "",
                            linktext3 = "",
                            text = "You decide to leave your crowbar there and continue down the stairs into the basement."
                        },
                        new
                        {
                            Id = 16,
                            linktext1 = "",
                            linktext2 = "",
                            linktext3 = "",
                            text = "You try to open the door to the living room, but you can't. If only you had that crowbar now. The only way to go is now to the basement."
                        },
                        new
                        {
                            Id = 17,
                            linktext1 = "",
                            linktext2 = "",
                            linktext3 = "",
                            text = "Down to the basement you go!"
                        },
                        new
                        {
                            Id = 18,
                            linktext1 = "",
                            linktext2 = "",
                            linktext3 = "",
                            text = "You look out of the cool window. You looked so close that you fell out and died."
                        },
                        new
                        {
                            Id = 19,
                            linktext1 = "run",
                            linktext2 = "fight",
                            linktext3 = "",
                            text = "As you enter the basement, you suddenly see a not very friendly looking monster coming your way. Do you run or fight?"
                        },
                        new
                        {
                            Id = 20,
                            linktext1 = "",
                            linktext2 = "",
                            linktext3 = "",
                            text = "You decide to run, but the crowbar is so heavy that the monster catches up and rips you apart."
                        },
                        new
                        {
                            Id = 21,
                            linktext1 = "push",
                            linktext2 = "pull",
                            linktext3 = "",
                            text = "You're running as fast as you can and now there's a door. Will you push or pull?"
                        },
                        new
                        {
                            Id = 22,
                            linktext1 = "",
                            linktext2 = "",
                            linktext3 = "",
                            text = "You tried pushing, it didn't work and you don't have the time to try pulling now. The monster catched up to you and you died horribly."
                        },
                        new
                        {
                            Id = 23,
                            linktext1 = "",
                            linktext2 = "",
                            linktext3 = "",
                            text = "You pulled and it opened, so you closed it behind you and ran. The monster didn't know how doors work and you got away. "
                        },
                        new
                        {
                            Id = 24,
                            linktext1 = "",
                            linktext2 = "",
                            linktext3 = "",
                            text = "You decide that the knife you got is a really good weapon against a deadly monster. It wasn't and you died."
                        },
                        new
                        {
                            Id = 25,
                            linktext1 = "",
                            linktext2 = "",
                            linktext3 = "",
                            text = "You suddenly feel like you can defeat the monster without any weapons. You try it and fail horribly. You died."
                        },
                        new
                        {
                            Id = 26,
                            linktext1 = "",
                            linktext2 = "",
                            linktext3 = "",
                            text = "You don't have a flashlight and it's dark. You feel a breath on your back. A monster ripped you apart."
                        });
                });

            modelBuilder.Entity("Gamebook.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("login")
                        .IsRequired();

                    b.Property<string>("password")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            login = "first",
                            password = "first"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
