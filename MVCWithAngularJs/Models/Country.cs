using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWithAngularJs.Models
{
    public class Country
    {
        public int country_id { get; set; }
        public string name { get; set; }

        public Country(int CountryID, string CountryName)
        {
            country_id = CountryID;
            name = CountryName;
        }

        public static List<Country> GetAllCountries()
        {
            List<Country> lstCountries = new List<Country>();
            lstCountries.Add(new Country(1, "USA"));
            lstCountries.Add(new Country(2, "India"));
            lstCountries.Add(new Country(3, "Australia"));
            lstCountries.Add(new Country(4, "Canada"));
            return lstCountries;
        }
    }
}