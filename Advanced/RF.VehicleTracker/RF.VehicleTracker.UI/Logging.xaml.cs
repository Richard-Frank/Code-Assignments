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

namespace RF.VehicleTracker.UI
{
    /// <summary>
    /// Interaction logic for Logging.xaml
    /// </summary>
    public partial class Logging : Window
    {
        //log4net appenders in app.config

        log4net.ILog log = log4net.LogManager.GetLogger("Utility.Logger");
        public Logging()
        {
            InitializeComponent();
        }

        private void btnLogIt_Click(object sender, RoutedEventArgs e)
        {
            if (log.IsWarnEnabled)
            {
                log.Warn(txtInfo.Text);
            }
        }
    }
}
