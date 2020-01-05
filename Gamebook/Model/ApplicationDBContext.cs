using Gamebook.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Models
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<RoomTexts> roomTexts { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Achievements> achievements { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(new User { Id = 1, login = "first", password = "first" });
            modelBuilder.Entity<Achievements>().HasData(new Achievements { Id = 1 });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 1, text = "entering house bla bla story", linktext1 = "turn around and leave", linktext2 = "Garage", linktext3="Hallway" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 2, text = "you turn around and leave, fuck you house", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 3, text = "found crowbar, take it?", linktext1 = "yes", linktext2 = "no", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 4, text = "cool crowbar, now hall2", linktext1 = "bedroom", linktext2 = "even more hallway", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 5, text = "bad crowbar, now hall2", linktext1 = "bedroom", linktext2 = "even more hallway", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 6, text = "entering hall, cool af", linktext1 = "kitchen", linktext2 = "more hallway", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 7, text = "entering kitchen uwu", linktext1 = "yes", linktext2 = "no", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 8, text = "taking knife, hall2", linktext1 = "bedroom", linktext2 = "even more hallway", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 9, text = "byebye knife, hall2", linktext1 = "bedroom", linktext2 = "even more hallway", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 10, text = "now entering: hall2", linktext1 = "bedroom", linktext2 = "even more hallway", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 11, text = "entering bedroom, this is a fucky wucky", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 12, text = "going to hall 3", linktext1 = "living room", linktext2 = "Basement", linktext3 = "cool window, check it out" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 13, text = "hello Living room, keep crowbar", linktext1 = "yes", linktext2 = "no", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 14, text = "keep crowbar", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 15, text = "leave crowbar", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 16, text = "entering kitchen uwu", linktext1 = "left", linktext2 = "mid", linktext3 = "right" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 17, text = "straight into basement", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 18, text = "cool window, you looked so close that you fell out and died", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 19, text = "i have a flashlight, but i see a scawy monstew.", linktext1 = "run", linktext2 = "fight", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 20, text = "the crowbar is heavy, can't run, ded", linktext1 = "", linktext2 = "", linktext3 = "" });          
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 21, text = "i'm running, but there's a door, push or pull?", linktext1 = "push", linktext2 = "pull", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 22, text = "i'm pushing as hard as i can, i can't get through and die", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 23, text = "i pulled and it opened, so i ran, closed it behind me and the monster tried to push", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 24, text = "i'm trying to fight the monster, good thing i got this knife. the monster ripped me apart", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 25, text = "i'm trying to fight the monster without a knife. the monster ripped me apart", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 26, text = "i don't have a flashlight and it's dark. i feel a breath on my back. a monster ripped me apart", linktext1 = "", linktext2 = "", linktext3 = "" });
        }
    }
}
