using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamebook.Models;
using Gamebook.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gamebook.Pages
{
    public class loginModel : PageModel
    {
        public const string SessionKeyId = "_User";
        public ApplicationDBContext _db = new ApplicationDBContext();
        List<User> Users = new List<User>();

        public void OnGet()
        {
                Users = _db.users.ToList();
        }
        [BindProperty]
        public User user { get; set; }
        public int Error { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            Users = _db.users.ToList();
            int UserAmount = Users.Count;
            if (!ModelState.IsValid)
            {
                return Page();
            }
            foreach (var x in Users)
            {              
                if (user.login.ToString() == Users[UserAmount-1].login.ToString())
                {
                    if(user.password.ToString() == Users[UserAmount-1].password.ToString())
                    {
                        HttpContext.Session.SetInt32(SessionKeyId, UserAmount-1);
                        return RedirectToPage("./Index");
                    }
                }
                else
                {
                    Error = 1;
                }
                UserAmount--;
            }
            return null;
        }
    }
}