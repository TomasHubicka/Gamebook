using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamebook.Models;
using Gamebook.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gamebook.Pages
{
    public class IndexModel : PageModel
    {

        public ApplicationDBContext _db = new ApplicationDBContext();
        public int room { get; set; } = 0;
        public List<RoomText> roomTexts { get; set; }
        public void OnGet()
        {
            roomTexts = _db.roomTexts.ToList();
        }
        public Task<IActionResult> OnPostOne()
        {
            roomTexts = _db.roomTexts.ToList();
            room = 1;
            return null;
        }
        public Task<IActionResult> OnPostTwo()
        {
            roomTexts = _db.roomTexts.ToList();
            room = 2;
            return null;
        }
    }
}
