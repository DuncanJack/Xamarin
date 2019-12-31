using System;
using Newtonsoft.Json;

namespace WebServiceTutorial.Models
{
    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }
    }
}
