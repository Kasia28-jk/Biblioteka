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
            private readonly List<Uzytkownik> list = new List<Uzytkownik>()
                {
                    new Uzytkownik(){UzytkownikId = 1},
                    new Uzytkownik(){UzytkownikId = 3},
                    new Uzytkownik(){UzytkownikId = 5},
                };
            public async Task<ActionResult<Uzytkownik>> Delete(int id)
            {
                return new Uzytkownik() { UzytkownikId = id };
            }

            public async Task<ActionResult<IEnumerable<Uzytkownik>>> Get()
            {
                
                return list;
            }

            public async Task<ActionResult<Uzytkownik>> Get(int id)
            {
                return new Uzytkownik() { UzytkownikId = id };
            }

            public async Task<ActionResult<Uzytkownik>> Post([FromBody] Uzytkownik user)
            {
                return new Uzytkownik() {
                    UzytkownikId = user.UzytkownikId, 
                    Login = user.Login,
                    Status = user.Status,
                    Hasło = user.Hasło
                };
            }
        }

        //-------------------------------------------------------------------------------------------------

        [Test]
        public void Test_GetAll_Users()
        {
            //Arrange
            var rep = new UzytkownikRepoFake();
            var controller = new UzytkownikController(rep);
            //Act
            var result = controller.Get().Result;
            // Assert
            Assert.AreNotEqual(1, result.Value);
        }

        [Test]
        public void Test_GetOne_User()
        {
            //Arrange
            var rep = new UzytkownikRepoFake();
            var controller = new UzytkownikController(rep);
            //Act
            var result = controller.Get(1).Result;
            // Assert
            Assert.AreEqual(1, result.Value.UzytkownikId);
        }

        [Test]
        public void Test_DeleteOne_User()
        {
            //Arrange
            var rep = new UzytkownikRepoFake();
            var controller = new UzytkownikController(rep);
            //Act
            var result = controller.Delete(4).Result;
            // Assert
            Assert.AreEqual(4, result.Value.UzytkownikId);
        }

        [Test]
        public void Test_DeleteOne_NoEqual_User()
        {
            //Arrange
            var rep = new UzytkownikRepoFake();
            var controller = new UzytkownikController(rep);
            //Act
            var result = controller.Delete(4).Result;
            // Assert
            Assert.AreNotEqual(1, result.Value.UzytkownikId);
        }
    }
}
