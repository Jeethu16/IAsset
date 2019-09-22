using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCWithAngularJs.Controllers;
using System.Web.Mvc;
using MVCWithAngularJs.Repository;
using MVCWithAngularJs.Models;
using System.Collections.Generic;

namespace IassetTest
{
    [TestClass]
    public class UnitTest1
    {
        

         WeatherRepository _weatherRepository;

        [TestInitialize]
        public void TestInitialize()
        {
           
            _weatherRepository = new WeatherRepository();
        }

        [TestCleanup]
        public void TestCleanup()
        {
           
            _weatherRepository = null;
        }


        

        [TestMethod]
        public void GetCountriesTest()
        {
            DataController controller = new DataController(_weatherRepository);
            JsonResult actual = controller.GetCountries() as JsonResult;
            Assert.IsNotNull(actual);
            List<Country> result = actual.Data as List<Country>;
            var numberOfRecords = result.Count;
            Assert.AreEqual(4, numberOfRecords);
        }

        [TestMethod]
        public void GetCitiesTest()
        {
            DataController controller = new DataController(_weatherRepository);
            JsonResult actual = controller.GetCities(1) as JsonResult;
            Assert.IsNotNull(actual);
            List<City> result = actual.Data as List<City>;
            var numberOfRecords = result.Count;
            Assert.AreEqual(4, numberOfRecords);
        }

        [TestMethod]
        public void GetWeatherTest()
        {
            DataController controller = new DataController(_weatherRepository);
            JsonResult actual = controller.GetWeather(1) as JsonResult;
            Assert.IsNotNull(actual);
            List<Weather> result = actual.Data as List<Weather>;
            var numberOfRecords = result.Count;
            Assert.AreEqual(1, numberOfRecords);
        }
    }

    
}
