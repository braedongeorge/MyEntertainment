using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEntertainment.Models
{
    public class CreateViewModel
    {
        public int id { get; set; }
        public String title { get; set; }
        public int showId { get; set; }
        public byte[] poster { get; set; }
        public String posterURL { get; set; } 

    }
}