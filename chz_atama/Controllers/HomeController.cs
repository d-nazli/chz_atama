using chz_atama.Data;
using chz_atama.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace chz_atama.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ApplicationDbContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }



        public async Task< IActionResult> Index()
        {
            var departmanPersonelSayilari = await _context.Departmans
             .Select(d => new
             {
                 DepartmanAdi = d.DepartmanAdi,
                 PersonelSayisi = d.Personels.Count
             })
             .ToListAsync();

            ViewBag.DepartmanPersonelSayilari = departmanPersonelSayilari;




            var toplamCihaz = _context.Cihazs.Count();

           
            ViewBag.ToplamCihaz = toplamCihaz;
            var toplamPersonel = _context.Personels.Count();

            
            ViewBag.ToplamPersonel = toplamPersonel;
            var atananCihaz = _context.CihazAtamas.Count();
            ViewBag.AtananCihaz = atananCihaz;


            ViewBag.AdminEposta = HttpContext.Session.GetString("admineposta");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Admin admin)

        {
            
            var login = _context.Admins
                .SingleOrDefault(x => x.AdminEposta == admin.AdminEposta);

            if (login != null && login.Sifre == admin.Sifre)
            {
    
                HttpContext.Session.SetString("adminid", login.AdminId.ToString());
                HttpContext.Session.SetString("admineposta", login.AdminEposta);

             
                return RedirectToAction("Index", "Home");
            }

            
            ViewBag.Uyari = "Kullanýcý adý veya þifre hatalý!";
            return View(admin);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
