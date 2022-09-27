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
using RF.VehicleTracker.BL;

namespace RF.VehicleTracker.UI
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
        CVehicleList vehicles;
        CColorList colors;

        public MaintainVehicles()
        {
            InitializeComponent();
            colors = new CColorList();
            colors.Load();

            cboColor.ItemsSource = null;
            cboColor.ItemsSource = colors;
            cboColor.DisplayMemberPath = "Description";
            cboColor.SelectedValuePath = "Id";
        }

        private void RefreshScreen()
        {
            vehicles = new CVehicleList();
            vehicles.Load();
            dgVehicles.ItemsSource = null;
            dgVehicles.ItemsSource = vehicles;

            dgVehicles.Columns[0].Visibility = Visibility.Hidden;
            dgVehicles.Columns[1].Visibility = Visibility.Hidden;
            dgVehicles.Columns[2].Visibility = Visibility.Hidden;
            dgVehicles.Columns[3].Visibility = Visibility.Hidden;
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
            RefreshScreen();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            CVehicle vehicle;

            vehicle = vehicles[dgVehicles.SelectedIndex];

            MaintainVehicle mv = new MaintainVehicle(vehicle);

            mv.ShowDialog();

            vehicles = new CVehicleList();
            vehicles.Load();
            dgVehicles.ItemsSource = null;
            dgVehicles.ItemsSource = vehicles;
            RefreshScreen();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            MaintainVehicle mv = new MaintainVehicle();

            mv.ShowDialog();
            RefreshScreen();
        }

        private void btnLoadSP_Click(object sender, RoutedEventArgs e)
        {
            vehicles = new CVehicleList();
            vehicles.LoadSP();
            dgVehicles.ItemsSource = null;
            dgVehicles.ItemsSource = vehicles;

            dgVehicles.Columns[0].Visibility = Visibility.Hidden;
            dgVehicles.Columns[1].Visibility = Visibility.Hidden;
            dgVehicles.Columns[2].Visibility = Visibility.Hidden;
            dgVehicles.Columns[3].Visibility = Visibility.Hidden;
        }

        private void cboColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vehicles = new CVehicleList();
            vehicles.LoadByColor(colors[cboColor.SelectedIndex].Description);
            dgVehicles.ItemsSource = null;
            dgVehicles.ItemsSource = vehicles;

            dgVehicles.Columns[0].Visibility = Visibility.Hidden;
            dgVehicles.Columns[1].Visibility = Visibility.Hidden;
            dgVehicles.Columns[2].Visibility = Visibility.Hidden;
            dgVehicles.Columns[3].Visibility = Visibility.Hidden;
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (vehicles != null)
                {
                    vehicles.Export();

                    MessageBox.Show("Export Complete!", "Good news everyone!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
