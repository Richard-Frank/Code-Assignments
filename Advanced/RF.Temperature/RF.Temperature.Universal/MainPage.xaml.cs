using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RF.Temperature.Universal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnToF_Click(object sender, RoutedEventArgs e)
        {
            double input;

            lblResult.Text = string.Empty;

            try
            {
                double.TryParse(txtInput.Text, out input);

                //lblResult.Text = CTemper.ConvertToFahr(input).ToString();
            }

            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
            }
        }

        private void btnToC_Click(object sender, RoutedEventArgs e)
        {
            double input;
            double output;
            lblResult.Text = string.Empty;
            try
            {
                double.TryParse(txtInput.Text, out input);
                //CTemper.ConvertToCelsius(input, out output);

                //lblResult.Text = output.ToString();
            }

            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
            }
        }
    }
}
