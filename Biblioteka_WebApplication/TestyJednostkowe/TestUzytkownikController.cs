using Biblioteka_WebApplication.Controllers;
using Biblioteka_WebApplication.Models.DBModels;
using Biblioteka_WebApplication.Repository;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestyJednostkowe
{
    [TestFixture]
    public class TestUzytkownikController
    {
        class UzytkownikRepoFake : IUzytkownikRepository
        {
            public Task<ActionResult<Uzytkownik>> Delete(int id)
            {
                throw new NotImplementedException();
            }

            public Task<ActionResult<IEnumerable<Uzytkownik>>> Get()
            {
                IEnumerable<Uzytkownik> list = new List<Uzytkownik>()
                {
                    new Uzytkownik(){UzytkownikId = 1},
                    new Uzytkownik(){UzytkownikId = 3},
                    new Uzytkownik(){UzytkownikId = 5},
                };
                return list.
            }

            public Task<ActionResult<Uzytkownik>> Get(int id)
            {
                throw new NotImplementedException();
            }

            public Task<ActionResult<Uzytkownik>> Post([FromBody] Uzytkownik user)
            {
                throw new NotImplementedException();
            }
        }

        [Test]
        public void Test_GetAll_Reposiotry()
        {
            //Arrange
            var rep = new UzytkownikRepoFake();
            var controller = new UzytkownikController(rep);
            //Act
            var result = controller.Delete(1).Result;
            // Assert
            Assert.AreNotEqual(1, result.Value.UzytkownikId);
        }

    }
}
