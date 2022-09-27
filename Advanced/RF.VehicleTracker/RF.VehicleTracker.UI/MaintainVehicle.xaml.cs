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
using RF.VehicleTracker.CC;
using RF.VehicleTracker.BL;

namespace RF.VehicleTracker.UI
{
    /// <summary>
    /// Interaction logic for MaintainVehicle.xaml
    /// </summary>
    public partial class MaintainVehicle : Window
    {
        public MaintainVehicle()
        {
            InitializeComponent();
            ucVehicle maintainvehicle = new ucVehicle();
            this.grdVehicle.Children.Add(maintainvehicle);
        }

        public MaintainVehicle(CVehicle vehicle)
        {
            InitializeComponent();

            ucVehicle maintainvehicle = new ucVehicle(vehicle);
            this.grdVehicle.Children.Add(maintainvehicle);
        }
    }
}
