using Biblioteka_WebApplication.Controllers;
using Biblioteka_WebApplication.Repository;
using NUnit.Framework;

namespace TestyJednostkowe
{
    [TestFixture]
    public class Tests
    {
        private readonly IKsiazkaRepository _ksiazkaRepository;

        [Test]
        public void Test_GetAll_Reposiotry()
        {
            //Arrange
            var controller = new KsiazkiController(_ksiazkaRepository);
            //Act
            var result = controller.GetKsiazka(1);
            // Assert
            //Assert.AreEqual(
        }

        [Test]
        public void Test_2()
        {
           // Assert.Pass();
        }
    }
}