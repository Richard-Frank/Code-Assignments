using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF.Cardgame.PL;

namespace RF.Cardgame.BL
{
    public class CCard
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public int Cost { get; set; }
        
        public CCard()
        {

        }

        // overloaded constructor
        public CCard(Guid id, string name, int attack, int health, int cost)
        {
            this.Id = id;
            this.Name = name;
            this.Attack = attack;
            this.Health = health;
            this.Cost = cost;
            
        }

        public CCard(Guid id)
        {
            this.Id = id;
        }

        public CCard(string name, int attack, int health, int cost)
        {
            this.Name = name;
            this.Attack = attack;
            this.Health = health;
            this.Cost = cost;
        }

        // insert method
        public void Insert()
        {
            try
            {
                // data context
                CardGameDataContext oDc = new CardGameDataContext();

                tblCard card = new tblCard();
                card.Id = Guid.NewGuid();
                card.Name = this.Name;
                card.Attack = this.Attack;
                card.Health = this.Health;
                card.Cost = this.Cost;
                

                this.Id = card.Id;

                oDc.tblCards.InsertOnSubmit(card);
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

                var card = oDc.tblCards.Where(p => p.Id == Id).FirstOrDefault();

                if (card != null)
                {
                    card.Name = this.Name;
                    card.Attack = this.Attack;
                    card.Health = this.Health;
                    card.Cost = this.Cost;
                    
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

                //var card = oDc.tblCards.Where(p => p.Id == Id).FirstOrDefault();

                if (this.Id != null)
                {
                    //oDc.tblCards.DeleteOnSubmit(card);
                    oDc.spDeleteCards(this.Id);
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

                var card = oDc.tblCards.Where(p => p.Id == Id).FirstOrDefault();

                // set the properties
                this.Id = card.Id;
                this.Name = card.Name;
                this.Attack = card.Attack.GetValueOrDefault();
                this.Health = card.Health.GetValueOrDefault();
                this.Cost = card.Cost.GetValueOrDefault();
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }


    }

    public class CCardList : List<CCard>
    {
        // Load Method
        public void Load()
        {
            try
            {
                // data context
                CardGameDataContext oDc = new CardGameDataContext();

                var results = (from c in oDc.tblCards
                               select c).ToList();
                foreach (var card in results)
                {
                    CCard oCard = new CCard(card.Id, card.Name, card.Attack.GetValueOrDefault(),
                                                                card.Health.GetValueOrDefault(), 
                                                                card.Cost.GetValueOrDefault());
                    Add(oCard);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        // Load Method with join for Decks
        public void SPGetCardsByDeck(Guid deckid)
        {
            CardGameDataContext oDc = new CardGameDataContext();
            var results = oDc.spGetCardsByDeck(deckid).ToList();

            foreach (var dc in results)
            {
                CCard ocard = new CCard(dc.CardId, dc.Name, dc.Attack.GetValueOrDefault(),
                                                           dc.Health.GetValueOrDefault(),
                                                           dc.Cost.GetValueOrDefault());

                Add(ocard);
            }
        }

    }


}
