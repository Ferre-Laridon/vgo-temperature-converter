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

        private void SliderValueChanged(object sender, RoutedEventArgs e)
        {
            // Get input from slider
            var input = slider.Value;

            // Kelvin
            textBoxKelvin.Text = input.ToString();

            // Celsius
            var celsius = input - kelvinNumber;
            var celsiusRound = Math.Round(celsius);
            textBoxCelsius.Text = celsiusRound.ToString();

            // Fahrenheit
            var fahrenheit = celsius / (5.0 / 9) + 32;
            var fahrenheitRound = Math.Round(fahrenheit);
            textBoxFahrenheit.Text = fahrenheitRound.ToString();
        }
    }
}
