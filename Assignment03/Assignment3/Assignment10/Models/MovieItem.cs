using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment10.Models
{
    public class MovieItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public string genre { get; set; }
        public int duration { get; set; }
        public DateTime releaseDate { get; set; }
    }
}
