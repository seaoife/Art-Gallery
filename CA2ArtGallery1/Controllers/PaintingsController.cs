using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CA2ArtGallery1.Data;
using CA2ArtGallery1.Models;

namespace CA2ArtGallery1.Controllers
{
    public class PaintingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PaintingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Paintings
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Paintings.Include(p => p.Artist).Include(p => p.MediumUsed).Include(p => p.Style);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Paintings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var painting = await _context.Paintings
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
        public IActionResult Create()
        {
            ViewData["ArtistId"] = new SelectList(_context.Artists, "Id", "Id");
            ViewData["MediumUsedId"] = new SelectList(_context.MediumUseds, "MediumUsedId", "MediumUsedId");
            ViewData["StyleId"] = new SelectList(_context.Styles, "StyleId", "StyleId");
            return View();
        }

        // POST: Paintings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ArtistId,Title,MediumUsedId,StyleId,Subject,Height,Length,Width,Framed,Description,Price,Image,AlternateText,UploadDate")] Painting painting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(painting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArtistId"] = new SelectList(_context.Artists, "Id", "Id", painting.ArtistId);
            ViewData["MediumUsedId"] = new SelectList(_context.MediumUseds, "MediumUsedId", "MediumUsedId", painting.MediumUsedId);
            ViewData["StyleId"] = new SelectList(_context.Styles, "StyleId", "StyleId", painting.StyleId);
            return View(painting);
        }

        // GET: Paintings/Edit/5
        public async Task<IActionResult> Edit(int? id)// adding a question mark means it is optional
        {
            if (id == null)
            {
                return NotFound();
            }

            var painting = await _context.Paintings.FindAsync(id);
            if (painting == null)
            {
                return NotFound();
            }
            ViewData["ArtistId"] = new SelectList(_context.Artists, "Id", "Id", painting.ArtistId);
            ViewData["MediumUsedId"] = new SelectList(_context.MediumUseds, "MediumUsedId", "MediumUsedId", painting.MediumUsedId);
            ViewData["StyleId"] = new SelectList(_context.Styles, "StyleId", "StyleId", painting.StyleId);
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
                    _context.Update(painting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaintingExists(painting.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArtistId"] = new SelectList(_context.Artists, "Id", "Id", painting.ArtistId);
            ViewData["MediumUsedId"] = new SelectList(_context.MediumUseds, "MediumUsedId", "MediumUsedId", painting.MediumUsedId);
            ViewData["StyleId"] = new SelectList(_context.Styles, "StyleId", "StyleId", painting.StyleId);
            return View(painting);
        }

        // GET: Paintings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var painting = await _context.Paintings
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
            var painting = await _context.Paintings.FindAsync(id);
            _context.Paintings.Remove(painting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaintingExists(int id)
        {
            return _context.Paintings.Any(e => e.Id == id);
        }
    }
}
