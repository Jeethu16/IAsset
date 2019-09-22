using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWithAngularJs.Models
{
    public class City
    {

        public int city_id { get; set; }
        public int countryid { get; set; }
        public string name { get; set; }

        public City(int CityID, int CountryID, string CityName)
        {
            city_id = CityID;
            countryid = CountryID;
            name = CityName;
        }
        public static List<City> GetAllCities()
        {
            List<City> lstCity = new List<City>();
            lstCity.Add(new City(1, 1, "New York"));
            lstCity.Add(new City(2, 1, "Chicago"));
            lstCity.Add(new City(3, 1, "Seattle"));
            lstCity.Add(new City(4, 1, "San Fransisco"));
            lstCity.Add(new City(5, 2, "Mumbai"));
            lstCity.Add(new City(6, 2, "Bangalore"));
            lstCity.Add(new City(7, 2, "Delhi"));
            lstCity.Add(new City(8, 3, "Sydney"));
            lstCity.Add(new City(9, 3, "Adelaide"));
            lstCity.Add(new City(10, 3, "Melbourne"));
            lstCity.Add(new City(11, 4, "Vancouver"));
            lstCity.Add(new City(12, 4, "Montreal"));
            lstCity.Add(new City(13, 4, "Calgary"));
            lstCity.Add(new City(14, 4, "Toronto"));
            return lstCity;
        }
    }
}