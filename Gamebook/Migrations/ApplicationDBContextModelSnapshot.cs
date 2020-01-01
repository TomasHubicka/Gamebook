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
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gamebook.Models.RoomText", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("linktext1");

                    b.Property<string>("linktext2");

                    b.Property<string>("linktext3");

                    b.Property<string>("text1");

                    b.Property<string>("text2");

                    b.HasKey("Id");

                    b.ToTable("roomTexts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            linktext1 = "left",
                            linktext2 = "mid",
                            linktext3 = "right",
                            text1 = "one",
                            text2 = "1"
                        },
                        new
                        {
                            Id = 2,
                            linktext1 = "left",
                            linktext2 = "mid",
                            linktext3 = "right",
                            text1 = "two",
                            text2 = "2"
                        },
                        new
                        {
                            Id = 3,
                            linktext1 = "left",
                            linktext2 = "mid",
                            linktext3 = "right",
                            text1 = "three",
                            text2 = "3"
                        },
                        new
                        {
                            Id = 4,
                            linktext1 = "left",
                            linktext2 = "mid",
                            linktext3 = "right",
                            text1 = "four",
                            text2 = "4"
                        },
                        new
                        {
                            Id = 5,
                            linktext1 = "left",
                            linktext2 = "mid",
                            linktext3 = "right",
                            text1 = "five",
                            text2 = "5"
                        },
                        new
                        {
                            Id = 6,
                            linktext1 = "left",
                            linktext2 = "mid",
                            linktext3 = "right",
                            text1 = "six",
                            text2 = "6"
                        });
                });

            modelBuilder.Entity("Gamebook.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("achievements");

                    b.Property<string>("login");

                    b.Property<string>("password");

                    b.Property<int>("sessionId");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            achievements = "0,0,0,0,0,0,0,0,0,0,0,0",
                            login = "bewb",
                            password = "pusspuss",
                            sessionId = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
