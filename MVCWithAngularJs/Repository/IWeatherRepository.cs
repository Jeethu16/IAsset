using MVCWithAngularJs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWithAngularJs.Repository
{
    public interface IWeatherRepository
    {
        List<Country> GetCountries();
        List<City> GetCitiesByCountryId(int? countryid);
        List<Weather> GetWeatherByCityId(int? cityid);
    }
}
