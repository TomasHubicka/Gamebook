using Gamebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Services
{
    public class DataStorage
    {
        private ApplicationDBContext _db;

        public DataStorage(ApplicationDBContext db)
        {
            _db = db;
        }
        public List<RoomText> FetchTexts(ApplicationDBContext x)
        {
            return _db.roomTexts.ToList();
        }
    }
}
