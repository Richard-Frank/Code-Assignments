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
using System.Diagnostics;
using Newtonsoft.Json;
using System.IO;

namespace RF.CardAdmin.UI
{
    /// <summary>
    /// Interaction logic for PlayerDashboard.xaml
    /// </summary>
    public partial class PlayerDashboard : Window
    {

        CPlayer player = new CPlayer();
        CDeck deck = new CDeck();
        List<CDeck> decks = new List<CDeck>();
        log4net.ILog log = log4net.LogManager.GetLogger("Utility.Logger");

        public PlayerDashboard()
        {
            InitializeComponent();

        }

        public PlayerDashboard(Guid id, string playername, string playerpass)
        {
            InitializeComponent();

            CardgameClient client = new CardgameClient();
            player = client.LoadPlayerById(id);
        }

        public void RefreshScreen()
        {
            try
            {
                decks = new List<CDeck>();

                CardgameClient client = new CardgameClient();
                decks = client.SPGetDecksByPlayer(player.Id);

                cboDecks.ItemsSource = null;
                cboDecks.ItemsSource = decks;
                cboDecks.DisplayMemberPath = "Name";
                cboDecks.SelectedValuePath = "Id";

                lblWins.Content = "Wins: " + player.Wins;
                lblLosses.Content = "Losses: " + player.Losses;
                lblPlayerName.Content = "Player Name: " + player.Name;

                client.Close();
                client = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                if (log.IsWarnEnabled == true)
                {
                    log4net.LogicalThreadContext.Properties["ErrUser"] = player.Name;
                    log.Warn(ex.Message);
                }
            }

        }

        private void btnCreateDeck_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                deck.Id = Guid.NewGuid();
                CreateDeck ocd = new CreateDeck(player.Id);
                //this.Hide();
                ocd.ShowDialog();
                RefreshScreen();
                //this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                if (log.IsWarnEnabled == true)
                {
                    log4net.LogicalThreadContext.Properties["ErrUser"] = player.Name;
                    log.Warn(ex.Message);
                }
            }
            /*
            try
            {
                CardgameClient client = new CardgameClient();
                client.InsertDeck("Newdeck" + decks.Count.ToString(), player.Id);

                client.Close();
                client = null;
                RefreshScreen();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "Error!");
            }
            */
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshScreen();
        }

        private void btnManageDeck_Click(object sender, RoutedEventArgs e)
        {
            if (cboDecks.SelectedIndex > -1)
            {
                try
                {
                    //If we are using multiple constructiors, we don't need multiple windows.
                    CreateDeck ocd = new CreateDeck(player.Id, deck.Id);
                    //this.Hide();
                    ocd.ShowDialog();
                    RefreshScreen();
                    //this.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                    if (log.IsWarnEnabled == true)
                    {
                        log4net.LogicalThreadContext.Properties["ErrUser"] = player.Name;
                        log.Warn(ex.Message);
                    }
                }
            }

            else
            {
                MessageBox.Show("Please select a deck to manage, or click 'Create Deck' to create new.", "Oops.");
            }
        }

        private void cboDecks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (cboDecks.SelectedIndex > -1)
                {
                    deck = decks[cboDecks.SelectedIndex];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                if (log.IsWarnEnabled == true)
                {
                    log4net.LogicalThreadContext.Properties["ErrUser"] = player.Name;
                    log.Warn(ex.Message);
                }
            }
        }

        private void btnDeleteDeck_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete " + deck.Name + "?", "Please confirm.", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    CardgameClient client = new CardgameClient();
                    client.DeleteDeck(deck.Id);
                    RefreshScreen();

                    client.Close();
                    client = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                if (log.IsWarnEnabled == true)
                {
                    log4net.LogicalThreadContext.Properties["ErrUser"] = player.Name;
                    log.Warn(ex.Message);
                }
            }
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Would you like to logout?", "Logout", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                //do no stuff

            }
            else
            {
                //do yes stuff
                this.Close();
            }
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            if (deck.Id != Guid.Empty)
            {
                try
                {
                    // serialize JSON directly to a file
                    using (StreamWriter file = File.CreateText(@"C:\TFS Projects\Unity Projects\RF.CardgameUnity\Assets\StreamingAssets\deckId.json"))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(file, deck.Id);
                    }
                    using (StreamWriter file = File.CreateText(@"C:\TFS Projects\Unity Projects\RF.CardgameUnity\Assets\StreamingAssets\playerId.json"))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(file, player.Id);
                    }

                    //Process.Start(@"C:\TFS Projects\Unity Projects\RF.CardgameUnity\CardGame.exe");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                    if (log.IsWarnEnabled == true)
                    {
                        log4net.LogicalThreadContext.Properties["ErrUser"] = player.Name;
                        log.Warn(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a deck to enter the game with.");
            }
        }
    }
}
