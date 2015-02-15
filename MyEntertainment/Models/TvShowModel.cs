using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEntertainment.Models
{
    public class TvShowModel
    {
        public int id { get; set; }
        public String title { get; set; }
        public int showId { get; set; }
        public byte[] poster { get; set; }
    }
}