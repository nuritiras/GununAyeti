using Microsoft.EntityFrameworkCore;

namespace GununAyeti.Models
{
    // Veritabanı bağlantısını sağlamak için RepositoryContext sınıfını kullanıyoruz.
    public class RepositoryContext : DbContext
    {
        public DbSet<Ayet> Ayetler { get; set; } // Ayetler tablosunu oluşturuyoruz.
        // Veritabanı bağlantısını sağlamak için RepositoryContext sınıfını kullanıyoruz.
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options) // Veritabanı bağlantısını sağlamak için base sınıfının constructor metodunu kullanıyoruz.
        {
            
        }
    }
}