using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Web.Script.Serialization;
using StaycationMate.Models;

namespace StaycationMate.Controllers
{
    [AllowAnonymous]
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public String GetWeather(string City)
        {
            // *Attribution: some of the implementation is based on tutorials from c-sharpcorner.com, these include using WebClient and RootObject

            // Set my API key
            string apiKey = "USE YOUR OWN OpenWeatherMap API KEY";

            // Pass in two parameters accordingly
            string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&cnt=1&APPID={1}", City, apiKey);

            // Use WebClient to call this API
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);

                // Don't really understand this line
                // But I do know this coverts JSON to an Object
                RootObject weatherInformation = (new JavaScriptSerializer()).Deserialize<RootObject>(json);

                // Initialise the ViewModel and set values
                WeatherViewModel weatherViewModel = new WeatherViewModel();

                weatherViewModel.Country = weatherInformation.sys.country;
                weatherViewModel.City = weatherInformation.name;
                weatherViewModel.Temp = Convert.ToString(weatherInformation.main.temp);
                weatherViewModel.Description = weatherInformation.weather[0].description;
                weatherViewModel.Humidity = Convert.ToString(weatherInformation.main.humidity);
                weatherViewModel.Lat = Convert.ToString(weatherInformation.coord.lat);
                weatherViewModel.Lon = Convert.ToString(weatherInformation.coord.lon);
                weatherViewModel.TempFeelsLike = Convert.ToString(weatherInformation.main.feels_like);
                weatherViewModel.TempMax = Convert.ToString(weatherInformation.main.temp_max);
                weatherViewModel.TempMin = Convert.ToString(weatherInformation.main.temp_min);
                weatherViewModel.WeatherIcon = weatherInformation.weather[0].icon;



                // Converting an Object to JSON string (for displaying)
                var displayingJson = new JavaScriptSerializer().Serialize(weatherViewModel);

                return displayingJson;
            }
        }
    }
}