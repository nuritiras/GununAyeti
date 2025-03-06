using GununAyeti.Models;
using Microsoft.AspNetCore.Mvc;

namespace GununAyeti.Controllers
{
    public class AyetController : Controller
    {
        // Veritabanı bağlantısını sağlamak için RepositoryContext sınıfını kullanıyoruz.
        private readonly RepositoryContext _context; // RepositoryContext sınıfından bir nesne oluşturuyoruz.

        public AyetController(RepositoryContext context)
        {
            _context = context; // RepositoryContext sınıfını kullanabilmek için constructor metodu ile bir nesne oluşturuyoruz.
        }

        public IActionResult Index()
        {
            var model= _context.Ayetler.ToList(); // Ayetler tablosundaki tüm verileri alıyoruz.
            return View(model);
        }

        public IActionResult Get(int id)
        {
            // Id'si verilen ayeti getiriyoruz.
            Ayet ayet = _context.Ayetler.First(a => a.Id==id); 
            return View(ayet);
        }

        public IActionResult GununAyeti()
        {
            Random random = new Random(); // Random sınıfından bir nesne oluşturuyoruz.
            int count = _context.Ayetler.Count(); // Ayetler tablosundaki kayıt sayısını alıyoruz.
            int id  = random.Next(1, count); // 1 ile 4 arasında rastgele bir sayı oluşturuyoruz.
            Ayet ayet = _context.Ayetler.First(a => a.Id==id);  // Id'si rastgele oluşturulan sayıya eşit olan ayeti getiriyoruz.
            return View(ayet); // Ayet nesnesini döndürüyoruz.
        }

        public IActionResult Kayit() // Kayıt sayfasını göstermek için bir action metodu oluşturuyoruz.
        {
            return View(); // Kayıt sayfasını döndürüyoruz.
        }

        [HttpPost] // Formdan gelen verileri almak için HttpPost attribute'ünü kullanıyoruz.
        public IActionResult Kayit(Ayet ayet) // Formdan gelen verileri almak için Ayet sınıfından bir nesne oluşturuyoruz.
        {
            // Veritabanına kayıt işlemi
            _context.Ayetler.Add(ayet); // Ayet nesnesini veritabanına ekliyoruz.
            _context.SaveChanges(); // Değişiklikleri kaydediyoruz.
            return RedirectToAction("Index"); // Index sayfasına yönlendirme yapıyoruz.
        }
    }
}
