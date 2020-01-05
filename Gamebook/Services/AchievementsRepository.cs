using Gamebook.Model;
using Gamebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Services
{
    public class AchievementsRepository : IAchievementsRepository
    {
        ApplicationDBContext _db = new ApplicationDBContext();
        List<Achievements> achievements { get; set; }

        public List<Achievements> GetAllAchievements()
        {
            return achievements = _db.achievements.ToList();
        }

        public Achievements GetAchievement(int Id)
        {
            return _db.achievements.FirstOrDefault(x => x.Id == Id);
        }

    }
}
