using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyEntertainment.Models
{
    public class myEntertainmentDb : DbContext
    {
        public myEntertainmentDb() : base("name=myConnection")
        {

        }
        public DbSet<TvShowModel> TvShowModels { get; set; }
        public DbSet<UserModel> UserTvShowModels { get; set; }
    }
}