using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWithAngularJs.Models
{
    public class Weather
    {

        //public int id { get; set; }
        public int cityid { get; set; }
        public string location { get; set; }
        public string time { get; set; }
        public string wind { get; set; }
        public string visibility { get; set; }
        public string skyCondition { get; set; }
        public string temprature { get; set; }
        public string duePoint { get; set; }
        public string relativeHumidity { get; set; }
        public string pressure { get; set; }

        public Weather(int CityID, string Location, string Time, string Wind, string Visibility, string SkyCondition, string Temprature, string DuePoint, string RelativeHumidity, string Pressure)
        {
            cityid = CityID;
            location = Location;
            time = Time;
            wind = Wind;
            visibility = Visibility;
            skyCondition = SkyCondition;
            temprature = Temprature;
            duePoint = DuePoint;
            relativeHumidity = RelativeHumidity;
            pressure = Pressure;
        }

        public static List<Weather> GetAllWeather()
        {
            DateTime aDate = DateTime.Now;
            List<Weather> lstWeather = new List<Weather>();
            lstWeather.Add(new Weather(1, "Manhattan", aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"), "26 km/h", "16 km", "Partly cloudy", "23°C", "14.1°C", "69%", "1026.5hPa"));
            lstWeather.Add(new Weather(2, "Boston", aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"), "28 km/h", "22 km", "Cloudy", "21°C", "10.1°C", "59%", "906.5hPa"));
            lstWeather.Add(new Weather(3, "Lake Union", aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"), "39 km/h", "21 km", "Sunny", "29°C", "19.1°C", "66%", "901.5hPa"));
            lstWeather.Add(new Weather(4, "Pacific Heights", aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"), "56 km/h", "40 km", "Partly Sunny", "20°C", "11.1°C", "55%", "700.5hPa"));
            lstWeather.Add(new Weather(5, "Lonawala", aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"), "27 km/h", "40 km", "Partly Sunny", "20°C", "11.1°C", "55%", "700.5hPa"));
            lstWeather.Add(new Weather(6, "Koramangala", aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"), "25 km/h", "29 km", "Sunny", "29°C", "11.1°C", "55%", "700.5hPa"));
            lstWeather.Add(new Weather(7, "Delhi", aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"), "20 km/h", "29 km", "Sunny", "31°C", "11.1°C", "55%", "700.5hPa"));
            lstWeather.Add(new Weather(8, "Westmead", aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"), "20 km/h", "29 km", "Sunny", "31°C", "11.1°C", "55%", "700.5hPa"));
            lstWeather.Add(new Weather(9, "North Terrace", aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"), "28 km/h", "29 km", "Sunny", "25°C", "11.1°C", "24%", "700.5hPa"));
            lstWeather.Add(new Weather(10, "Flinders Street", aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"), "32 km/h", "29 km", "Partly Sunny", "25°C", "11.1°C", "24%", "700.5hPa"));
            lstWeather.Add(new Weather(11, "Stanley Park", aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"), "32 km/h", "29 km", "Partly Cloudy", "25°C", "11.1°C", "24%", "700.5hPa"));
            lstWeather.Add(new Weather(12, "Ville-Marie", aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"), "32 km/h", "29 km", "Partly Cloudy", "17°C", "11.1°C", "24%", "700.5hPa"));
            lstWeather.Add(new Weather(13, "GlenMore", aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"), "29 km/h", "29 km", "Rain", "17°C", "11.1°C", "24%", "700.5hPa"));
            lstWeather.Add(new Weather(14, "Kingsway", aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"), "29 km/h", "29 km", "Rain", "17°C", "11.1°C", "24%", "700.5hPa"));
            return lstWeather;
        }
    }
}