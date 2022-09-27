using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace RF.Cardgame.PL.Test
{
    [TestClass]
    public class utPlayers
    {
        [TestMethod]
        public void SelectTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            List<tblPlayer> playerlist = (from c in oDc.tblPlayers select c).ToList();

            Assert.AreEqual(1, playerlist.Count);
        }

        [TestMethod]
        public void InsertTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            List<tblPlayer> Oldplayers = (from p in oDc.tblPlayers select p).ToList();

            tblPlayer newplayer = new tblPlayer();

            newplayer.Id = Guid.NewGuid();
            newplayer.Name = "PL.Testplayer";
            newplayer.Password = "PLTEST";
            newplayer.Wins = 0;
            newplayer.Losses = 1000;

            oDc.tblPlayers.InsertOnSubmit(newplayer);

            oDc.SubmitChanges();

            tblPlayer playercard = (from p in oDc.tblPlayers
                                 where p.Name == "PL.Testplayer"
                                 select p).FirstOrDefault();

            List<tblPlayer> Newplayers = (from p in oDc.tblPlayers select p).ToList();

            Assert.IsNotNull(playercard);
            Assert.AreNotEqual(Oldplayers.Count, Newplayers.Count);
        }

        [TestMethod]
        public void UpdateTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            tblPlayer player = (from p in oDc.tblPlayers
                            where p.Name == "PL.Testplayer"
                            select p).FirstOrDefault();


            player.Name = "PL.Testplayer Updated";
            player.Password = "PLTEST";
            player.Wins = 0;
            player.Losses = 0;


            oDc.SubmitChanges();

            tblPlayer updatedplayer = (from p in oDc.tblPlayers
                                   where p.Name == "PL.Testplayer Updated"
                                   select p).FirstOrDefault();

            Assert.IsNotNull(updatedplayer);
        }

        [TestMethod]
        public void DeleteTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            tblPlayer player = (from p in oDc.tblPlayers
                            where p.Name == "PL.Testplayer Updated"
                            select p).FirstOrDefault();

            oDc.tblPlayers.DeleteOnSubmit(player);
            oDc.SubmitChanges();

            Assert.AreEqual(1, oDc.tblPlayers.Count());
        }
    }
}
