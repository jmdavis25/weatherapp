using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class HistoricalData
    {
        public int HistoricalId { get; set; }
        public int CityId { get; set; }
        public string City { get; set; }
        public string Conditions { get; set; }
        public int Temperature { get; set; }
        public int WindSpeed { get; set; }
        public int Humidity { get; set; }
        public int CloudCover { get; set; }
        public DateTime Date { get; set; }
    }
}
