using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ISTC.codingschool.OOP.Attributes._1
{
    [AttributeUsage(AttributeTargets.All)]
    class NatureAttribute:System.Attribute
    {
        [JsonProperty("Եխանակ")]
        public string Season { get; set; }
        [JsonProperty("Գույն")]
        public string Color { get; set; }
        [JsonProperty("Տարի")]
        public int Year { get; set; }
        [JsonProperty("Ամիս")]
        public int Mounth { get; set; }
        public NatureAttribute(string Season,string Color,int Year,int Mounth)
        {
            this.Season = Season;
            this.Color = Color;
            this.Year = Year;
            this.Mounth = Mounth;
        }
    }
}
