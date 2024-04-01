using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace MyProject2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string city)
        {
            /*
            if (!string.IsNullOrEmpty(city))
            {
                ViewBag.City = city;

                string key = "8f613725de57ffeac0140695d6572b05";
                string apiUrl = "https://api.openweathermap.org/data/2.5/weather?q=" + city + "&appid=" + key + "&units=metric&lang=en";

                using (var client = new HttpClient())
                {
                    var response = client.GetAsync(apiUrl).Result;
                    response.EnsureSuccessStatusCode();
                    var responseBody = response.Content.ReadAsStringAsync().Result;

                    dynamic weatherData = JObject.Parse(responseBody);
                    ViewBag.Temperature = weatherData.main.temp;
                    ViewBag.Humidity = weatherData.main.humidity;
                    ViewBag.Pressure = weatherData.main.pressure;
                    ViewBag.WindSpeed = weatherData.wind.speed;
                    ViewBag.Cloudiness = weatherData.clouds.all;
                    ViewBag.Description = weatherData.weather[0].description;
                }
            }
            */

            return View();
        }
    }
}
