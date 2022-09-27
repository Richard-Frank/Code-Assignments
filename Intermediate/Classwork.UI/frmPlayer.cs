using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork.UI
{
    public partial class frmPlayer : Form
    {

        //Can be used with a combo box.
        public enum enumPosition : int
        {
            RB = 0,
            QB = 1,
            MLB = 2,
            SS = 3,
            WS = 4,
            T = 5,
            K = 6,
            AirborneDefence = 7,
        }

        //
        public struct Player
        {
            public string DisplayLine { get; set; }
            public int UniformNumber { get; set; }
            public double Weight { get; set; }
            public double Hight { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public enumPosition Position { get; set; }

        }

        //Declare the generic list.
        List<Player> oPlayers;


        //Declare and Instantiate a generic list of ints
        //List<int> mynumbers = new List<int>();


        public frmPlayer()
        {
            InitializeComponent();
        }

        private void frmPlayer_Load(object sender, EventArgs e)
        {

        }

        private void btnMakePlayer_Click(object sender, EventArgs e)
        {
            // Instantiate a new object of a Player structure.
            Player oPlayer = new Player();
            //Player oPlayer; //This is a decleration - no object yet.


            // Set the field values.
            oPlayer.UniformNumber = 77;
            oPlayer.LastName = "Guy";
            oPlayer.FirstName = "Fuutball";
            oPlayer.Position = enumPosition.AirborneDefence;
            oPlayer.Weight = 155;
            oPlayer.Hight = 63;
            oPlayer.DisplayLine = oPlayer.FirstName + " " + oPlayer.LastName + 
                                  " : " + oPlayer.UniformNumber.ToString();

        }

        private void btnMakePlayers_Click(object sender, EventArgs e)
        {
            //Instantiate the generic list of players
            oPlayers = new List<Player>();


            //Make Guy Fuutball
            // Instantiate a new object of a Player structure.
            Player oPlayer = new Player();
            //Player oPlayer; //This is a decleration - no object yet.


            // Set the field values.
            oPlayer.UniformNumber = 77;
            oPlayer.LastName = "Fuutball";
            oPlayer.FirstName = "Guy";
            oPlayer.Position = enumPosition.AirborneDefence;
            oPlayer.Weight = 155;
            oPlayer.Hight = 63;
            oPlayer.DisplayLine = oPlayer.FirstName + " " + oPlayer.LastName +
                      " : " + oPlayer.UniformNumber.ToString();

            //Add to the group (Players List)
            oPlayers.Add(oPlayer);


            //Make Mason Crosby
            // Instantiate a new object of a Player structure.
            oPlayer = new Player();
            //Player oPlayer; //This is a decleration - no object yet.


            // Set the field values.
            oPlayer.UniformNumber = 2;
            oPlayer.LastName = "Crosby";
            oPlayer.FirstName = "Mason";
            oPlayer.Position = enumPosition.K;
            oPlayer.Weight = 207;
            oPlayer.Hight = 61;
            oPlayer.DisplayLine = oPlayer.FirstName + " " + oPlayer.LastName +
                      " : " + oPlayer.UniformNumber.ToString();

            //Add to the group (Players List)
            oPlayers.Add(oPlayer);

            //Bind the generic list to the data grid view.
            dvgPlayers.DataSource = oPlayers;

            //Bind the generic list to the list box.
            lstResults.DataSource = oPlayers;

            // Specify the property that will be shown (Last Name)
            lstResults.DisplayMember = "DisplayLine";

            //Specify the ID of the elements.
            lstResults.ValueMember = "UniformNumber";
        }
    }
}
