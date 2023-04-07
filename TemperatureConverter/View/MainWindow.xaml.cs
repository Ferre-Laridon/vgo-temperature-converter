using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private double kelvinNumber = 273.15;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertCelsius(object sender, RoutedEventArgs e)
        {
            // Get input from textbox and parse to string
            var input = textBoxCelsius.Text;
            var celsius = double.Parse(input);

            // Fahrenheit
            var fahrenheit = celsius / (5.0 / 9) + 32;
            var fahrenheitRound = Math.Round(fahrenheit);
            textBoxFahrenheit.Text = fahrenheitRound.ToString();

            // Kelvin
            var kelvin = celsius + kelvinNumber;
            textBoxKelvin.Text = kelvin.ToString();
        }

        private void ConvertFahrenheit(object sender, RoutedEventArgs e)
        {
            // Get input from textbox and parse to string
            var input = textBoxFahrenheit.Text;
            var fahrenheit = double.Parse(input);

            // Celsius
            var celsius = (fahrenheit - 32) * (5.0 / 9);
            var celsiusRound = Math.Round(celsius, 2);
            textBoxCelsius.Text = celsiusRound.ToString();

            // Kelvin
            var kelvin = celsius + kelvinNumber;
            var kelvinRound = Math.Round(kelvin);
            textBoxKelvin.Text = kelvinRound.ToString();
        }

        private void ConvertKelvin(object sender, RoutedEventArgs e)
        {
            // Get input from textbox and parse to string
            var input = textBoxKelvin.Text;
            var kelvin = double.Parse(input);

            // Celsius
            var celsius = kelvin - kelvinNumber;
            var celsiusRound = Math.Round(celsius);
            textBoxCelsius.Text = celsiusRound.ToString();

            // Fahrenheit
            var fahrenheit = celsius / (5.0 / 9) + 32;
            var fahrenheitRound = Math.Round(fahrenheit);
            textBoxFahrenheit.Text = fahrenheitRound.ToString();
        }
    }
}
