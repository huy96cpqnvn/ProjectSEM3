using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Admin.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Admin.Controllers
{
    public class NgoesController : Controller
    {
        private readonly StoreDBContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public NgoesController(StoreDBContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostEnvironment = hostingEnvironment;
        }

        // GET: Ngoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ngos.ToListAsync());
        }

        // GET: Ngoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ngo = await _context.Ngos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ngo == null)
            {
                return NotFound();
            }

            return View(ngo);
        }

        // GET: Ngoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ngoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ImageFile,Content,Description")] Ngo ngo)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(ngo.ImageFile.FileName);
                string extension = Path.GetExtension(ngo.ImageFile.FileName);
                ngo.ImageNgo = fileName = fileName + DateTime.Now.ToString("yymmssffff") + extension;
                string path = Path.Combine(wwwRootPath + "/images", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await ngo.ImageFile.CopyToAsync(fileStream);
                }
                _context.Add(ngo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ngo);
        }

        // GET: Ngoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ngo = await _context.Ngos.FindAsync(id);
            if (ngo == null)
            {
                return NotFound();
            }
            return View(ngo);
        }

        // POST: Ngoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ImageFile,Content,Description")] Ngo ngo)
        {
            if (id != ngo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(ngo.ImageFile.FileName);
                string extension = Path.GetExtension(ngo.ImageFile.FileName);
                ngo.ImageNgo = fileName = fileName + DateTime.Now.ToString("yymmssffff") + extension;
                string path = Path.Combine(wwwRootPath + "/images", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await ngo.ImageFile.CopyToAsync(fileStream);
                }

                try
                {
                    _context.Update(ngo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NgoExists(ngo.Id))
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
            return View(ngo);
        }

        // GET: Ngoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ngo = await _context.Ngos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ngo == null)
            {
                return NotFound();
            }

            return View(ngo);
        }

        // POST: Ngoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ngo = await _context.Ngos.FindAsync(id);
            _context.Ngos.Remove(ngo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NgoExists(int id)
        {
            return _context.Ngos.Any(e => e.Id == id);
        }
    }
}
