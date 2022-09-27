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
using RF.CardAdmin.UI.CardGameReference;
using RF.Utilities.Exporter;

namespace RF.CardAdmin.UI
{
    /// <summary>
    /// Interaction logic for AdminDashboard.xaml
    /// </summary>
    public partial class AdminDashboard : Window
    {

        CAdmin admin = new CAdmin();
        CCard card = new CCard();
        List<CCard> cards = new List<CCard>();
        List<CPlayer> players = new List<CPlayer>();

        log4net.ILog log = log4net.LogManager.GetLogger("Utility.Logger");

        public AdminDashboard()
        {
            InitializeComponent();
        }

        public AdminDashboard(string adminName, string adminPass)
        {
            InitializeComponent();

            admin.Name = adminName;
            admin.Password = adminPass;
        }

        public void LoadCards()
        {
            try
            {
                cards = new List<CCard>();
                CardgameClient client = new CardgameClient();
                cards = client.LoadCards();
                cards.Sort((x, y) => string.Compare(x.Name, y.Name));

                dgData.ItemsSource = null;
                dgData.ItemsSource = cards;

                dgData.Columns[0].Visibility = Visibility.Hidden;
                dgData.Columns[4].Visibility = Visibility.Hidden;

                client.Close();
                client = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                if (log.IsWarnEnabled == true)
                {
                    log4net.LogicalThreadContext.Properties["ErrUser"] = admin.Name;
                    log.Warn(ex.Message);
                }
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CardgameClient client = new CardgameClient();
            players = client.LoadPlayers();

            LoadCards();
            lblAdminName.Content = "Logged in as: " + admin.Name;

            client.Close();
            client = null;
        }

        private void btnCreateCard_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AdminManageCard amc = new AdminManageCard(admin.Name, admin.Password);
                amc.ShowDialog();
                LoadCards();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                if (log.IsWarnEnabled == true)
                {
                    log4net.LogicalThreadContext.Properties["ErrUser"] = admin.Name;
                    log.Warn(ex.Message);
                }
            }

        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void btnDeleteCard_Click(object sender, RoutedEventArgs e)
        {
            if (dgData.SelectedIndex > -1)
            {
                card = cards[dgData.SelectedIndex];

                if (MessageBox.Show("Are you sure you want to delete " + card.Name + "?", "Please confirm.", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    try
                    {

                        CardgameClient client = new CardgameClient();
                        client.DeleteCard(admin.Name, admin.Password, card.Id);

                        if (log.IsInfoEnabled == true)
                        {
                            log4net.LogicalThreadContext.Properties["ErrUser"] = admin.Name;
                            log.Info("The card: " + card.Name + ". Has been deleted." + "Cardinfo: " + card.Name +
                                                                                                 " " + card.Attack.ToString() + " "
                                                                                                     + card.Health.ToString() + " "
                                                                                                     + card.Cost.ToString());
                        }

                        LoadCards();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error!");
                        if (log.IsWarnEnabled == true)
                        {
                            log4net.LogicalThreadContext.Properties["ErrUser"] = admin.Name;
                            log.Warn(ex.Message);
                        }
                    }

                }
                else
                {

                }
            }
         
        }

        private void cboCards_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                card = cards[dgData.SelectedIndex];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                if (log.IsWarnEnabled == true)
                {
                    log4net.LogicalThreadContext.Properties["ErrUser"] = admin.Name;
                    log.Warn(ex.Message);
                }
 
            }

        }

        private void btnManageCard_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                card = cards[dgData.SelectedIndex];
                AdminManageCard amc = new AdminManageCard(card, admin.Name, admin.Password);
                amc.ShowDialog();
                LoadCards();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                if (log.IsWarnEnabled == true)
                {
                    log4net.LogicalThreadContext.Properties["ErrUser"] = admin.Name;
                    log.Warn(ex.Message);
                }
            }

        }

        private void btnExportCards_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Added the export in the button to prevent a reference to the BL because the SL cannot handle Excel.
                CardgameClient client = new CardgameClient();
                bool adminlogcheck = client.LoginAdmin(admin.Name, admin.Password);

                if (adminlogcheck == true)
                {
                    string[,] exportCards = new string[cards.Count + 1, 4];

                    exportCards[0, 0] = "Name";
                    exportCards[0, 1] = "Attack";
                    exportCards[0, 2] = "Health";
                    exportCards[0, 3] = "Cost";

                    for (int iCnt = 1; iCnt < cards.Count + 1; iCnt++)
                    {
                        CCard c = cards[iCnt - 1];
                        exportCards[iCnt, 0] = c.Name;
                        exportCards[iCnt, 1] = c.Attack.ToString();
                        exportCards[iCnt, 2] = c.Health.ToString();
                        exportCards[iCnt, 3] = c.Cost.ToString();
                    }

                    CExporter.Export("Cards.xlsx", exportCards);
                }

                client.Close();
                client = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                if (log.IsWarnEnabled == true)
                {
                    log4net.LogicalThreadContext.Properties["ErrUser"] = admin.Name;
                    log.Warn(ex.Message);
                }
            }
        }

        private void btnExportPlayers_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Added the export in the button to prevent a reference to the BL because the SL cannot handle Excel.
                CardgameClient client = new CardgameClient();
                bool adminlogcheck = client.LoginAdmin(admin.Name, admin.Password);

                if (adminlogcheck == true)
                {
                    string[,] exportPlayers = new string[players.Count + 1, 4];

                    exportPlayers[0, 0] = "Name";
                    exportPlayers[0, 1] = "Password";
                    exportPlayers[0, 2] = "Wins";
                    exportPlayers[0, 3] = "Losses";

                    for (int iCnt = 1; iCnt < players.Count + 1; iCnt++)
                    {
                        CPlayer p = players[iCnt - 1];
                        exportPlayers[iCnt, 0] = p.Name;
                        exportPlayers[iCnt, 1] = p.Password;
                        exportPlayers[iCnt, 2] = p.Wins.ToString();
                        exportPlayers[iCnt, 3] = p.Losses.ToString();
                    }

                    CExporter.Export("Players.xlsx", exportPlayers);
                }

                client.Close();
                client = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                if (log.IsWarnEnabled == true)
                {
                    log4net.LogicalThreadContext.Properties["ErrUser"] = admin.Name;
                    log.Warn(ex.Message);
                }
            }
        }
    }
}
