using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using grupparbete_mvc.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace grupparbete_mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //var albums = DataManager.GetAlbums();
            var band = DataManager.GetBand();
            //ViewBag.Albums = albums;
            ViewBag.Band = band;
            return View();
        }
    }
}
