using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace View
{
    internal class CelsiusConverter : IValueConverter
    {
        private double kelvinConverter = 273.15;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var kelvin = (double)value;
            var celsius = kelvin - kelvinConverter;

            return celsius.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var celsius = double.Parse((string) value);
            var kelvin = celsius + kelvinConverter;

            return kelvin;
        }
    }
}
