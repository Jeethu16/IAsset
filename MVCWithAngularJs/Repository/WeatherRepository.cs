using MVCWithAngularJs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWithAngularJs.Repository
{
    public class WeatherRepository :IWeatherRepository
    {
        //Get the list of countries
        public List<Country> GetCountries()
        {
            if (Country.GetAllCountries() != null || Country.GetAllCountries().Count > 0)
            {
                var result = Country.GetAllCountries().ToList();
                return result;
            }

            return null;
        }


        //Get the list of Cities
        public List<City> GetCitiesByCountryId(int? countryid)
        {
            List<City> lstCities = City.GetAllCities();
            if (lstCities != null || lstCities.Count > 0)
            {
                var result = lstCities.Where(item => item.countryid == countryid).ToList();
                return result;
            }

            return null;
        }


        //Get the list of Cities
        public List<Weather> GetWeatherByCityId(int? cityid)
        {
            List<Weather> lstWeather = Weather.GetAllWeather();
            if (lstWeather != null || lstWeather.Count > 0)
            {
                var result = lstWeather.Where(item => item.cityid == cityid).ToList();
                return result;
            }

            return null;
        }
    }
}