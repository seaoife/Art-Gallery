using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CA2ArtGallery1.Models;
using CA2ArtGallery1.Data;

namespace CA2ArtGallery1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStyle SRepo;

        private ApplicationDbContext _DbInstance { get; }
        public HomeController(ILogger<HomeController> logger, IStyle style, ApplicationDbContext dbInstance)
        {
            _logger = logger;
            _DbInstance = dbInstance;
            SRepo = style;
        }

        public IActionResult Index()
        {
            var styles = SRepo.AllStyles;
            return View(styles);
        }

        public IActionResult Privacy()
        {
            return View();

        }
        //public IActionResult Gallery()
        //{

        //    int hour = DateTime.Now.Hour;
        //    ViewBag.Message = hour < 12 ? "Hi There Art Enthusiast" : "Hi There Afternoon Art Enthusiast";

        //    return View();

        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

