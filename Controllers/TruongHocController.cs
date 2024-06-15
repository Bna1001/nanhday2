using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using nanh1111kiemtra.Models;

namespace nanh1111kiemtra.Controllers
{
    public class TruongHocController : Controller
    {
        private readonly LTQDD _context;

        public TruongHocController(LTQDD context)
        {
            _context = context;
        }

        // GET: TruongHoc
        public async Task<IActionResult> Index()
        {
              return _context.TruongHoc != null ? 
                          View(await _context.TruongHoc.ToListAsync()) :
                          Problem("Entity set 'LTQDD.TruongHoc'  is null.");
        }

        // GET: TruongHoc/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.TruongHoc == null)
            {
                return NotFound();
            }

            var truongHoc = await _context.TruongHoc
                .FirstOrDefaultAsync(m => m.MaTruongHoc == id);
            if (truongHoc == null)
            {
                return NotFound();
            }

            return View(truongHoc);
        }

        // GET: TruongHoc/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TruongHoc/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaTruongHoc,TenTruongHoc,MaLop")] TruongHoc truongHoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(truongHoc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(truongHoc);
        }

        // GET: TruongHoc/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.TruongHoc == null)
            {
                return NotFound();
            }

            var truongHoc = await _context.TruongHoc.FindAsync(id);
            if (truongHoc == null)
            {
                return NotFound();
            }
            return View(truongHoc);
        }

        // POST: TruongHoc/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaTruongHoc,TenTruongHoc,MaLop")] TruongHoc truongHoc)
        {
            if (id != truongHoc.MaTruongHoc)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(truongHoc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TruongHocExists(truongHoc.MaTruongHoc))
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
            return View(truongHoc);
        }

        // GET: TruongHoc/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.TruongHoc == null)
            {
                return NotFound();
            }

            var truongHoc = await _context.TruongHoc
                .FirstOrDefaultAsync(m => m.MaTruongHoc == id);
            if (truongHoc == null)
            {
                return NotFound();
            }

            return View(truongHoc);
        }

        // POST: TruongHoc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.TruongHoc == null)
            {
                return Problem("Entity set 'LTQDD.TruongHoc'  is null.");
            }
            var truongHoc = await _context.TruongHoc.FindAsync(id);
            if (truongHoc != null)
            {
                _context.TruongHoc.Remove(truongHoc);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TruongHocExists(string id)
        {
          return (_context.TruongHoc?.Any(e => e.MaTruongHoc == id)).GetValueOrDefault();
        }
    }
}
