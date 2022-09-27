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
    /// Interaction logic for AdminManageCard.xaml
    /// </summary>
    public partial class AdminManageCard : Window
    {
        CCard Card = new CCard();
        CAdmin Admin = new CAdmin();
        bool isUpdate;

        log4net.ILog log = log4net.LogManager.GetLogger("Utility.Logger");

        public AdminManageCard()
        {
            InitializeComponent();
        }

        public AdminManageCard(string adminName, string adminPass)
        {
            InitializeComponent();
            btnInsertUpdate.Content = "Insert Card";
            isUpdate = false;
            this.Title = "Create Card";
            txtAttack.Text = "";
            txtHealth.Text = "";
            txtCost.Text = "";
            Admin.Name = adminName;
            Admin.Password = adminPass;
        }

        public AdminManageCard(CCard _card, string adminName, string adminPass)
        {
            InitializeComponent();
            btnInsertUpdate.Content = "Update Card";
            Card = _card;
            FillControls();
            isUpdate = true;
            this.Title = "Update";
            Admin.Name = adminName;
            Admin.Password = adminPass;
        }

        private void btnInsertUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
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

                        client.InsertCard(txtName.Text, attack, health, cost, Admin.Name, Admin.Password);
                        if (log.IsInfoEnabled == true)
                        {
                            log4net.LogicalThreadContext.Properties["ErrUser"] = Admin.Name;
                            log.Info("A new card has been created." + "Cardinfo: " + txtName.Text +
                                                                         " " + txtAttack.Text + " "
                                                                             + txtHealth.Text + " "                                                                             + txtCost.Text);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error!");
                        if (log.IsWarnEnabled == true)
                        {
                            log4net.LogicalThreadContext.Properties["ErrUser"] = Admin.Name;
                            log.Warn(ex.Message);
                        }
                    }
                }
                if (isUpdate == true)
                {
                    try
                    {
                        int.TryParse(txtAttack.Text, out attack);
                        int.TryParse(txtHealth.Text, out health);
                        int.TryParse(txtCost.Text, out cost);

                        client.UpdateCard(Card.Id, txtName.Text, attack, health, cost, Admin.Name, Admin.Password);
                        if (log.IsInfoEnabled == true)
                        {
                            log4net.LogicalThreadContext.Properties["ErrUser"] = Admin.Name;
                            log.Info("The card: " + Card.Name + ". Has been updated. " + "Cardinfo: " + txtName.Text +
                                                                         " " + txtAttack.Text + " "
                                                                             + txtHealth.Text + " "
                                                                             + txtCost.Text);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error!");
                        if (log.IsWarnEnabled == true)
                        {
                            log4net.LogicalThreadContext.Properties["ErrUser"] = Admin.Name;
                            log.Warn(ex.Message);
                        }

                    }

                }

                client.Close();
                client = null;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                if (log.IsWarnEnabled == true)
                {
                    log4net.LogicalThreadContext.Properties["ErrUser"] = Admin.Name;
                    log.Warn(ex.Message);
                }
            }

        }

        private void FillControls()
        {
            try
            {
                if (Card != null)
                {
                    txtName.Text = Card.Name;
                    txtAttack.Text = Card.Attack.ToString();
                    txtHealth.Text = Card.Health.ToString();
                    txtCost.Text = Card.Cost.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                if (log.IsWarnEnabled == true)
                {
                    log4net.LogicalThreadContext.Properties["ErrUser"] = Admin.Name;
                    log.Warn(ex.Message);
                }
            }

        }
    }
}
