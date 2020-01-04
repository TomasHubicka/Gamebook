using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Models
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<RoomText> roomTexts { get; set; }
        public DbSet<User> users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(new User { Id = 1, login = "bewb", password = "pusspuss" });
            modelBuilder.Entity<RoomText>().HasData(new RoomText { Id = 1, text1 = "one", text2 = "1", linktext1 = "left", linktext2 = "mid", linktext3="right" });
            modelBuilder.Entity<RoomText>().HasData(new RoomText { Id = 2, text1 = "two", text2 = "2", linktext1 = "left", linktext2 = "mid", linktext3 = "right" });
            modelBuilder.Entity<RoomText>().HasData(new RoomText { Id = 3, text1 = "three", text2 = "3", linktext1 = "left", linktext2 = "mid", linktext3 = "right" });
            modelBuilder.Entity<RoomText>().HasData(new RoomText { Id = 4, text1 = "four", text2 = "4", linktext1 = "left", linktext2 = "mid", linktext3 = "right" });
            modelBuilder.Entity<RoomText>().HasData(new RoomText { Id = 5, text1 = "five", text2 = "5", linktext1 = "left", linktext2 = "mid", linktext3 = "right" });
            modelBuilder.Entity<RoomText>().HasData(new RoomText { Id = 6, text1 = "six", text2 = "6", linktext1 = "left", linktext2 = "mid", linktext3 = "right" });
        }
    }
}
