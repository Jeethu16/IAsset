using MVCWithAngularJs.Models;
using MVCWithAngularJs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVCWithAngularJs.Controllers
{
    public class DataController : Controller
    {

        private readonly IWeatherRepository _weatherRepository;
        public DataController(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }



        // Fetch Country
        [HttpGet]
        public JsonResult GetCountries()
        {
            try
            {
                
                var countries = _weatherRepository.GetCountries();
                if (countries == null)
                {

                    return null;


                }
                //Log.Information("ActionResult GetCountries finished executing");
                return Json(countries, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                //Log.Error(ex, "An error occurred while GetCountries");
                return null;
            }
        }
        // Fetch City by Country ID
        [HttpGet]
        public JsonResult GetCities(int countryID)
        {
            try
            {
                
                var cities = _weatherRepository.GetCitiesByCountryId(countryID);
                if (cities == null)
                {
                   
                    //Log.Information("City is null");
                    return null;


                }
                //Log.Information("ActionResult GetCities finished executing");
                return Json(cities, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                //Log.Error(ex, "An error occurred while GetCities");
                return null;
            }
        }

        [HttpGet]
        public JsonResult GetWeather(int cityID)
        {
            try
            {
                //Log.Information("API GetWeather Started");
                var weather = _weatherRepository.GetWeatherByCityId(cityID);
                if (weather == null)
                {
                    
                    //Log.Information("Weather is null");
                    return null;


                }
                //Log.Information("API GetWeather finished executing");
                return Json(weather, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                //Log.Error(ex, "An error occurred while GetWeather");
                return null;
            }
        }
    }
}
