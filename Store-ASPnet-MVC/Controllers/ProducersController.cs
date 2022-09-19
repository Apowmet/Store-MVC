using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Store_ASPnet_MVC.Data;

namespace Store_ASPnet_MVC.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDBContext _context;
        public ProducersController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
