using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AmazingBottles12.Data;
using AmazingBottles12.Models;

namespace AmazingBottles12.Controllers
{
    public class BottlesController : Controller
    {
        private readonly AmazingBottles12Context _context;

        public BottlesController(AmazingBottles12Context context)
        {
            _context = context;
        }

        // GET: Bottles
        public async Task<IActionResult> Index(string searchString)
        {
            var bottles = from m in _context.Bottle
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                bottles = bottles.Where(s => s.Material.Contains(searchString));
            }

            return View(await bottles.ToListAsync());
        }

        // GET: Bottles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bottle = await _context.Bottle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bottle == null)
            {
                return NotFound();
            }

            return View(bottle);
        }

        // GET: Bottles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bottles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Material,Brand,Price")] Bottle bottle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bottle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bottle);
        }

        // GET: Bottles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bottle = await _context.Bottle.FindAsync(id);
            if (bottle == null)
            {
                return NotFound();
            }
            return View(bottle);
        }

        // POST: Bottles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Material,Brand,Price")] Bottle bottle)
        {
            if (id != bottle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bottle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BottleExists(bottle.Id))
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
            return View(bottle);
        }

        // GET: Bottles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bottle = await _context.Bottle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bottle == null)
            {
                return NotFound();
            }

            return View(bottle);
        }

        // POST: Bottles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bottle = await _context.Bottle.FindAsync(id);
            _context.Bottle.Remove(bottle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BottleExists(int id)
        {
            return _context.Bottle.Any(e => e.Id == id);
        }
    }
}
