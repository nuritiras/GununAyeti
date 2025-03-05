using GununAyeti.Models;
using Microsoft.AspNetCore.Mvc;

namespace GununAyeti.Controllers
{
    public class AyetController : Controller
    {
        private readonly RepositoryContext _context;

        public AyetController(RepositoryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model= _context.Ayetler.ToList();
            return View(model);
        }

        public IActionResult Get(int id)
        {
            Ayet ayet = _context.Ayetler.First(a => a.Id==id);
            return View(ayet);
        }
    }
}
