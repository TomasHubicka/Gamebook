using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamebook.Helpers;
using Gamebook.Models;
using Microsoft.AspNetCore.Http;

namespace Gamebook.Services
{
    public class SessionComms
    {
        public ApplicationDBContext _db = new ApplicationDBContext();
        public const string SessionKeyId = "_User";
        public List<User> Users { get; set; }
        public void UserSet(string login)
        {
            Users = _db.users.ToList();
        }
    }
}
