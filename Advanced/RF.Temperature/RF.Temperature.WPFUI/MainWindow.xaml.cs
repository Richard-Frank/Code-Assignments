using RF.Temperature1.BL;
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
using RF.Temperature.WPFUI.TemperatureService;

namespace RF.Temperature.WPFUI
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

        private void btnToF_Click(object sender, RoutedEventArgs e)
        {
            double input;

                lblResult.Content = string.Empty;

                try
                {
                    double.TryParse(txtInput.Text, out input);

                    lblResult.Content = CTemper.ConvertToFahr(input).ToString();
                }

                catch (Exception ex)
                {
                    lblResult.Content = ex.Message;
                }
        }

        private void btnToC_Click(object sender, RoutedEventArgs e)
        {
            double input;
            double output;
            lblResult.Content = string.Empty;
            try
            {
                double.TryParse(txtInput.Text, out input);
                CTemper.ConvertToCelsius(input, out output);

                lblResult.Content = output.ToString();
            }

            catch (Exception ex)
            {
                lblResult.Content = ex.Message;
            }
        }

        private void btnToF_Copy_Click(object sender, RoutedEventArgs e)
        {//Error

            lblResult.Content = string.Empty;
            double dbloutput = 0;

            try
            {

                TempServiceClient client = new TempServiceClient();
                double dblinput = client.ConvertToFahrenheit(dbloutput);

                lblResult.Content = CTemper.ConvertToFahr(dbloutput).ToString();

            }

            catch (Exception ex)
            {
                lblResult.Content = ex.Message;
            }
        }

        private void btnToC_Copy_Click(object sender, RoutedEventArgs e)
        {//Error
            double dblinput;
            double dbloutput = 0;

            lblResult.Content = string.Empty;

            try
            {
                TempServiceClient client = new TempServiceClient();
                dblinput = client.ConvertToCelsius(dbloutput);

                lblResult.Content = CTemper.ConvertToFahr(dbloutput).ToString();

            }

            catch (Exception ex)
            {
                lblResult.Content = ex.Message;
            }
        }
    }
}
