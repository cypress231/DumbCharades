// <copyright file="WeatherForecast.cs" company="Cypress Org">
//     Cypress Org. All rights reserved. 
// </copyright>
// <author>Sai Krishna Podduturi</author>

using System;

namespace DumbCharades.Api
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
