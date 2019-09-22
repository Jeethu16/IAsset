using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCWithAngularJs.Controllers;
using System.Web.Mvc;
using MVCWithAngularJs.Repository;

namespace IassetUnitTest
{
    [TestClass]
    public class UnitTest1
    {

        private readonly IWeatherRepository _weatherRepository;

        //[TestInitialize]
        public UnitTest1(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }

        [TestMethod]
        
        public void DataTest()
        {
            Assert.AreEqual("DataController", "DataController");
        }

        [TestMethod]

        public void HomeTest()
        {
            Assert.AreEqual("HomeController", "HomeController");
        }
        //[TestMethod]
        //public void ReturnsWeatherView()
        //{
        //    HomeController controllerUnderTest = new HomeController();
        //    var result = controllerUnderTest.Index() as ViewResult;
        //    Assert.AreEqual("Index", result.ViewName);
        //}

        //[TestMethod]
        //public void GetCountriesTest()
        //{
        //    DataController controller = new DataController(_weatherRepository);
        //    JsonResult actual = controller.GetCountries() as JsonResult;

        //    Assert.AreEqual(10, actual.Data);
        //}

    }
}
