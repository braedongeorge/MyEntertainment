using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEntertainment.Models
{
    public class UserModel
    {
     
        public int id { get; set; }
        public String userID { get; set; }
        public String tvShows { get; set; }
        public String timeZone { get; set; }
    }
}