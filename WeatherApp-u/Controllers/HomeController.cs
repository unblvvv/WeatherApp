using System;
using System.IO;
using System.Net;
using System.Web.Mvc;
using Newtonsoft.Json;
using WebApplication1.Models;

namespace WeatherApp_u.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Dnipro&units=metric&appid=c43d988ccfe63f2c2c50471e9b2588ae";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream())) { response = streamReader.ReadToEnd(); }
        
            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            
            ViewData["Name"] = weatherResponse.Name;
            ViewData["Temperature"] = Convert.ToInt32(weatherResponse.Main.Temp);
            ViewData["Weather"] = weatherResponse.Weather[0].Description;
            ViewData["Wind"] = weatherResponse.Wind.Speed;
            ViewData["FeelsLike"] = weatherResponse.Main.Feelslike;
            ViewData["Humidity"] = weatherResponse.Main.Humidity;
        
            return View();
        }
    }
}