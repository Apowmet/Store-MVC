using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Store_ASPnet_MVC.Data;

namespace Store_ASPnet_MVC.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDBContext _context;
        public MoviesController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.Include(n => n.Cinema).OrderBy(n => n.Name).ToListAsync();
            return View(allMovies);
        }
    }
}
