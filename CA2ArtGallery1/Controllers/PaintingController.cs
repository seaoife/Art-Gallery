using CA2ArtGallery1.Data;
using CA2ArtGallery1.Models;
using CA2ArtGallery1.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CA2ArtGallery1.Controllersgree
{
    public class PaintingController : Controller
    {// chold of the parent controller build in functionlaity in c sharp. each function in the controller defines a operation which co in side s with a view.

        private readonly IPainting PRepo;
        private readonly IArtist ARepo;
        private readonly IStyle SRepo;
        private readonly IMediumUsed MRepo;
        private readonly IPaintingArtistViewModel VRepo;
        private readonly IWebHostEnvironment webHostEnvironment;


        private ApplicationDbContext _DbInstance { get; }// think of the interface as the middleman between the repository and the controller.
        //All models-Interface --repository(child of the interface) and communicates infro from the database to the controller---- Controller --- 

        public PaintingController( IPainting paint, IArtist artist, IMediumUsed mediumUsed, IStyle style, ApplicationDbContext dbInstance, IWebHostEnvironment webhost)
        {
            _DbInstance = dbInstance;
            PRepo = paint;
            ARepo = artist;
            SRepo = style;
            MRepo = mediumUsed;
            webHostEnvironment = webhost;
           
        }

        // GET: Paintings
        [Authorize]// you will nedd to login to access the iaction index function.
        public async Task<IActionResult> Index(int id)// asyncis an operator that it will run a task in paralell with other tasks. 
        {
            var greeting = getGreeting();
            if(id <= 0)
            {
                var ps = PRepo.AllPaintings;
                ViewData["Message"] = greeting;
                return View(ps);
            }
            var paintings = PRepo.AllPaintingsByStyleId(id);
            ViewData["Message"] = greeting;
            return View(paintings);
        }

        // GET: Paintings/Details/5
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var painting = await _DbInstance.Paintings
                .Include(p => p.Artist)
                .Include(p => p.MediumUsed)
                .Include(p => p.Style)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (painting == null)
            {
                return NotFound();
            }

            return View(painting);
        }
        // GET: Paintings/Create
        [Authorize(Roles = "artist")]// artist is our admin
        public IActionResult Create()// this is for the actual view to create form.
        {
            ViewData["ArtistId"] = new SelectList(_DbInstance.Artists, "Id", "Id");
            ViewData["MediumUsedId"] = new SelectList(_DbInstance.MediumUseds, "MediumUsedId", "MediumUsedId");
            ViewData["StyleId"] = new SelectList(_DbInstance.Styles, "StyleId", "StyleId");
            return View();
        }

        // POST: Paintings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ArtistId,Title,MediumUsedId,StyleId,Subject,Height,Length,Width,Framed,Description,Price,Image,AlternateText,UploadDate")] PaintingViewModel painting)
        {// this is for handling submit button.
            if (ModelState.IsValid)
            {
                string uploadedFile = UploadedFile(painting);// uploaded file will upload the file and return the file path
                Console.WriteLine(uploadedFile);
                Painting p = new Painting// p is an instance of the class painting. 
                {
                    Title = painting.Title,
                    ArtistId = painting.ArtistId,
                    MediumUsedId = painting.MediumUsedId,
                    StyleId = painting.StyleId,
                    Subject = painting.Subject,
                    Height = painting.Height,
                    Length = painting.Length,
                    Width = painting.Width,
                    Framed = painting.Framed,
                    Description = painting.Description,
                    Price = painting.Price,
                    Id = painting.Id,
                    AlternateText = painting.AlternateText,
                    UploadDate = painting.UploadDate,
                    Image = uploadedFile
                };
                _DbInstance.Add(p);
                await _DbInstance.SaveChangesAsync();
                return RedirectToAction(nameof(Index));//button at the botton to redirect back to teh index pahe, or home page. 
            }
            ViewData["ArtistId"] = new SelectList(_DbInstance.Artists, "Id", "Id", painting.ArtistId);
            ViewData["MediumUsedId"] = new SelectList(_DbInstance.MediumUseds, "MediumUsedId", "MediumUsedId", painting.MediumUsedId);
            ViewData["StyleId"] = new SelectList(_DbInstance.Styles, "StyleId", "StyleId", painting.StyleId);
            return View(painting);
        }

        [Authorize(Roles = "artist")]
        public async Task<IActionResult> Edit(int? id)// ?  any id, weither its null or not. 
        {
            if (id == null)
            {
                return NotFound();
            }

            var painting = await _DbInstance.Paintings.FindAsync(id);
            if (painting == null)
            {
                return NotFound();
            }
            ViewData["ArtistId"] = new SelectList(_DbInstance.Artists, "Id", "Id", painting.ArtistId);
            ViewData["MediumUsedId"] = new SelectList(_DbInstance.MediumUseds, "MediumUsedId", "MediumUsedId", painting.MediumUsedId);
            ViewData["StyleId"] = new SelectList(_DbInstance.Styles, "StyleId", "StyleId", painting.StyleId);
            return View(painting);
        }

        // POST: Paintings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ArtistId,Title,MediumUsedId,StyleId,Subject,Height,Length,Width,Framed,Description,Price,Image,AlternateText,UploadDate")] Painting painting)
        {
            if (id != painting.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _DbInstance.Update(painting);
                    await _DbInstance.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaintingExists(painting.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;// cathcing an error. 
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArtistId"] = new SelectList(_DbInstance.Artists, "Id", "Id", painting.ArtistId);
            ViewData["MediumUsedId"] = new SelectList(_DbInstance.MediumUseds, "MediumUsedId", "MediumUsedId", painting.MediumUsedId);
            ViewData["StyleId"] = new SelectList(_DbInstance.Styles, "StyleId", "StyleId", painting.StyleId);
            return View(painting);
        }

        // GET: Paintings/Delete/5
        [Authorize(Roles = "artist")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var painting = await _DbInstance.Paintings
                .Include(p => p.Artist)
                .Include(p => p.MediumUsed)
                .Include(p => p.Style)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (painting == null)
            {
                return NotFound();
            }

            return View(painting);
        }

        // POST: Paintings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var painting = await _DbInstance.Paintings.FindAsync(id);
            _DbInstance.Paintings.Remove(painting);
            await _DbInstance.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaintingExists(int id)// called in the edit function for validation
        {
            return _DbInstance.Paintings.Any(e => e.Id == id);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });// tertery function
        }// if you find an error and no reuslts are found show the error page for example when I tried to open edit button, while not logged in as an admin.
        // i ma checking if the first element is the same as the second one. you need to check the vlaue of two elements. 
        // ? is the activity.Current null, if it is break the execution. if it is not null, the ?? means the http. traceIdentifier gives you all the information for the web. 

        public String getGreeting()
        {
            int hour = DateTime.Now.Hour;
            if (hour < 12)
            {
                return "Good Morning Art Enthusiast " ;

            }
            else if (hour >= 12 && hour < 18)
            {
                return "Good Afternoon Art Enthusiast " ;
            }
            else
            {
               return "Good Evening Art Enthusiast " ;
            }

        }

        private Boolean isPaintingExist(int id)
        {
            var painting = PRepo.GetPaintingById(id);
            if (painting == null) return false;
            return true;
        }

        private string UploadedFile(PaintingViewModel model)
        {
            string uniqueFileName = null;

            if (model.Image != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Image.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }




    }
}