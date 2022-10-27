using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.DAL;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
#pragma warning disable CS8604 // Possible null reference argument.
            List < Catigorie > catigories= _context.Catigories.Include(dre=>dre.Dresses).ToList();
#pragma warning restore CS8604 // Possible null reference argument.

#pragma warning disable CS8604 // Possible null reference argument.
            List<Slider> sliders = _context.Sliders.ToList();
#pragma warning restore CS8604 // Possible null reference argument.

#pragma warning disable CS8604 // Possible null reference argument.
            List<Featured> featureds = _context.Featureds.ToList();
#pragma warning restore CS8604 // Possible null reference argument.

#pragma warning disable CS8604 // Possible null reference argument.
            List<Vendor> verdors = _context.Vendors.ToList();
#pragma warning restore CS8604 // Possible null reference argument.



            var homeVievModel = new HomeVievModel
            {
                Catigories = catigories,
                Sliders = sliders,
                Featureds = featureds,
                Vendors=verdors,
            };

            return View(homeVievModel);
        }
    }
}
