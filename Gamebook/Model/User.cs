using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string achievements { get; set; }
        public int sessionId { get; set; }
    }
}
