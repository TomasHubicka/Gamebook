using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Models
{
    public class RoomText
    {
        [Key]
        public int Id { get; set; }
        public string text1 { get; set; }
        public string text2 { get; set; }
    }
}
