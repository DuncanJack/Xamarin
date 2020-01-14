using System;
using Newtonsoft.Json;

namespace WebServiceTutorial.Models
{
    public class Weather
    {
        [JsonProperty("main")]
        public string Visibility { get; set; }
    }
}
