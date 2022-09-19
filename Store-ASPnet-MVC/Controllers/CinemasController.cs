using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Store_ASPnet_MVC.Data;

namespace Store_ASPnet_MVC.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDBContext _context;
        public CinemasController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _context.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}
