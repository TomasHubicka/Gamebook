using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamebook.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gamebook.Pages
{
    public class loginModel : PageModel
    {
        public const string SessionKeyId = "_User";
        public ApplicationDBContext _db = new ApplicationDBContext();
        List<User> Users { get; set; }
        public void OnGet()
        {
            Users = _db.users.ToList();
        }
        [BindProperty]
        public User user { get; set; }
        public int Error { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            int y = -1;
            foreach (var x in Users)
            {
                y = y + 1;
                if (user.login == Users[y].login)
                {
                    if(user.password == Users[y].password)
                    {
                        HttpContext.Session.SetInt32(SessionKeyId, y);
                    }
                }
                else
                {

                }
            }

            return RedirectToPage("./Index");
        }
    }
}