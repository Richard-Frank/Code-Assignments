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
//using RF.Cardgame.BL;
using RF.CardAdmin.UI.CardGameReference;

namespace RF.CardAdmin.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        log4net.ILog log = log4net.LogManager.GetLogger("Utility.Logger");

        public MainWindow()
        {
            InitializeComponent();
            lblDate.Content = DateTime.Now;
        }

        // when Login is clicked, check credentials and whether they are an admin or not, then login
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            CardgameClient client = new CardgameClient();
            bool validlogin = false;


            //Check to see if username is blank.
            if (txtUsername.Text != null && txtUsername.Text != "")
            {
                //Check to see if password is blank.
                if (txtPassword != null && txtPassword.Password != "")
                {
                    // check if admin login is checked
                    if ((bool)chkAdmin.IsChecked)
                    {
                        // try logging in as admin
                        try
                        {
                            validlogin = client.LoginAdmin(txtUsername.Text, txtPassword.Password.ToString());

                            if (validlogin == true)
                            {
                                
                                AdminDashboard oadminDash = new AdminDashboard(txtUsername.Text, txtPassword.Password.ToString());
                                this.Hide();
                                oadminDash.ShowDialog();
                                this.Show();
                                txtPassword.Password = "";
                            }

                            else
                            {
                                MessageBox.Show("Invalid Admin credentials.", "Error.");
                                txtUsername.Focus();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Incorrect Username or Password. Please try again.", "Error.");
                            MessageBox.Show(ex.Message);
                            if (log.IsWarnEnabled == true)
                            {
                                log.Warn(ex.Message);
                            }
                        }
                    }
                    else // it's not checked, so try logging in as a regular user
                    {
                        try
                        {
                            validlogin = client.LoginPlayer(txtUsername.Text, txtPassword.Password.ToString());
                            if (validlogin == true)
                            {
                                // This is to get the id associated with the players name and pass it to the player dashboard as a third argument
                                Guid id = client.GetPlayerByLogin(txtUsername.Text, txtPassword.Password.ToString());
                                if (id != Guid.Empty)
                                {
                                    PlayerDashboard oplayerDash = new PlayerDashboard(id, txtUsername.Text, txtPassword.Password.ToString());
                                    this.Hide();
                                    oplayerDash.ShowDialog();
                                    this.Show();
                                    txtPassword.Password = "";
                                }
                                else
                                {
                                    MessageBox.Show("Login error!", "Error!");
                                }

                            }

                            else
                            {
                                MessageBox.Show("Invalid Login credentials.", "Error.");
                                txtUsername.Focus();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Incorrect Username or Password. Please try again.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Password cannot be blank.", "Oops!");
                    txtPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Username cannot be blank.", "Oops!");
                txtUsername.Focus();
            }

            client.Close();
            client = null;
        }

        // check for blank P
        private void btnCreateUser_Click(object sender, RoutedEventArgs e)
        {

            CardgameClient client = new CardgameClient();
            try
            {
                // if the username isn't null, go down into the next branch
                if (txtUsername.Text != null && txtUsername.Text != "")
                {
                    // if the password isn't null, create the user
                    if (txtPassword.Password != null && txtPassword.Password != "")
                    {
                        if (client.LoginPlayer(txtUsername.Text, txtPassword.Password.ToString()) == false)
                        {
                            client.InsertPlayer(txtUsername.Text, txtPassword.Password.ToString());
                            MessageBox.Show("Player " + txtUsername.Text + " has been created. Logging in.", "Good news everyone!");
                            Guid id = client.GetPlayerByLogin(txtUsername.Text, txtPassword.Password.ToString());
                            PlayerDashboard oplayerDash = new PlayerDashboard(id, txtUsername.Text, txtPassword.Password.ToString());
                            log.Info("A player account has been created. Name: " + txtUsername.Name + " Password: " + txtPassword.Password.ToString());
                            oplayerDash.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("A player with this name has already been created.", "Sorry.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password cannot be blank", "Oops!");
                        txtPassword.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Username cannot be blank.", "Oops!");
                    txtUsername.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Error Creating User", "Error!");
                txtUsername.Focus();
            }

            client.Close();
            client = null;
        }
    }
}
