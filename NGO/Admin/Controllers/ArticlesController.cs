using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Admin.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Admin.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly StoreDBContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public ArticlesController(StoreDBContext context, IWebHostEnvironment hostingEnvironment)
        {
            
            _context = context;
            _hostEnvironment = hostingEnvironment;
        }

        // GET: Articles
        public async Task<IActionResult> Index()
        {
            var storeDBContext = _context.Articles.Include(d => d.Programmes);
            return View(await storeDBContext.ToListAsync());
        }

        // GET: Articles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                .Include(d => d.Programmes)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        // GET: Articles/Create
        public IActionResult Create()
        {
            ViewData["ProgrameId"] = new SelectList(_context.Programmes, "Id", "Name");
            return View();
        }

        // POST: Articles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,ImageFile,ProgrameId")] Article article)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(article.ImageFile.FileName);
                string extension = Path.GetExtension(article.ImageFile.FileName);
                article.ImagesNew = fileName = fileName + DateTime.Now.ToString("yymmssffff") + extension;
                string path = Path.Combine(wwwRootPath + "/images", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await article.ImageFile.CopyToAsync(fileStream);
                }

                _context.Add(article);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProgrameId"] = new SelectList(_context.Programmes, "Id", "Name", article.ProgrameId);
            return View(article);
        }

        // GET: Articles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles.FindAsync(id);
                
                
            if (article == null)
            {
                return NotFound();
            }
            ViewData["ProgrameId"] = new SelectList(_context.Programmes, "Id", "Name", article.ProgrameId);
            return View(article);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,ImageFile,ProgrameId")] Article article)
        {
            

            if (id != article.Id)
            {
                return NotFound();
            }
            
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(article.ImageFile.FileName);
                string extension = Path.GetExtension(article.ImageFile.FileName);
                article.ImagesNew = fileName = fileName + DateTime.Now.ToString("yymmssffff") + extension;
                string path = Path.Combine(wwwRootPath + "/images", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await article.ImageFile.CopyToAsync(fileStream);
                }

                try
                {
                    _context.Update(article);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticleExists(article.Id))
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
            ViewData["ProgrameId"] = new SelectList(_context.Programmes, "Id", "Name", article.ProgrameId);
            return View(article);
        }

        // GET: Articles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                .Include(d => d.Programmes)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        // POST: Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArticleExists(int id)
        {
            return _context.Articles.Any(e => e.Id == id);
        }
    }
}
