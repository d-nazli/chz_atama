using Microsoft.AspNetCore.Mvc;
using chz_atama.Models;
using System.Linq;
using chz_atama.Data;

public class DeviceStatusController : Controller
{
    private readonly ApplicationDbContext _context;

    public DeviceStatusController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        
        var cihazDurumlari = _context.Cihazs
            .Select(c => new DeviceStatusViewModel
            {
                CihazId = c.CihazId,
                Cihaz = c,
                Durum = _context.CihazAtamas
                    .Any(a => a.CihazId == c.CihazId) ? "Atanmış" : "Kullanılabilir"
            }).ToList();

        return View(cihazDurumlari);
    }

    [HttpPost]
    public IActionResult Search(string cihazModel)
    {
        if (string.IsNullOrWhiteSpace(cihazModel))
        {
            return RedirectToAction("Index");
        }

        var cihazDurumlari = _context.Cihazs
            .Where(c => c.CihazModel.Contains(cihazModel))
            .Select(c => new DeviceStatusViewModel
            {
                CihazId = c.CihazId,
                Cihaz = c,
                Durum = _context.CihazAtamas
                    .Any(a => a.CihazId == c.CihazId) ? "Atanmış" : "Kullanılabilir"
            }).ToList();

        return View("Index", cihazDurumlari);
    }
}

