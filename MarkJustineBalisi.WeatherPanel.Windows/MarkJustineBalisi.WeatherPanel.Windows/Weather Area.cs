using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkJustineBalisi.WeatherPanel.Windows
{
    class Weather_Area
    {
        public string Latitude { get; set; }

        public string Longitude { get; set; }
        public CurrentWeather Currently { get; set; }
    }

    public class CurrentWeather
    {
        public string Summary { get; set; }
    }
}
