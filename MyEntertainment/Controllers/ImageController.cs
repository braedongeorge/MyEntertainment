using MyEntertainment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEntertainment.Controllers
{
    public class ImagesController : Controller
    {
        myEntertainmentDb db = new myEntertainmentDb();

        public ActionResult Index(int id)
        {
            TvShowModel newModel = new TvShowModel();
            newModel = db.TvShowModels.SingleOrDefault(tvshow => tvshow.showId == id);
            return File(newModel.poster, "image/jpeg"); 
        }
    }
}