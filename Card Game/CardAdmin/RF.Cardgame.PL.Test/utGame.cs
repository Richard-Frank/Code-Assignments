using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace RF.Cardgame.PL.Test
{
    [TestClass]
    public class utGame
    {
        [TestMethod]
        public void SelectTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            List<tblGame> gamelist = (from c in oDc.tblGames select c).ToList();

            Assert.AreEqual(1, gamelist.Count);
        }

        [TestMethod]
        public void InsertTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            List<tblGame> Oldgames = (from p in oDc.tblGames select p).ToList();

            tblGame newgame = new tblGame();

            newgame.Id = new Guid("00000001-0000-1111-1111-000000000000");
            newgame.PlayerId = oDc.tblPlayers.Where(p => p.Name == "player").FirstOrDefault().Id;
            newgame.OpponentId = oDc.tblPlayers.Where(p => p.Name == "playerTwo").FirstOrDefault().Id;
            newgame.MatchDate = DateTime.Now;

            oDc.tblGames.InsertOnSubmit(newgame);

            oDc.SubmitChanges();

            Guid checkguid = newgame.Id;

            tblGame gamecard = (from p in oDc.tblGames
                                            where p.Id == checkguid
                                            select p).FirstOrDefault();

            List<tblGame> Newgames = (from p in oDc.tblGames select p).ToList();

            Assert.IsNotNull(gamecard);
            Assert.AreNotEqual(Oldgames.Count, Newgames.Count);
        }

        [TestMethod]
        public void UpdateTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            Guid pdId = new Guid("00000001-0000-1111-1111-000000000000");

            tblGame game = (from p in oDc.tblGames
                                        where p.Id == pdId
                                        select p).FirstOrDefault();
            Guid newdeckid = new Guid("11111111-1111-1111-1111-111111111111");

            game.OpponentId = newdeckid;


            oDc.SubmitChanges();

            tblGame updatedgame = (from p in oDc.tblGames
                                               where p.OpponentId == newdeckid
                                               select p).FirstOrDefault();


            Assert.IsNotNull(updatedgame);
        }

        [TestMethod]
        public void DeleteTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();

            Guid deckid = new Guid("11111111-1111-1111-1111-111111111111");

            tblGame game = (from p in oDc.tblGames
                                        where p.OpponentId == deckid
                                        select p).FirstOrDefault();

            oDc.tblGames.DeleteOnSubmit(game);
            oDc.SubmitChanges();

            Assert.AreEqual(1, oDc.tblGames.Count());
        }
    }
}
