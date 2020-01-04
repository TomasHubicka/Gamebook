using Gamebook.Model;
using Gamebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Services
{
    public class RoomRepository : IRoomRepository
    {
        ApplicationDBContext _db = new ApplicationDBContext();
        List<RoomText> Rooms { get; set; }

        public List<RoomText> GetAllRooms()
        {
            return Rooms = _db.roomTexts.ToList();
        }

        public RoomText GetRoom(int Id)
        {
            return _db.roomTexts.FirstOrDefault(x => x.Id == Id);
        }

    }
}
