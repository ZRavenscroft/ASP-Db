using BizLand.DAL;
using BizLand.Models;
using BizLand.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BizLand.Controllers
{
    public class HomeController : Controller
    {
        private readonly BizLandDbContext _context;

        public HomeController(BizLandDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel
            {
                Features = _context.Features.ToList(),
                Services = _context.Services.ToList(),
                Testimonials = _context.Testimonials.ToList()
            };
            return View(vm);
        }
        
    }
}
