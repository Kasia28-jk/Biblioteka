using Biblioteka_WebApplication.Controllers;
using Biblioteka_WebApplication.Models.DBModels;
using Biblioteka_WebApplication.Repository;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestyJednostkowe
{
    [TestFixture]
    class TestGatunekController
    {
        private readonly IGatunekRepository _gatunekRepository;
        private readonly GatunekRepositoryFake rep = new GatunekRepositoryFake();

        public class GatunekRepositoryFake : IGatunekRepository
        {
            public async Task<ActionResult<Gatunek>> DeleteGatunek(int id)
            {
                return new Gatunek() { GatunekId = id, Nazwa = "Horror" };
            }

            public Task<ActionResult<IEnumerable<Gatunek>>> Get()
            {
                throw new NotImplementedException();
            }

            public async Task<ActionResult<Gatunek>> GetGatunki(int id)
            {
                return new Gatunek() { GatunekId = id, Nazwa = "Horror" };
            }

            public Task<ActionResult<Gatunek>> PostGatunki([FromBody] Gatunek gatunek)
            {
                throw new NotImplementedException();
            }
        }

        [Test]
        public void Test_IdOfKsiazkaShouldBeDeleted()
        {
            //Arrange
            var controller = new GatunekController(rep);
            //Act
            var result = controller.DeleteGatunek(1).Result;
            // Assert
            Assert.AreEqual("Horror", result.Value.Nazwa);
        }

        [Test]
        public void Test_IdGatunekGetShouldBeEqual()
        {
            //Arrange
            var controller = new GatunekController(rep);
            //Act
            var result = controller.GetGatunki(2).Result;
            // Assert
            Assert.AreEqual(2, result.Value.GatunekId);
        }
    }
}
