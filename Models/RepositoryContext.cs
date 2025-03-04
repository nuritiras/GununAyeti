using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace GununAyeti.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Ayet> Ayetler { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ayet>()
            .HasData(
                new Ayet
                {
                    Id = 1,
                    SureIsmi = "Fatiha",
                    ArapcaMetin = "بِسْمِ اللَّهِ اَلرَّحْمٰنِ الرَّحِيمِ",
                    Aciklama = "Rahmân, Rahîm olan Allah'ın ismiyle.",
                    AyetNo = 1
                },
                new Ayet
                {
                    Id = 2,
                    SureIsmi = "Fatiha",
                    ArapcaMetin = "اَلْحَمْدُ لِلَّهِ رَبِّ الْعَالَمِينَ",
                    Aciklama = "Hamd, âlemlerin Rabbi olan Allah'a mahsustur.",
                    AyetNo = 2
                }
            );
        }
    }
}