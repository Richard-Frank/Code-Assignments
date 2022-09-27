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

namespace RF.CardAdmin.UI
{
    /// <summary>
    /// Interaction logic for CreateDeck.xaml
    /// </summary>
    public partial class CreateDeck : Window
    {
        List<CCard> gameCards = new List<CCard>();
        List<CCard> DeckCards = new List<CCard>();
        CCard gameCard = new CCard();
        CCard deckCard = new CCard();
        CPlayer Player = new CPlayer();
        CDeck Deck = new CDeck();
        bool saveClicked;
        bool isNewDeck;

        log4net.ILog log = log4net.LogManager.GetLogger("Utility.Logger");

        public CreateDeck()
        {
            InitializeComponent();
        }

        public CreateDeck(Guid playerId)
        {
            InitializeComponent();
            Player.Id = playerId;
            //Deck.Id = Guid.Empty;
            isNewDeck = true;
        }

        public CreateDeck(Guid playerId, Guid deckId)
        {
            InitializeComponent();
            Player.Id = playerId;
            Deck.Id = deckId;
            isNewDeck = false;
            lblCreateDeck.Content = "Manage Deck";
            this.Title = "Manage Deck";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtDeckName.Text != null && txtDeckName.Text != "")
                {
                    CardgameClient client = new CardgameClient();

                    if (isNewDeck == true)
                    {
                        client.AssignAndInsert(txtDeckName.Text, Player.Id, DeckCards);
                    }
                    else
                    {
                        client.AssignCards(Deck.Id, DeckCards);
                    }

                    client.Close();
                    client = null;
                    this.Close();

                    saveClicked = true;
                }
                else
                {
                    MessageBox.Show("You need to enter a name for your deck.", "Blank Deck Name");
                    txtDeckName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                if (log.IsWarnEnabled == true)
                {
                    log4net.LogicalThreadContext.Properties["ErrUser"] = Player.Name;
                    log.Warn(ex.Message);
                }
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CardgameClient client = new CardgameClient();
            gameCards = client.LoadCards();

            if (Deck.Id != Guid.Empty)
            {
                Deck = client.LoadDeckById(Deck.Id);
                DeckCards = client.SPGetCardsByDeck(Deck.Id);
                txtDeckName.Text = Deck.Name;
            }

            dgCards.ItemsSource = null;
            dgCards.ItemsSource = gameCards;

            dgDeck.ItemsSource = null;
            dgDeck.ItemsSource = DeckCards;

            client.Close();
            client = null;
            saveClicked = false;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dgCards.SelectedIndex > -1)
                {
                    DeckCards.Add(gameCards[dgCards.SelectedIndex]);

                    dgDeck.ItemsSource = null;
                    dgDeck.ItemsSource = DeckCards;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                if (log.IsWarnEnabled == true)
                {
                    log4net.LogicalThreadContext.Properties["ErrUser"] = Player.Name;
                    log.Warn(ex.Message);
                }
            }

        }
        

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dgDeck.SelectedIndex > -1)
                {
                    DeckCards.Remove(DeckCards[dgDeck.SelectedIndex]);

                    dgDeck.ItemsSource = null;
                    dgDeck.ItemsSource = DeckCards;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                if (log.IsWarnEnabled == true)
                {
                    log4net.LogicalThreadContext.Properties["ErrUser"] = Player.Name;
                    log.Warn(ex.Message);
                }
            }

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (!saveClicked)
            {

                if (MessageBox.Show("Go back without saving changes?", "Warning: Unsaved Deck", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    //do no stuff
                    
                }
                else
                {
                    //do yes stuff
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        
        private void dgCards_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.Column.Header.ToString() == "Name")
            {
                //e.Cancel = true;   // For not to include 
                e.Column.IsReadOnly = true; // Makes the column as read only
            }
            if (e.Column.Header.ToString() == "Attack")
            {
                // e.Cancel = true;   // For not to include 
                e.Column.IsReadOnly = true; // Makes the column as read only
            }
            if (e.Column.Header.ToString() == "Cost")
            {
                // e.Cancel = true;   // For not to include 
                e.Column.IsReadOnly = true; // Makes the column as read only
            }
            if (e.Column.Header.ToString() == "Health")
            {
                //e.Cancel = true;   // For not to include 
                e.Column.IsReadOnly = true; // Makes the column as read only
            }
            if (e.Column.Header.ToString() == "Id")
            {
                e.Cancel = true;   // For not to include 
                //e.Column.IsReadOnly = true; // Makes the column as read only
            }
            if (e.Column.Header.ToString() == "ExtensionData")
            {
                e.Cancel = true;   // For not to include 
                //e.Column.IsReadOnly = true; // Makes the column as read only
            }
            
        }
        
        private void dgDeck_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.Column.Header.ToString() == "Name")
            {
                //e.Cancel = true;   // For not to include 
                e.Column.IsReadOnly = true; // Makes the column as read only
            }
            if (e.Column.Header.ToString() == "Attack")
            {
                // e.Cancel = true;   // For not to include 
                e.Column.IsReadOnly = true; // Makes the column as read only
            }
            if (e.Column.Header.ToString() == "Cost")
            {
                // e.Cancel = true;   // For not to include 
                e.Column.IsReadOnly = true; // Makes the column as read only
            }
            if (e.Column.Header.ToString() == "Health")
            {
                //e.Cancel = true;   // For not to include 
                e.Column.IsReadOnly = true; // Makes the column as read only
            }
            if (e.Column.Header.ToString() == "Id")
            {
                e.Cancel = true;   // For not to include 
                //e.Column.IsReadOnly = true; // Makes the column as read only
            }
            if (e.Column.Header.ToString() == "ExtensionData")
            {
                e.Cancel = true;   // For not to include 
                //e.Column.IsReadOnly = true; // Makes the column as read only
            }
        }

        private void dgCards_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (dgCards.SelectedIndex > -1)
                {
                    gameCard = gameCards[dgCards.SelectedIndex];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                if (log.IsWarnEnabled == true)
                {
                    log4net.LogicalThreadContext.Properties["ErrUser"] = Player.Name;
                    log.Warn(ex.Message);
                }
            }

        }

        private void dgDeck_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (dgDeck.SelectedIndex > -1)
                {
                    deckCard = DeckCards[dgDeck.SelectedIndex];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                if (log.IsWarnEnabled == true)
                {
                    log4net.LogicalThreadContext.Properties["ErrUser"] = Player.Name;
                    log.Warn(ex.Message);
                }
            }
        }
    }
}
