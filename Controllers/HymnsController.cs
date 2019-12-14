using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Controllers
{
    public class HymnsController : Controller
    {
        private readonly MeetingContext _context;

        public HymnsController(MeetingContext context)
        {
            _context = context;
        }

        // GET: Hymns
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hymns.ToListAsync());
        }

        // GET: Hymns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hymn = await _context.Hymns
                .FirstOrDefaultAsync(m => m.HymnID == id);
            if (hymn == null)
            {
                return NotFound();
            }

            return View(hymn);
        }

        // GET: Hymns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hymns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HymnID,HymnNo,Title")] Hymn hymn)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hymn);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hymn);
        }

        // GET: Hymns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hymn = await _context.Hymns.FindAsync(id);
            if (hymn == null)
            {
                return NotFound();
            }
            return View(hymn);
        }

        // POST: Hymns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HymnID,HymnNo,Title")] Hymn hymn)
        {
            if (id != hymn.HymnID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hymn);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HymnExists(hymn.HymnID))
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
            return View(hymn);
        }

        // GET: Hymns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hymn = await _context.Hymns
                .FirstOrDefaultAsync(m => m.HymnID == id);
            if (hymn == null)
            {
                return NotFound();
            }

            return View(hymn);
        }

        // POST: Hymns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hymn = await _context.Hymns.FindAsync(id);
            _context.Hymns.Remove(hymn);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HymnExists(int id)
        {
            return _context.Hymns.Any(e => e.HymnID == id);
        }
    }
}
