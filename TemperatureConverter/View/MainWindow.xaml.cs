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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertToCelsius(object sender, RoutedEventArgs e)
        {
            var input = textBoxFahrenheit.Text;
            var fahrenheit = double.Parse(input);
            var celsius = (fahrenheit - 32) * (5.0 / 9);
            string output = celsius.ToString();
            textBoxCelsius.Text = output;
        }

        private void ConvertToFahrenheit(object sender, RoutedEventArgs e)
        {
            var input = textBoxCelsius.Text;
            var celsius = double.Parse(input);
            var fahrenheit = celsius / (5.0 / 9) + 32;
            string output = fahrenheit.ToString();
            textBoxFahrenheit.Text = output;
        }
    }
}
