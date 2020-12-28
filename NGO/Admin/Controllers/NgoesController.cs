using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Admin.Models;

namespace Admin.Controllers
{
    public class NgoesController : Controller
    {
        private readonly StoreDBContext _context;

        public NgoesController(StoreDBContext context)
        {
            _context = context;
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
        public async Task<IActionResult> Create([Bind("Id,Name,ImageNgo,Description")] Ngo ngo)
        {
            if (ModelState.IsValid)
            {
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ImageNgo,Description")] Ngo ngo)
        {
            if (id != ngo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
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
