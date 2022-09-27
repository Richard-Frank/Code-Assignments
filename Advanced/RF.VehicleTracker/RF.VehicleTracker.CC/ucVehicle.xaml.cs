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
using RF.VehicleTracker.BL;

namespace RF.VehicleTracker.CC
{
    /// <summary>
    /// Interaction logic for ucVehicle.xaml
    /// </summary>
    public partial class ucVehicle : UserControl
    {
        CVehicle vehicle;
        CColorList colors;
        CMakeList makes;
        CModelList models;

        public ucVehicle()
        {
            InitializeComponent();
            btnUpdate.Visibility = Visibility.Hidden;
            btnDelete.Visibility = Visibility.Hidden;
            FillControls();
        }

        public ucVehicle(CVehicle _vehicle)
        {
            InitializeComponent();
            vehicle = _vehicle;
            btnInsert.Visibility = Visibility.Hidden;
            FillControls();
        }

        private void FillControls()
        {
            colors = new CColorList();
            makes = new CMakeList();
            models = new CModelList();

            colors.Load();
            makes.Load();
            models.Load();

            cboColor.ItemsSource = null;
            cboColor.ItemsSource = colors;
            cboColor.DisplayMemberPath = "Description";
            cboColor.SelectedValuePath = "Id";

            cboMake.ItemsSource = null;
            cboMake.ItemsSource = makes;
            cboMake.DisplayMemberPath = "Description";
            cboMake.SelectedValuePath = "Id";

            cboModel.ItemsSource = null;
            cboModel.ItemsSource = models;
            cboModel.DisplayMemberPath = "Description";
            cboModel.SelectedValuePath = "Id";

            if (vehicle != null)
            {
                cboColor.SelectedValue = vehicle.ColorId;
                cboMake.SelectedValue = vehicle.MakeId;
                cboModel.SelectedValue = vehicle.ModelId;
                txtVIN.Text = vehicle.VIN;
                dpkYear.SelectedDate = new DateTime(vehicle.Year, 1, 1);
            }
        }

        private void PopulateVehicle()
        {
            vehicle.ColorId = (Guid)cboColor.SelectedValue;
            vehicle.MakeId = (Guid)cboMake.SelectedValue;
            vehicle.ModelId = (Guid)cboModel.SelectedValue;
            vehicle.VIN = txtVIN.Text;
            vehicle.Year = dpkYear.SelectedDate.Value.Year;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PopulateVehicle();
                vehicle.Update();
                Window.GetWindow(this.Parent).Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                vehicle = new CVehicle();
                PopulateVehicle();
                vehicle.Insert();
                Window.GetWindow(this.Parent).Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (vehicle != null)
                {
                    vehicle.Delete();
                    Window.GetWindow(this.Parent).Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
