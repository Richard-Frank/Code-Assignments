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

namespace RF.DoSquareRoot
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
            //Create a containing grid.
            Grid grdControls = new Grid();

            //Remember to set names, otherwise the names are local only.
            grdControls.Name = "grdControls";
            //
            grdControls.Width = 610;
            grdControls.Height = 70;
            grdControls.HorizontalAlignment = HorizontalAlignment.Center;
            grdControls.VerticalAlignment = VerticalAlignment.Top;
            grdControls.Background = new SolidColorBrush(Colors.Aquamarine);

            grdMain.Children.Add(grdControls);
            grdMain.RegisterName(grdControls.Name, grdControls);

            //Add a new label to grdControls.
            Label lblBase = new Label();
            lblBase.Content = "Base:";
            lblBase.FontSize = 14;
            lblBase.Margin = new Thickness(65, 20, 0, 0); // Left, Top, Right, Bottom

            grdControls.Children.Add(lblBase);

            //Add a new text box
            TextBox txtBase = new TextBox();
            txtBase.Name = "txtBase";
            txtBase.Width = 120;
            txtBase.Height = 23;
            txtBase.FontSize = lblBase.FontSize;
            txtBase.Background = new SolidColorBrush(Colors.AliceBlue);
            txtBase.HorizontalAlignment = HorizontalAlignment.Left;
            txtBase.Margin = new Thickness(107, 0, 0, 0);

            grdControls.Children.Add(txtBase);

            //Register the name of the control so it can be called in a method.
            grdControls.RegisterName(txtBase.Name, txtBase);

            //Add a new Button
            Button btnGo = new Button();
            btnGo.Name = "btnGo";
            btnGo.Height = 25;
            btnGo.Width = 75;
            btnGo.FontSize = lblBase.FontSize;
            btnGo.Content = "Go!";
            btnGo.FontWeight = FontWeights.Bold;
            btnGo.HorizontalAlignment = HorizontalAlignment.Left;
            btnGo.Margin = new Thickness(txtBase.Margin.Left + txtBase.Width + 15, 0, 0, 0);

            grdControls.Children.Add(btnGo);

            //Delegate the Click event. (You can use tab to set up and create the event.)
            btnGo.Click += BtnGo_Click;

            Label lblStatus = new Label();
            lblStatus.Name = "lblStatus";
            lblStatus.FontSize = lblBase.FontSize;
            lblStatus.Foreground = new SolidColorBrush(Colors.Red);
            lblStatus.Margin = new Thickness(50, 45, 0, 0);
            grdControls.Children.Add(lblStatus);
            //Register the label because it will be used by an outside source, (Button_Click)
            grdControls.RegisterName(lblStatus.Name, lblStatus);


            Grid grdResults = new Grid();
            grdResults.Name = "grdResults";
            grdResults.Width = grdControls.Width;
            grdResults.Height = grdMain.Height - grdControls.Height;
            grdResults.Visibility = Visibility.Hidden;
            grdResults.HorizontalAlignment = HorizontalAlignment.Left;
            grdResults.VerticalAlignment = VerticalAlignment.Top;
            grdResults.Margin = new Thickness(15, grdControls.Height, 0, 0);
            //grdResults.Background = new SolidColorBrush(Colors.HotPink);

            grdMain.Children.Add(grdResults);

            //Register the results grid.
            grdResults.RegisterName(grdResults.Name, grdResults);
        }

        private void BtnGo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Label lblStatus = (Label)grdMain.FindName("lblStatus");
                TextBox txtBase = (TextBox)grdMain.FindName("txtBase");
                Grid grdResults = (Grid)grdMain.FindName("grdResults");

                //Clear out any existing children. If you do not do this, you will create a big ol' memory leak.
                grdResults.Children.Clear();
                lblStatus.Content = "";

                grdResults.Visibility = Visibility.Visible;

                double dblBase;

                if (double.TryParse(txtBase.Text, out dblBase))
                {
                    for (int y = 0; y < 5; y++)
                    {
                        double dblResult = Math.Sqrt(dblBase);

                        Label lblDesc = new Label();
                        lblDesc.Height = 25;
                        lblDesc.Width = 75;
                        lblDesc.Foreground = new SolidColorBrush(Colors.White);
                        //lblDesc.Background = new SolidColorBrush(Colors.Chartreuse);
                        lblDesc.FontSize = 14;
                        lblDesc.HorizontalContentAlignment = HorizontalAlignment.Center;
                        lblDesc.HorizontalAlignment = HorizontalAlignment.Left;
                        lblDesc.VerticalAlignment = VerticalAlignment.Top;

                        lblDesc.Margin = new Thickness(175, y * lblDesc.Height, 0, 0);

                        lblDesc.Content = dblBase.ToString() + " ^ .5";

                        grdResults.Children.Add(lblDesc);

                        Label lblResult = new Label();
                        lblResult.Height = 25;
                        lblResult.Width = 75;
                        lblResult.Foreground = new SolidColorBrush(Colors.Wheat);
                        //lblResult.Background = new SolidColorBrush(Colors.Chartreuse);
                        lblResult.FontSize = 14;
                        lblResult.HorizontalContentAlignment = HorizontalAlignment.Center;
                        lblResult.HorizontalAlignment = HorizontalAlignment.Left;
                        lblResult.VerticalAlignment = VerticalAlignment.Top;

                        lblResult.Margin = new Thickness(lblDesc.Margin.Left + lblDesc.Width + 15, lblDesc.Margin.Top, 0, 0);

                        lblResult.Content = dblResult.ToString("n3");

                        grdResults.Children.Add(lblResult);

                        dblBase++;
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
            Grid grdControls = (Grid)this.grdMain.FindName("grdControls");

            if (grdControls != null)
             grdControls.Width = this.Width; 
        }
    }
}
