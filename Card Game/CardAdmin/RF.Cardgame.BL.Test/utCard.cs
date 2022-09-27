using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using RF.Cardgame.BL;
using RF.Cardgame.PL;

namespace RF.Cardgame.BL.Test
{
    [TestClass]
    public class utCard
    {
        [TestMethod]
        public void LoadCardsTest()
        {
            CCardList cards = new CCardList();
            cards.Load();

            Assert.AreEqual(8, cards.Count);
        }


        [TestMethod]
        public void LoadByIdTest()
        {
                CCard fetchcard = new CCard();
                fetchcard.Id = new Guid("636DBE62-5FD2-491D-9F9E-AE28E73418C7");

                fetchcard.LoadById();

                Assert.AreEqual(fetchcard.Name, "Billy");

        }

        [TestMethod]
        public void InsertTest()
        {
            CCard newcard = new CCard();

            newcard.Name = "BL.Testman";
            newcard.Attack = 5;
            newcard.Health = 5;
            newcard.Cost = 5;

            newcard.Insert();

            CardGameDataContext oDc = new CardGameDataContext();
            var fetchcard = oDc.tblCards.Where(p => p.Name == newcard.Name).FirstOrDefault();

            Assert.IsNotNull(fetchcard);
        }

        [TestMethod]
        public void UpdateTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();
            var fetchcard = oDc.tblCards.Where(p => p.Name == "BL.Testman").FirstOrDefault();

            CCard card = new CCard();
            card.Id = fetchcard.Id;

            card.LoadById();

            card.Name = "BL.TestmanV2";

            card.Update();

            fetchcard = null;
            fetchcard = oDc.tblCards.Where(p => p.Name == "BL.TestmanV2").FirstOrDefault();

            Assert.IsNotNull(fetchcard);
        }

        [TestMethod]
        public void DeleteTest()
        {
            CardGameDataContext oDc = new CardGameDataContext();
            var fetchcard = oDc.tblCards.Where(p => p.Name == "BL.TestmanV2").FirstOrDefault();

            CCard card = new CCard();
            card.Id = fetchcard.Id;

            card.Delete();

            var newfetch = oDc.tblCards.Where(p => p.Name == "BL.TestmanV2").FirstOrDefault();

            Assert.AreNotEqual(fetchcard, newfetch);
            Assert.IsNull(newfetch);
        }
    }

}
