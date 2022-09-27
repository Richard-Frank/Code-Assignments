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
using RF.VehicleTracker.UIService.VehicleReference;
using RF.VehicleTracker.UIService.ColorReference;

namespace RF.VehicleTracker.UIService
{
    /// <summary>
    /// Interaction logic for MaintainVehicles.xaml
    /// </summary>

    public enum ScreenMode
    {
        Color = 1,
        Make = 2,
        Model = 3
    }
    public partial class MaintainVehicles : Window
    {
        List<CVehicle> vehicles;
        List<CColor> colors;

        public MaintainVehicles()
        {
            InitializeComponent();
            vehicles = new List<CVehicle>();
        }

        private void btnColors_Click(object sender, RoutedEventArgs e)
        {
            MaintainAttributes oAttributes = new MaintainAttributes(ScreenMode.Color);
            oAttributes.ShowDialog();
        }

        private void btnMakes_Click(object sender, RoutedEventArgs e)
        {
            MaintainAttributes oAttributes = new MaintainAttributes(ScreenMode.Make);
            oAttributes.ShowDialog();
        }

        private void btnModels_Click(object sender, RoutedEventArgs e)
        {
            MaintainAttributes oAttributes = new MaintainAttributes(ScreenMode.Model);
            oAttributes.ShowDialog();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
