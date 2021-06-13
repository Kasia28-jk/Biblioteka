using Biblioteka_WebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteka_WebApplication.Data
{
    public class BibliotekaContext : DbContext
    {
        public BibliotekaContext(DbContextOptions<BibliotekaContext> options) : base(options)
        { }

        public DbSet<Ksiazka> Ksiazki { get; set; }
        public DbSet<Gatunek> Gatuneki { get; set; }
        public DbSet<Wypozyczenie> Wypozyczenia { get; set; }
        public DbSet<Uzytkownik> Uzytkownik { get; set; }
        //public DbSet<RelacjaKG> RelacjaKG { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ksiazka>().ToTable("Książka");
            modelBuilder.Entity<Gatunek>().ToTable("Gatunek");
            modelBuilder.Entity<Wypozyczenie>().ToTable("Wypozyczenia");
            modelBuilder.Entity<Uzytkownik>().ToTable("Użytkownik");
        //    modelBuilder.Entity<RelacjaKG>().ToTable("Relacja");
        }
    }
}
