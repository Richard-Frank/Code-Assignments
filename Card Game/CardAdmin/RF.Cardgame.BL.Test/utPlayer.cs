using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using RF.Cardgame.BL;
using RF.Cardgame.PL;

namespace RF.Cardgame.BL.Test
{
    [TestClass]
    public class utPlayer
    {
        [TestMethod]
        public void LoadPlayersTest()
        {
            CPlayerList players = new CPlayerList();
            players.Load();

            Assert.AreEqual(2, players.Count);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            CPlayer fetchPlayer = new CPlayer();
            fetchPlayer.Id = new Guid("C441E358-7393-4CD8-997C-87726BF57816");

            fetchPlayer.LoadById();

            Assert.AreEqual(fetchPlayer.Name, "player");

        }

        [TestMethod]
        public void InsertTest()
        {
            CPlayer player = new CPlayer();

            player.Name = "BL.Testplayer";
            player.Password = "BLtest";

            player.Insert();

            CardGameDataContext oDc = new CardGameDataContext();
            var fetchPlayer = oDc.tblPlayers.Where(p => p.Name == player.Name).FirstOrDefault();

            Assert.IsNotNull(fetchPlayer);
        }

        [TestMethod]
        public void UpdateTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();
            var fetchPlayer = oDc.tblPlayers.Where(p => p.Name == "BL.Testplayer").FirstOrDefault();

            CPlayer player = new CPlayer();
            player.Id = fetchPlayer.Id;

            player.LoadById();

            player.Name = "BL.TestplayerUpdate";
            player.Password = "BL.Update";
            player.Wins = 999;

            player.Update();

            fetchPlayer = null;
            fetchPlayer = oDc.tblPlayers.Where(p => p.Name == "BL.TestplayerUpdate").FirstOrDefault();

            Assert.IsNotNull(fetchPlayer);
        }

        [TestMethod]
        public void DeleteTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();
            var fetchPlayer = oDc.tblPlayers.Where(p => p.Name == "BL.TestplayerUpdate").FirstOrDefault();

            CPlayer player = new CPlayer();
            player.Id = fetchPlayer.Id;

            player.Delete();

            var newfetch = oDc.tblPlayers.Where(p => p.Name == "BL.TestplayerUpdate").FirstOrDefault();

            Assert.AreNotEqual(fetchPlayer, newfetch);
            Assert.IsNull(newfetch);
        }
    }
}
