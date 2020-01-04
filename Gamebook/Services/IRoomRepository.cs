using Gamebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Model
{
    interface IRoomRepository
    {
        RoomText GetRoom(int Id);
        List<RoomText> GetAllRooms();
    }
}
