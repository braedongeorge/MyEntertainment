using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEntertainment.Models
{
    public class TVShowViewModels
    {
        public TVShowViewModels()
        {

            TvShowModels = new List<TVShowIndexViewModel>();
        }
        public List<TVShowIndexViewModel> TvShowModels { get; set; }
    }

    public class TvShowModel
    {

        public int id { get; set; }

        [Display(Name = "Name")]
        public String title { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int showId { get; set; }
        public byte[] poster { get; set; }
    }

    public class TVShowIndexViewModel
    {
        public int id { get; set; }

        [Display(Name = "Name")]
        public String title { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int showId { get; set; }

    }

    public class CreateViewModel
    {
        public int id { get; set; }
        public String title { get; set; }
        public int showId { get; set; }
        public byte[] poster { get; set; }
        public String posterURL { get; set; }

    }
}