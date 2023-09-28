using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public static void WeatherInquiry()
        {
       
            HttpClient client = new HttpClient();

            string apiKey = "ca41f444d9a9875149e554d6e00b148d"; 
           
            Console.WriteLine("For what city would you like the temperature?");
            string cityName = Console.ReadLine();

            string weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";

            string weatherResponse = client.GetStringAsync(weatherURL).Result;

            JObject weatherObject = JObject.Parse(weatherResponse);

            Console.WriteLine($"The temperature in {cityName} is {weatherObject["main"]["temp"]} degrees Fahrenheit.");

        }

    }
}
