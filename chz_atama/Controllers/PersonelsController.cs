
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
    public class PersonelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Personels
        public async Task<IActionResult> Index()
        {
     

            var applicationDbContext = _context.Personels.Include(p => p.Departman);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Personels/Details/5
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

        
            var personel = await _context.Personels
                .Include(p => p.Departman) 
                .Include(p => p.CihazAtamalar) 
                .ThenInclude(ca => ca.Cihaz) 
                .FirstOrDefaultAsync(m => m.PersonelId == id);

            if (personel == null)
            {
                return NotFound();
            }

            return View(personel);
        }


        // GET: Personels/Create
        public IActionResult Create()
        {
            ViewBag.dprtmn = new SelectList(_context.Departmans, "DepartmanID", "DepartmanAdi");
            return View();
        }

        // POST: Personels/Create
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonelId,PersonelAd,PersonelSoyad,DepartmanID,PersonelEposta,PersonelTel")] Personel personel)
        {
            _context.Add(personel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }



        // GET: Personels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personel = await _context.Personels.FindAsync(id);
            if (personel == null)
            {
                return NotFound();
            }
          ViewBag.dprtmn = new SelectList(_context.Departmans, "DepartmanID", "DepartmanAdi");
            return View(personel);
        }

        // POST: Personels/Edit/5
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonelId,PersonelAd,PersonelSoyad,DepartmanID,PersonelEposta,PersonelTel")] Personel personel)
        {
            if (id != personel.PersonelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonelExists(personel.PersonelId))
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
            ViewData["DepartmanID"] = new SelectList(_context.Departmans, "DepartmanID", "DepartmanID", personel.DepartmanID);
            return View(personel);
        }

        // GET: Personels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personel = await _context.Personels
                .Include(p => p.Departman)
                .FirstOrDefaultAsync(m => m.PersonelId == id);
            if (personel == null)
            {
                return NotFound();
            }

            return View(personel);
        }

        // POST: Personels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personel = await _context.Personels.FindAsync(id);
            if (personel != null)
            { 
            _context.Personels.Remove(personel);
        }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonelExists(int id)
        {
            return _context.Personels.Any(e => e.PersonelId == id);
        }
    }
}
