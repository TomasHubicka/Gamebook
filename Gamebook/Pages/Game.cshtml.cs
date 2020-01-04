using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamebook.Models;
using Gamebook.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Gamebook.Pages
{
    public class GameModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        SessionStorage<User> _ss;
        UserRepository _ur = new UserRepository();
        RoomRepository _rr = new RoomRepository();
        public int room { get; set; } = 0;
        public List<RoomText> roomTexts { get; set; }
        public List<User> Users = new List<User>();
        public User CurrentUser { get; set; }
        public GameModel(ILogger<IndexModel> logger, SessionStorage<User> ss)
        {
            _logger = logger;
            _ss = ss;
        }
        public void OnGet()
        {
            CurrentUser = _ss.LoadOrCreate("_User");
            roomTexts = _rr.GetAllRooms();
        }
        public void OnGetOne()
        {
            CurrentUser = _ss.LoadOrCreate("_User");
            roomTexts = _rr.GetAllRooms();
        }
        public void OnGetTwo()
        {
            CurrentUser = _ss.LoadOrCreate("_User");
            roomTexts = _rr.GetAllRooms();
        }
        public void OnGetThree()
        {
            CurrentUser = _ss.LoadOrCreate("_User");
            roomTexts = _rr.GetAllRooms();
        }
    }
}