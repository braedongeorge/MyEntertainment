using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEntertainment.Models
{
    public class TVIndexViewModel
    {
        public TVIndexViewModel()
        {

            TvShowModels = new List<TvShowModel>();
        }
        public List<TvShowModel> TvShowModels { get; set; }
    }
}