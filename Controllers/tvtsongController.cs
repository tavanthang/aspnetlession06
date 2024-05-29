using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tvtlession06.Models;

namespace tvtlession06.Controllers
{
    public class tvtsongController : Controller
    {
        private static List<tvtsong> tvtsongs = new List<tvtsong>()
        {
            new tvtsong{Id=221090063,tvtTitle="tạ văn thắng ",tvtAuthor="k22cntt3",tvtArtist="NTU",tvtYearRated=2004},
            new tvtsong{Id=2,tvtTitle="tạ văn thắng ",tvtAuthor="k22cntt3",tvtArtist="NTU",tvtYearRated=2004}
        };
        // GET: tvtsong
        public ActionResult tvtIndex()
        {
            return View(tvtsongs);
        }
        public ActionResult tvtCreate()
        {
            var tvtsong = new tvtsong();
            return View(tvtsong);
        }
    }
}