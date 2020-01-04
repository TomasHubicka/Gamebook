using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Model
{
    public class Achievements
    {
        [Key]
        public int Id { get; set; }
        public bool win { get; set; }
        public bool lose1 { get; set; }
        public bool lose2 { get; set; }
        public bool lose3 { get; set; }
        public bool lose4 { get; set; }
        public bool lose5 { get; set; }
        public bool lose6 { get; set; }
        public bool lose7 { get; set; }
        public bool lose8 { get; set; }
        public bool lose9 { get; set; }
    }
}
