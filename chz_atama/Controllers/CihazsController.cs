using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using chz_atama.Data;
using chz_atama.Models;

namespace chz_atama.Controllers
{
    public class CihazsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CihazsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cihazs

        public async Task<IActionResult> Index(string p)
        {
            var degerler = from d in _context.Cihazs
                           select new
                           {
                               Cihaz = d,
                               IsAssigned = _context.CihazAtamas.Any(a => a.CihazId == d.CihazId)
                           };

            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.Cihaz.CihazModel.Contains(p));
            }

            var cihazListesi = await degerler.Select(d => new Cihaz
            {
                CihazId = d.Cihaz.CihazId,
                CihazModel = d.Cihaz.CihazModel,
                CihazAdi=d.Cihaz.CihazAdi,
                CihazSeriNo=d.Cihaz.CihazSeriNo,
                IsAssigned = d.IsAssigned
            }).ToListAsync();

            return View(cihazListesi);
        }



        // GET: Cihazs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cihaz = await _context.Cihazs
                .FirstOrDefaultAsync(m => m.CihazId == id);
            if (cihaz == null)
            {
                return NotFound();
            }

            return View(cihaz);
        }

        // GET: Cihazs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cihazs/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CihazId,CihazAdi,CihazModel,CihazSeriNo")] Cihaz cihaz)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cihaz);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cihaz);
        }

        // GET: Cihazs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cihaz = await _context.Cihazs.FindAsync(id);
            if (cihaz == null)
            {
                return NotFound();
            }
            return View(cihaz);
        }

        // POST: Cihazs/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CihazId,CihazAdi,CihazModel,CihazSeriNo")] Cihaz cihaz)
        {
            if (id != cihaz.CihazId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cihaz);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CihazExists(cihaz.CihazId))
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
            return View(cihaz);
        }

        // GET: Cihazs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cihaz = await _context.Cihazs
                .FirstOrDefaultAsync(m => m.CihazId == id);
            if (cihaz == null)
            {
                return NotFound();
            }

            return View(cihaz);
        }

        // POST: Cihazs/Delete/5
     

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cihaz = await _context.Cihazs.FindAsync(id);

            if (cihaz != null)
            {
                // İlgili CihazAtama kayıtlarını silme
                var cihazAtamalar = _context.CihazAtamas.Where(ca => ca.CihazId == id);
                _context.CihazAtamas.RemoveRange(cihazAtamalar);

                _context.Cihazs.Remove(cihaz);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }


        private bool CihazExists(int id)
        {
            return _context.Cihazs.Any(e => e.CihazId == id);
        }
    }

}
