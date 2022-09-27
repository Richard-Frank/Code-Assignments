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
    /// Interaction logic for MaintainAttributes.xaml
    /// </summary>
    public partial class MaintainAttributes : Window
    {
        ScreenMode mode;
        CColorList colors;
        CMakeList makes;
        CModelList models;

        CColor color;
        CMake make;
        CModel model;
        public MaintainAttributes(ScreenMode _mode)
        {
            InitializeComponent();

            mode = _mode;

            RefreshScreen();

            cboAttribute.SelectedValuePath = "Id";
            cboAttribute.DisplayMemberPath = "Description";

            lblAttribute.Content = mode.ToString() + "s:";
            this.Title = "Maintain " + mode.ToString() + "s:";
        }

        private void RefreshScreen()
        {
            //Switch Tab+Tab insert switch, and press down for auto-populate.
            switch (mode)
            {
                case ScreenMode.Color:
                    colors = new CColorList();
                    colors.Load();

                    //Null to prevent load errors.
                    cboAttribute.ItemsSource = null;
                    cboAttribute.ItemsSource = colors;

                    break;
                case ScreenMode.Make:
                    makes = new CMakeList();
                    makes.Load();

                    cboAttribute.ItemsSource = null;
                    cboAttribute.ItemsSource = makes;
                    break;
                case ScreenMode.Model:
                    models = new CModelList();
                    models.Load();

                    cboAttribute.ItemsSource = null;
                    cboAttribute.ItemsSource = models;
                    break;
                default:
                    break;
            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            switch (mode)
            {
                case ScreenMode.Color:
                    color = new CColor();
                    color.Description = txtAttribute.Text;
                    color.Insert();
                    break;
                case ScreenMode.Make:
                    make = new CMake();
                    make.Description = txtAttribute.Text;
                    make.Insert();
                    break;
                case ScreenMode.Model:
                    model = new CModel();
                    model.Description = txtAttribute.Text;
                    model.Insert();
                    break;
                default:
                    break;
            }
            RefreshScreen();
        }

        private void cboAttribute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (mode)
            {
                case ScreenMode.Color:
                    color = colors[cboAttribute.SelectedIndex];
                    txtAttribute.Text = color.Description;
                    break;
                case ScreenMode.Make:
                    make = makes[cboAttribute.SelectedIndex];
                    txtAttribute.Text = make.Description;
                    break;
                case ScreenMode.Model:
                    model = models[cboAttribute.SelectedIndex];
                    txtAttribute.Text = model.Description;
                    break;
                default:
                    break;
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            switch (mode)
            {
                case ScreenMode.Color:
                    color.Delete();
                    break;
                case ScreenMode.Make:
                    make.Delete();
                    break;
                case ScreenMode.Model:
                    model.Delete();
                    break;
                default:
                    break;
            }
            RefreshScreen();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            switch (mode)
            {
                case ScreenMode.Color:
                    color.Description = txtAttribute.Text;
                    color.Update();
                    break;
                case ScreenMode.Make:
                    make.Description = txtAttribute.Text;
                    make.Update();
                    break;
                case ScreenMode.Model:
                    model.Description = txtAttribute.Text;
                    model.Update();
                    break;
                default:
                    break;
            }
            RefreshScreen();
        }
    }
}
