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
        public int room = 0;
        public List<RoomText> roomTexts { get; set; }
        public void OnGet()
        {
            roomTexts = _db.roomTexts.ToList();
        }
        public void OnPostOne()
        {
            room = 1;
        }
        public void OnPostTwo()
        {
            room = 2;
        }
    }
}
