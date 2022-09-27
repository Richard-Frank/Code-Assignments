using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF.Cardgame.PL;   

namespace RF.Cardgame.BL
{
    public class CDeck
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public CDeck()
        {

        }

        public CDeck(Guid id)
        {
            this.Id = id;
        }

        // overloaded constructor
        public CDeck(Guid id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        // overloaded constructor with name only
        public CDeck(string name)
        {
            this.Name = name;
        }

        // insert method
        public void Insert()
        {
            try
            {
                // data context
                CardGameDataContext oDc = new CardGameDataContext();

                tblDeck deck = new tblDeck();
                deck.Id = Guid.NewGuid();
                deck.Name = this.Name;

                this.Id = deck.Id;

                oDc.tblDecks.InsertOnSubmit(deck);
                oDc.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void InsertPlayerDeck(Guid playerid)
        {
            try
            {
                // data context
                CardGameDataContext oDc = new CardGameDataContext();

                tblDeck deck = new tblDeck();
                deck.Id = Guid.NewGuid();
                deck.Name = this.Name;

                this.Id = deck.Id;

                tblPlayerDeck playerdeck = new tblPlayerDeck();

                playerdeck.Id = Guid.NewGuid();
                playerdeck.PlayerId = playerid;
                playerdeck.DeckId = this.Id;

               
                oDc.tblDecks.InsertOnSubmit(deck);
                oDc.tblPlayerDecks.InsertOnSubmit(playerdeck);
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

                var deck = oDc.tblDecks.Where(p => p.Id == Id).FirstOrDefault();

                if (deck != null)
                {

                    deck.Name = this.Name;

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

                //var deck = oDc.tblDecks.Where(p => p.Id == Id).FirstOrDefault();

                if (this.Id != null)
                {
                    //oDc.tblDecks.DeleteOnSubmit(deck);
                    oDc.spDeleteDecks(this.Id);
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

                var deck = oDc.tblDecks.Where(p => p.Id == Id).FirstOrDefault();

                // set the properties
                this.Id = deck.Id;
                this.Name = deck.Name;
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AssignCards(CCardList cards)
        {
            try
            {

                CardGameDataContext oDc = new CardGameDataContext();

                var assignedCards = oDc.tblDeckCards.Where(p => p.DeckId == this.Id).ToList();

                if (assignedCards != null)
                {
                    foreach (var assigndcard in assignedCards)
                    {
                        oDc.tblDeckCards.DeleteOnSubmit(assigndcard);
                    }
                    //oDc.tblDeckCards.DeleteAllOnSubmit(assignedCards);

                    // Loop through the answers and insert into the tblQAJunction
                    foreach (CCard card in cards)
                    {
                        tblDeckCard dc = new tblDeckCard();
                        dc.Id = Guid.NewGuid();
                        dc.DeckId = this.Id;
                        dc.CardId = card.Id;

                        oDc.tblDeckCards.InsertOnSubmit(dc);
                    }

                    oDc.SubmitChanges();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       

    }

    // make a list class
    public class CDeckList : List<CDeck>
    {


        public void SPGetDecksByPlayer(Guid playerid)
        {
            CardGameDataContext oDc = new CardGameDataContext();
            var results = oDc.spGetDecksByPlayer(playerid).ToList();

            foreach (var pd in results)
            {
                CDeck deck = new CDeck(pd.DeckId, pd.Name);

                Add(deck);
            }
        }
        // Load Method
        public void Load()
        {
            try
            {
                // data context
                CardGameDataContext oDc = new CardGameDataContext();

                var results = (from c in oDc.tblDecks
                               select c).ToList();
                foreach (var deck in results)
                {
                    CDeck oDeck = new CDeck(deck.Id, deck.Name);
                                                                                            
                    Add(oDeck);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
