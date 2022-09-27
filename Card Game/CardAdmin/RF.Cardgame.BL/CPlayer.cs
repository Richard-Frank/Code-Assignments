using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF.Cardgame.PL;   

namespace RF.Cardgame.BL
{
    public class CPlayer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }


        public CPlayer()
        { }

        // overloaded constructor for login
        public CPlayer(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }
        

        public CPlayer(Guid id)
        {
            this.Id = id;
        }
        // overloaded constructor with all properties
        public CPlayer(Guid id, string name, string password, int wins, int losses)
        {
            this.Id = id;
            this.Name = name;
            this.Password = password;
            this.Wins = wins;
            this.Losses = losses;
        }

        // insert method
        public void Insert()
        {
            try
            {
                // data context
                CardGameDataContext oDc = new CardGameDataContext();

                tblPlayer player = new tblPlayer();
                player.Id = Guid.NewGuid();
                player.Name = this.Name;
                player.Password = this.Password;
                player.Wins = this.Wins;
                player.Losses = this.Losses;
                

                this.Id = player.Id;

                oDc.tblPlayers.InsertOnSubmit(player);
                oDc.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // update method
        public void Update()
        {
            try
            {
                // data context
                CardGameDataContext oDc = new CardGameDataContext();

                var player = oDc.tblPlayers.Where(p => p.Id == Id).FirstOrDefault();

                if (player != null)
                {
                    player.Id = this.Id;
                    player.Name= this.Name;
                    player.Password = this.Password;
                    player.Wins = this.Wins;
                    player.Losses = this.Losses;
                    oDc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // delete method
        public void Delete()
        {
            try
            {
                // data context
                CardGameDataContext oDc = new CardGameDataContext();

                var player = oDc.tblPlayers.Where(p => p.Id == Id).FirstOrDefault();
                var playerDecks = oDc.tblPlayerDecks.Where(p => p.PlayerId == Id).ToList();

                if (player != null)
                {
                    foreach (var pdeck in playerDecks)
                    {
                        oDc.tblPlayerDecks.DeleteOnSubmit(pdeck);
                        oDc.SubmitChanges();
                    }

                    oDc.tblPlayers.DeleteOnSubmit(player);
                    //oDc.tblPlayerDecks.DeleteAllOnSubmit(playerDecks);
                    oDc.SubmitChanges();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // load by id
        public void LoadById()
        {
            try
            {
                // data context oDc
                CardGameDataContext oDc = new CardGameDataContext();

                var player = oDc.tblPlayers.Where(p => p.Id == Id).FirstOrDefault();

                // set the properties
                
                this.Name = player.Name;
                this.Password = player.Password;
                this.Wins = player.Wins.GetValueOrDefault();
                this.Losses = player.Losses.GetValueOrDefault();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Guid GetPlayerByName(string playerName)
        {
            CardGameDataContext oDc = new CardGameDataContext();

            tblPlayer otblPlayer = oDc.tblPlayers.FirstOrDefault(u => u.Name == playerName);

            try
            {
                if (otblPlayer != null)
                {
                    return Id = otblPlayer.Id;
                }
                else
                {
                    throw new Exception("Player not found.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // login and test
        public bool Login()
        {
            try
            {
                if (Name != string.Empty)
                {
                    if (Password != string.Empty)
                    {
                        // get the user info out of the database
                        CardGameDataContext oDc = new CardGameDataContext();

                        tblPlayer otblPlayer = oDc.tblPlayers.FirstOrDefault(u => u.Name == Name);

                        if (otblPlayer != null)
                        {
                            if (otblPlayer.Password == Password)
                            {
                                // successful login
                                Id = otblPlayer.Id;
                                Name = otblPlayer.Name;

                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        throw new Exception("Pasword needs to be set.");
                    }
                }
                else
                {
                    throw new Exception("Username needs to be set.");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }

    // make a list class
    public class CPlayerList : List<CPlayer>
    {
        // Load Method
        public void Load()
        {
            try
            {
                // data context
                CardGameDataContext oDc = new CardGameDataContext();

                var results = (from c in oDc.tblPlayers
                               select c).ToList();
                foreach (var player in results)
                {
                    CPlayer oPlayer = new CPlayer(player.Id, player.Name, player.Password, player.Wins.GetValueOrDefault(), 
                                                                                            player.Losses.GetValueOrDefault());
                    Add(oPlayer);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        

    }
}
