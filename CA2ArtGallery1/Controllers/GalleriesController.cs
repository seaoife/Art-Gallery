using CA2ArtGallery1.Data;
using CA2ArtGallery1.Models;
using CA2ArtGallery1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA2ArtGallery1.Controllers
{
    public class GalleriesController : Controller
    {
        private readonly IPainting PRepo;
        private readonly IArtist ARepo;
        private readonly IStyle SRepo;
        private readonly IMediumUsed MRepo;
        private readonly IPaintingArtistViewModel VRepo;

        private ApplicationDbContext _DbInstance { get; }

        public GalleriesController(IPainting paint, IArtist artist, IMediumUsed mediumUsed, IStyle style, IPaintingArtistViewModel paintingArtistViewModel, ApplicationDbContext dbInstance)
        {
            _DbInstance = dbInstance;
            PRepo = paint;
            ARepo = artist;
            SRepo = style;
            MRepo = mediumUsed;
            VRepo = paintingArtistViewModel;

        }
        public IActionResult Index()
        {
            //var dbInstance = VRepo.ListPaintingsDetails;// This is a funciton from an interface so no brackets are added at the end. no bodies for anything only names of variables. 
            var artist = new Artist { Id = 1, Blog = "some blog", FirstName = "aoife", SurName = "Carroll" };
            var paitning = new Artist { Id = 1, Blog = "some blog", FirstName = "aoife", SurName = "Carroll" };

            var galleries = new List<PaintingArtistViewModel>
            {
                new PaintingArtistViewModel { Id = 1 , thisArtist=artist, thisPainting=null },
                new PaintingArtistViewModel { Id = 2 , thisArtist=artist, thisPainting=null },
                new PaintingArtistViewModel { Id = 3 , thisArtist=artist, thisPainting=null },
            };
            return View(galleries);
            //return View(dbInstance.ToList());// parse's to a list.   
        }



        public IActionResult Greeting()
        {
            int hour = DateTime.Now.Hour;
            if (hour < 12)
            {
                ViewBag.Message = "Good Morning Art Enthusiast " + hour;

            }
            else if (hour >= 12 && hour < 18)
            {
                ViewBag.Message = "Good Afternoon Art Enthusiast " + hour;
            }
            else
            {
                ViewBag.Message = "Good Evening Art Enthusiast " + hour;

            }

            //the last statement is the else.If statement in  aline.
            return View();
        }

        //ViewBag.Message = hour< 12 ? "Good Morning " : hour> 18 ? "Good Evening " : "Good Afternoon " + "Art Enthusiast" + DateTime.Now.Hour;//




        public IActionResult CurrentT()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Message = "Time = " + hour;

            return View("Gallery");
        }



        //public IActionResult ListPaintingDetails()
        //{
        //    // create an interface IGallery and in the implementation and get the artist whoes painting ID 
        //    // method to let all paintings. it will return an ienumerable 
        //}
    }
}
