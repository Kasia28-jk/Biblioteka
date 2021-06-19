using Biblioteka_WebApplication.Data;
using Biblioteka_WebApplication.Models.DBModels;
using Biblioteka_WebApplication.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestyJednostkowe
{
    class TestRepo
    {
        public async Task Ksiazka_Should_Be_Added()
        {
            //Setup
            string dbName = Guid.NewGuid().ToString();
            DbContextOptions <BibliotekaContext> options = new DbContextOptionsBuilder<BibliotekaContext>()
                    .UseInMemoryDatabase(databaseName: dbName).Options;

            //Seed
            using (BibliotekaContext bibliotekaContext = new BibliotekaContext(options))
            {
               Ksiazka ksiazka = Ksiazka
            }

        }
    }
}
