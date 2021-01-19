using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Admin.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Admin.Controllers
{
    public class DonatesController : Controller
    {
        private readonly StoreDBContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public DonatesController(StoreDBContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Donates
        public async Task<IActionResult> Index()
        {
            var storeDBContext = _context.Donates.Include(d => d.Programmes);
            return View(await storeDBContext.ToListAsync());
        }

        // GET: Donates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donate = await _context.Donates
                .Include(d => d.Programmes)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (donate == null)
            {
                return NotFound();
            }

            return View(donate);
        }

        // GET: Donates/Create
        public IActionResult Create()
        {
            ViewData["ProgrammeId"] = new SelectList(_context.Programmes, "Id", "Name");
            return View();
        }

        // POST: Donates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Price,ProgrammeId,DateDonate,Description, UserId")] Donate donate)
        {
            if (ModelState.IsValid)
            {
                //var user = await _userManager.FindByIdAsync("Id of currently logged in user");
                //donate.UserId = user;

                //donate = new Donate
                //{
                //    Price = donate.Price,
                //    ProgrammeId = donate.ProgrammeId,
                //    DateDonate = donate.DateDonate,
                //    Description = donate.Description,
                    
                //};
                _context.Add(donate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProgrammeId"] = new SelectList(_context.Programmes, "Id", "Name", donate.ProgrammeId);
            return View(donate);
        }

        // GET: Donates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donate = await _context.Donates.FindAsync(id);
            if (donate == null)
            {
                return NotFound();
            }
            ViewData["ProgrammeId"] = new SelectList(_context.Programmes, "Id", "Name", donate.ProgrammeId);
            return View(donate);
        }

        // POST: Donates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Price,ProgrammeId,DateDonate,Description")] Donate donate)
        {
            if (id != donate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(donate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonateExists(donate.Id))
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
            ViewData["ProgrammeId"] = new SelectList(_context.Programmes, "Id", "Name", donate.ProgrammeId);
            return View(donate);
        }

        // GET: Donates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donate = await _context.Donates
                .Include(d => d.Programmes)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (donate == null)
            {
                return NotFound();
            }

            return View(donate);
        }

        // POST: Donates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var donate = await _context.Donates.FindAsync(id);
            _context.Donates.Remove(donate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonateExists(int id)
        {
            return _context.Donates.Any(e => e.Id == id);
        }
    }
}
