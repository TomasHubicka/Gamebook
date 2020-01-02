using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamebook.Models;
using Gamebook.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gamebook.Pages
{
    public class IndexModel : PageModel
    {
        public const string SessionKeyId = "_User";
        public ApplicationDBContext _db = new ApplicationDBContext();
        public int room { get; set; } = 0;
        public List<RoomText> roomTexts { get; set; }
        public List<User> Users = new List<User>();
        public int UserId { get; set; }
        public void OnGet()
        {

            var userId = HttpContext.Session.GetInt32(SessionKeyId);
            Users = _db.users.ToList();
            roomTexts = _db.roomTexts.ToList();
        }
        public async Task<IActionResult> OnGetOne()
        {
            Users = _db.users.ToList();
            roomTexts = _db.roomTexts.ToList();
            room = 1;
            return null;
        }
        public async Task<IActionResult> OnGetTwo()
        {
            Users = _db.users.ToList();
            roomTexts = _db.roomTexts.ToList();
            room = 2;
            return null;
        }
    }
}
