﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    internal interface ITemperatureScale
    {
        string Name { get; }

        double ConvertToKelvin(double temperature);
        double ConvertFromKelvin(double temperature);
    }

    public class KelvinTemperaturScale : ITemperatureScale
    {
        public string Name { get; }

        public double ConvertFromKelvin(double temperature)
        {
            return temperature;
        }

        public double ConvertToKelvin(double temperature)
        {
            return temperature;
        }
    }

    public class CelsiusTemperatureScale : ITemperatureScale
    {
        public string Name { get; }

        public double ConvertFromKelvin(double temperature)
        {
            return temperature - 273.15;
        }

        public double ConvertToKelvin(double temperature)
        {
            return temperature + 273.15;
        }
    }

    public class FahrenheitTemperatureScale : ITemperatureScale
    {
        public string Name { get; }

        public double ConvertFromKelvin(double temperature)
        {
            return (temperature - 273.15) * (9.0 / 5) + 32;
        }

        public double ConvertToKelvin(double temperature)
        {
            return (temperature - 32) / (9.0 / 5) + 273.15;
        }
    }

    public class TemperatureConverter : ITemperatureScale
    {
        public string Name { get; }

        public double ConvertFromKelvin(double temperature)
        {

        }

        public double ConvertToKelvin(double temperature)
        {
            
        }
    }
}
