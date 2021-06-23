using Biblioteka_WebApplication.Data;
using Biblioteka_WebApplication.Models.DBModels;
using Biblioteka_WebApplication.Repository;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace TestyJednostkowe
{
    [TestFixture]
    class TestRepo
    {
        [Test]
        public async Task Ksiazka_Should_Be_Checked()
        {
            //Setup
            string dbName = Guid.NewGuid().ToString();
            DbContextOptions <BibliotekaContext> options = new DbContextOptionsBuilder<BibliotekaContext>()
                    .UseInMemoryDatabase(databaseName: dbName).Options;

            //Seed
            using (BibliotekaContext bibliotekaContext = new BibliotekaContext(options))
            {
                KsiazkaRepository ksiazkaRepo = new KsiazkaRepository(bibliotekaContext);
                ksiazkaRepo.PostKsiazki(new Ksiazka() { Id = 1, Tytul="Pan Tadeusz" ,Imie="Adam"});
                Assert.AreEqual("Pan Tadeusz", ksiazkaRepo.GetKsiazka(1).Result.Value.Tytul);
                Assert.AreEqual("Adam", ksiazkaRepo.GetKsiazka(1).Result.Value.Imie);
            }
        }

        [Test]
        public async Task Ksiazka_Should_Be_Deleted()
        {
            //Setup
            string dbName = Guid.NewGuid().ToString();
            DbContextOptions<BibliotekaContext> options = new DbContextOptionsBuilder<BibliotekaContext>()
                    .UseInMemoryDatabase(databaseName: dbName).Options;

            //Seed
            using (BibliotekaContext bibliotekaContext = new BibliotekaContext(options))
            {
                KsiazkaRepository ksiazkaRepo = new KsiazkaRepository(bibliotekaContext);
                var result = ksiazkaRepo.DeleteKsiazke(1);
                Assert.AreEqual(1, result.Result.Value.Id);
            }
        }
    }
}
