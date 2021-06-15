using Biblioteka_WebApplication.Controllers;
using Biblioteka_WebApplication.Data;
using Biblioteka_WebApplication.Models.DBModels;
using Biblioteka_WebApplication.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace TestyJednostkowe
{
    [TestClass]
    public class Tests
    {
        private readonly KsiazkaRepository _ksiazkaRepository;
       
        [TestMethod]
        public void Test_GetAll_Reposiotry()
        {
            //Arrange
            var controller = new KsiazkiController(_ksiazkaRepository);
            //Act
            var result = controller.GetKsiazka(1);
            // Assert
            //Assert.AreEqual(
        }

        [TestMethod]
        public void Test_2()
        {
           // Assert.Pass();
        }
    }
}