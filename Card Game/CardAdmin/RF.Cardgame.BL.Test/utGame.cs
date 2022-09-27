using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using RF.Cardgame.BL;
using RF.Cardgame.PL;

namespace RF.Cardgame.BL.Test
{
    [TestClass]
    public class utGame
    {
        [TestMethod]
        public void LoadGamesTest()
        {
            CGameList games = new CGameList();
            games.Load();

            Assert.AreEqual(1, games.Count);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            CGame fetchGame = new CGame();
            fetchGame.Id = new Guid("C441E358-7393-4CD8-997C-87726BF57816");

            fetchGame.LoadById();

            Assert.AreEqual(fetchGame.OpponentId, "08934AAD-6757-45A9-BE57-EE7C687E8AB6");

        }

        [TestMethod]
        public void InsertTest()
        {
            CGame game = new CGame();

            game.PlayerId = new Guid("11111111-1111-1111-1111-111111111111");
            game.OpponentId = new Guid("22222222-2222-2222-2222-222222222222");
            game.MatchDate = DateTime.Now;

            game.Insert();

            CardGameDataContext oDc = new CardGameDataContext();
            var fetchGame = oDc.tblGames.Where(p => p.PlayerId == game.PlayerId).FirstOrDefault();

            Assert.IsNotNull(fetchGame);
        }

        [TestMethod]
        public void UpdateTest()
        {
            Guid pid = new Guid("11111111-1111-1111-1111-111111111111");
            CardGameDataContext oDc = new CardGameDataContext();
            var fetchGame = oDc.tblGames.Where(p => p.PlayerId == pid).FirstOrDefault();

            CGame game = new CGame();
            game.Id = fetchGame.Id;
            game.LoadById();

            game.MatchDate = DateTime.MaxValue;

            game.Update();

            fetchGame = null;
            fetchGame = oDc.tblGames.Where(p => p.PlayerId == pid).FirstOrDefault();

            Assert.AreEqual("12/31/9999 11:59:59 PM", fetchGame.MatchDate.ToString());
        }

        [TestMethod]
        public void DeleteTest()
        {
            Guid pid = new Guid("11111111-1111-1111-1111-111111111111");

            CardGameDataContext oDc = new CardGameDataContext();
            var fetchGame = oDc.tblGames.Where(p => p.PlayerId == pid).FirstOrDefault();

            CGame game = new CGame();
            game.Id = fetchGame.Id;

            game.Delete();

            var newfetch = oDc.tblGames.Where(p => p.PlayerId == pid).FirstOrDefault();

            Assert.AreNotEqual(fetchGame, newfetch);
            Assert.IsNull(newfetch);
        }
    }
}
