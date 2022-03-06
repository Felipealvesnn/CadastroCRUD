using CadastroLivroMVC.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace CadastroMVC.Tests.MVC.Controller
{
    [TestClass]
    class HomerControllerTest
    {
        //dado o controler
        [TestMethod, TestCategory("Controllers/HomeController")]
        public void OMetodoIndexDeveraRetornarUmaview()
        {
            //arrange
            var homeController = new HomeController();

            //act
            var result = homeController.Index();

            //assert
            Assert.AreEqual(typeof(ViewResult), result.GetType());

        }

    }
}
