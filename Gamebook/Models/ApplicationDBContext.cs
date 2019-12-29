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
            => options.UseSqlite(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(new User { Id = 1, login = "bewb", password = "pusspuss", achievements = "0,0,0,0,0,0,0,0,0,0,0,0" });
            modelBuilder.Entity<RoomText>().HasData(new RoomText { Id = 1, text1 = "txt", text2 = "ryr" });
        }
    }
}
