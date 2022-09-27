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
using RF.Cardgame.CCL.CardgameRefCC;

namespace RF.Cardgame.CCL
{
    /// <summary>
    /// Interaction logic for ManageCard.xaml
    /// </summary>
    public partial class ManageCard : UserControl
    {
        CCard Card = new CCard();
        bool isUpdate;

        public ManageCard()
        {
            InitializeComponent();
            btnInsertUpdate.Content = "Insert Card";
            isUpdate = false;
        }

        public ManageCard(CCard _card)
        {
            InitializeComponent();
            btnInsertUpdate.Content = "Update Card";
            Card = _card;
            FillControls();
            isUpdate = true;
        }

        private void btnInsertUpdate_Click(object sender, RoutedEventArgs e)
        {
            CardgameClient client = new CardgameClient();
            int attack;
            int health;
            int cost;

            if (isUpdate == false)
            {
                try
                {
                    int.TryParse(txtAttack.Text, out attack);
                    int.TryParse(txtHealth.Text, out health);
                    int.TryParse(txtCost.Text, out cost);

                    client.InsertCard(txtName.Text, attack, health, cost);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                }
            }
            if (isUpdate == true)
            {
                int.TryParse(txtAttack.Text, out attack);
                int.TryParse(txtHealth.Text, out health);
                int.TryParse(txtCost.Text, out cost);

                client.UpdateCard(Card.Id, txtName.Text, attack, health, cost);
            }

            client.Close();
            client = null;
            Window.GetWindow(this.Parent).Close();
        }

        private void FillControls()
        {
            if (Card != null)
            {
                txtName.Text = Card.Name;
                txtAttack.Text = Card.Attack.ToString();
                txtHealth.Text = Card.Health.ToString();
                txtCost.Text = Card.Cost.ToString();
            }
        }
    }
}
