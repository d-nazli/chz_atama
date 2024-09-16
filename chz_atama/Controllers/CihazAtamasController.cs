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
    public class CihazAtamasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CihazAtamasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CihazAtamas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CihazAtamas.Include(c => c.Cihaz).Include(c => c.Personel);
            return View(await applicationDbContext.ToListAsync());
        }

       
        public JsonResult personelgoster(int ID)
        {
            var state = _context.Personels.Where(w => w.DepartmanID == ID).ToList();
            return Json(state);
        }

        // GET: CihazAtamas/Create
        public IActionResult Create()
        {
            ViewBag.dprtmn = new SelectList(_context.Departmans.ToList(), "DepartmanID", "DepartmanAdi");

            
            var unassignedDevices = _context.Cihazs
                .Where(c => !_context.CihazAtamas.Any(a => a.CihazId == c.CihazId))
                .ToList();

            ViewBag.CihazId = new SelectList(unassignedDevices, "CihazId", "CihazSeriNo");
            return View();
        }


        // POST: CihazAtamas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AtamaId,PersonelId,CihazId,AtamaTarihi")] CihazAtama cihazAtama)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cihazAtama);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.CihazId = new SelectList(_context.Cihazs, "CihazId", "CihazSeriNo", cihazAtama.CihazId); 
            ViewBag.dprtmn = new SelectList(_context.Departmans.ToList(), "DepartmanID", "DepartmanAdi"); 
            return View(cihazAtama);
        }

       

        // GET: CihazAtamas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cihazAtama = await _context.CihazAtamas
                .Include(c => c.Cihaz)
                .Include(c => c.Personel)
                .FirstOrDefaultAsync(m => m.AtamaId == id);
            if (cihazAtama == null)
            {
                return NotFound();
            }

            return View(cihazAtama);
        }

        // POST: CihazAtamas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cihazAtama = await _context.CihazAtamas.FindAsync(id);
          //  if (cihazAtama != null)
            
                _context.CihazAtamas.Remove(cihazAtama);
            

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CihazAtamaExists(int id)
        {
            return _context.CihazAtamas.Any(e => e.AtamaId == id);
        }
    }
}
