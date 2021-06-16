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

        class KsiazkiRepoFake : IKsiazkaRepository
        {
            public async Task<ActionResult<Ksiazka>> DeleteKsiazke(int id)
            {
                return new Ksiazka() { Id=id };
            }

            public async Task<ActionResult<IEnumerable<Ksiazka>>> Get()
            {
                throw new System.NotImplementedException();
                //return await new List<Ksiazka>;
            }

            public Task<ActionResult<Ksiazka>> GetKsiazka(int id)
            {
                throw new System.NotImplementedException();
            }

            public Task<ActionResult<Ksiazka>> PostKsiazki([FromBody] Ksiazka ksiazka)
            {
                throw new System.NotImplementedException();
            }
        }

        [Test]
        public void Test_GetAll_Reposiotry()
        {
            //Arrange
            var rep = new KsiazkiRepoFake();
            var controller = new KsiazkiController(rep);
            //Act
            var result = controller.DeleteKsiazka(1).Result;
            // Assert
            Assert.AreNotEqual(1, result.Value.Id);
        }

        [Test]
        public void Test_2()
        {
           // Assert.Pass();
        }
    }
}