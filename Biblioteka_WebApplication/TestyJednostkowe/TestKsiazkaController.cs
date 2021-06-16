using Biblioteka_WebApplication.Controllers;
using Biblioteka_WebApplication.Models.DBModels;
using Biblioteka_WebApplication.Repository;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestyJednostkowe
{
    [TestFixture]
    public class Tests
    {
        private readonly IKsiazkaRepository _ksiazkaRepository;
        private readonly KsiazkiRepositoryFake rep = new KsiazkiRepositoryFake();

        class KsiazkiRepositoryFake : IKsiazkaRepository
        {
            private readonly List<Ksiazka> lista = new List<Ksiazka>()
                {
                    new Ksiazka(){Id = 2, Tytul = "List w butelce"},
                    new Ksiazka(){Id = 3, Tytul = "Pan Tadeusz"},
                    new Ksiazka(){Id = 4, Tytul = "Tango"},
                    new Ksiazka(){Id = 5, Tytul = "Harry Potter"}
                };
            public async Task<ActionResult<Ksiazka>> DeleteKsiazke(int id)
            {
                return new Ksiazka() { Id = id };
            }

            public async Task<ActionResult<IEnumerable<Ksiazka>>> Get()
            {
                return lista;
            }

            public async Task<ActionResult<Ksiazka>> GetKsiazka(int id)
            {
              //  var ksiazka =  from k in lista where k.Id.Equals(id) select k;
                //return (Ksiazka)ksiazka;
                return new Ksiazka() { Id = id };
            }

            public async Task<ActionResult<Ksiazka>> PostKsiazki([FromBody] Ksiazka ksiazka)
            {
                throw new System.NotImplementedException();
            }
        }

        [Test]
        public void Test_IdOfKsiazkaShouldBeDeleted()
        {
            //Arrange
            var controller = new KsiazkiController(rep);
            //Act
            var result = controller.DeleteKsiazka(1).Result;
            // Assert
            Assert.AreEqual(1, result.Value.Id);
        }

        [Test]
        public void Test_LenghtOfListShouldBeEqual()
        {
            //Arrange
            var controller = new KsiazkiController(rep);
            //Act
            var result = controller.Get().Result;
            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void Test_IdKsiazkaGetShouldBeEqual()
        {
            //Arrange
            var controller = new KsiazkiController(rep);
            //Act
            var result = controller.GetKsiazka(2).Result;
            // Assert
             Assert.AreEqual(2,result.Value.Id);
        }
    }
}