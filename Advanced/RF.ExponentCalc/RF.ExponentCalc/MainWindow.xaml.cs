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

namespace RF.ExponentCalc
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //Create a grid for input.
            Grid grdControls = new Grid();

            grdControls.Name = "grdControls";

            grdControls.Width = 610;
            grdControls.Height = 70;
            grdControls.HorizontalAlignment = HorizontalAlignment.Center;
            grdControls.VerticalAlignment = VerticalAlignment.Top;
            grdControls.Background = new SolidColorBrush(Colors.Honeydew);

            grdMain.Children.Add(grdControls);
            grdMain.RegisterName(grdControls.Name, grdControls);

            //Add a new text box for base input.
            TextBox txtBase = new TextBox();
            txtBase.Name = "txtBase";
            txtBase.Width = 120;
            txtBase.Height = 23;
            txtBase.FontSize = 14;
            txtBase.HorizontalAlignment = HorizontalAlignment.Left;
            txtBase.Margin = new Thickness(110, 0, 0, 0); // Left, Top, Right, Bottom

            grdControls.Children.Add(txtBase);

            //Add a new label for base.
            Label lblBase = new Label();
            lblBase.Content = "Base:";
            lblBase.FontSize = txtBase.FontSize;
            lblBase.Margin = new Thickness(65, 20, 0, 0); // Left, Top, Right, Bottom

            grdControls.Children.Add(lblBase);

            //Add a new label for exponent.
            Label lblExpo = new Label();
            lblExpo.Content = "Exponent:";
            lblExpo.FontSize = txtBase.FontSize;
            lblExpo.Margin = new Thickness(txtBase.Margin.Left + txtBase.Width + 15, 20, 0, 0); // Left, Top, Right, Bottom

            grdControls.Children.Add(lblExpo);

            //Add a new text box for exponent input.
            TextBox txtExpo = new TextBox();
            txtExpo.Name = "txtExpo";
            txtExpo.Width = 120;
            txtExpo.Height = 23;
            txtExpo.FontSize = txtBase.FontSize;
            txtExpo.HorizontalAlignment = HorizontalAlignment.Left;
            txtExpo.Margin = new Thickness(lblExpo.Margin.Left + 75, 0, 0, 0); // Left, Top, Right, Bottom
            
            grdControls.Children.Add(txtExpo);

            //Register the name of the textboxes.
            grdControls.RegisterName(txtBase.Name, txtBase);
            grdControls.RegisterName(txtExpo.Name, txtExpo);
            
            //Add a new Button
            Button btnCalc = new Button();
            btnCalc.Name = "btnCalc";
            btnCalc.Height = 25;
            btnCalc.Width = 75;
            btnCalc.FontSize = lblBase.FontSize;
            btnCalc.Content = "Calculate";
            btnCalc.HorizontalAlignment = HorizontalAlignment.Left;
            btnCalc.Margin = new Thickness(txtExpo.Margin.Left + txtExpo.Width + 20, 0, 0, 0); // Left, Top, Right, Bottom

            grdControls.Children.Add(btnCalc);

            //Delegate the Click event.
            btnCalc.Click += BtnCalc_Click;

            Label lblStatus = new Label();
            lblStatus.Name = "lblStatus";
            lblStatus.FontSize = lblBase.FontSize;
            lblStatus.Foreground = new SolidColorBrush(Colors.Red);
            lblStatus.Margin = new Thickness(50, 45, 0, 0); // Left, Top, Right, Bottom
            grdControls.Children.Add(lblStatus);
            //Register lblStatus.
            grdControls.RegisterName(lblStatus.Name, lblStatus);


            Grid grdResults = new Grid();
            grdResults.Name = "grdResults";
            grdResults.Width = grdControls.Width;
            grdResults.Height = grdMain.Height - grdControls.Height;
            grdResults.Visibility = Visibility.Hidden;
            grdResults.HorizontalAlignment = HorizontalAlignment.Left;
            grdResults.VerticalAlignment = VerticalAlignment.Top;
            grdResults.Margin = new Thickness(15, grdControls.Height + 10, 0, 0); // Left, Top, Right, Bottom
            //grdResults.Background = new SolidColorBrush(Colors.HotPink);

            grdMain.Children.Add(grdResults);

            //Register the results grid.
            grdResults.RegisterName(grdResults.Name, grdResults);

            txtBase.Focus();
        }

        private void BtnCalc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Label lblStatus = (Label)grdMain.FindName("lblStatus");
                TextBox txtBase = (TextBox)grdMain.FindName("txtBase");
                TextBox txtExpo = (TextBox)grdMain.FindName("txtExpo");
                Grid grdResults = (Grid)grdMain.FindName("grdResults");

                //Clear out any existing children.
                grdResults.Children.Clear();
                lblStatus.Content = "";

                grdResults.Visibility = Visibility.Visible;

                double dblBase;
                double dblExpo;

                if (double.TryParse(txtBase.Text, out dblBase) && (double.TryParse(txtExpo.Text, out dblExpo)))
                {
                    for (int y = 0; y < 3; y++)
                    {
                        for (int x = 0; x < 3; x++)
                        {
                            double dblResult = Math.Pow(dblBase, dblExpo);

                            Grid grdMath = new Grid();
                            grdMath.Name = "grdMath";
                            grdMath.Width = 220;
                            grdMath.Height = grdMain.Height - 70;
                            grdMath.Visibility = Visibility.Visible;
                            grdMath.HorizontalAlignment = HorizontalAlignment.Left;
                            grdMath.VerticalAlignment = VerticalAlignment.Top;
                            //grdMath.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            grdMath.Margin = new Thickness(200 * x, 40 * y, 0, 0);

                            grdResults.Children.Add(grdMath);


                            Label lblBase = new Label();
                            lblBase.Height = 30;
                            lblBase.Width = 75;
                            lblBase.Foreground = new SolidColorBrush(Colors.Black);
                            lblBase.Background = new SolidColorBrush(Colors.White);
                            lblBase.FontSize = 13;
                            lblBase.HorizontalContentAlignment = HorizontalAlignment.Center;
                            lblBase.HorizontalAlignment = HorizontalAlignment.Left;
                            lblBase.VerticalAlignment = VerticalAlignment.Top;
                            lblBase.BorderBrush = Brushes.Black;
                            lblBase.BorderThickness = new Thickness(1);
    
                            lblBase.Margin = new Thickness(0, 0, 0, 0); // LTRB

                            lblBase.Content = dblBase.ToString() + " ^ " + dblExpo;

                            grdMath.Children.Add(lblBase);

                            Label lblResult = new Label();
                            lblResult.Height = 30;
                            lblResult.Width = 80;
                            lblResult.Foreground = new SolidColorBrush(Colors.Black);
                            lblResult.Background = new SolidColorBrush(Colors.White);
                            lblResult.FontSize = 13;
                            lblResult.HorizontalContentAlignment = HorizontalAlignment.Center;
                            lblResult.HorizontalAlignment = HorizontalAlignment.Left;
                            lblResult.VerticalAlignment = VerticalAlignment.Top;
                            lblResult.BorderBrush = Brushes.Black;
                            lblResult.BorderThickness = new Thickness(1);

                            lblResult.Margin = new Thickness(75, 0, 0, 0); // LTRB

                            lblResult.Content = dblResult.ToString();

                            grdMath.Children.Add(lblResult);

                            dblExpo++;
                        }
                    }

                }
                else
                {//Bad Input
                    txtBase.Focus();
                    txtBase.SelectAll();

                    lblStatus.Content = "Please enter a number.";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //Grid grdControls = (Grid)this.grdMain.FindName("grdControls");

            //if (grdControls != null)
                //grdControls.Width = this.Width;

        }
    }
}
