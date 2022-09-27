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
using System.Windows.Shapes;
using RF.Temperature.WPFUI.ServiceReference1;

namespace RF.Temperature.WPFUI
{
    /// <summary>
    /// Interaction logic for GetData.xaml
    /// </summary>
    public partial class GetData : Window
    {
        public GetData()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, RoutedEventArgs e)
        {
            Service1Client client = new Service1Client();

            string result = client.GetData(Convert.ToInt32(txtData.Text));

            lblData.Content = result;

            //Remember to close the client.
            client.Close();
            client = null;
        }
    }
}
