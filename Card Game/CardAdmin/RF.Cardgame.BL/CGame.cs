using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF.Cardgame.PL;

namespace RF.Cardgame.BL
{
    public class CGame
    {
        public Guid Id { get; set; }
        public Guid PlayerId { get; set; }
        public Guid OpponentId { get; set; }
        public DateTime MatchDate { get; set;}

        public CGame()
        {

        }

        // overloaded constructor
        public CGame(Guid id, Guid playerid, Guid opponentid, DateTime matchdate)
        {
            this.Id = id;
            this.PlayerId = playerid;
            this.OpponentId = opponentid;
            this.MatchDate = matchdate;
        }

        public CGame(Guid playerid, Guid opponentid, DateTime matchdate)
        {

            this.PlayerId = playerid;
            this.OpponentId = opponentid;
            this.MatchDate = matchdate;
        }

        public CGame(Guid id, DateTime matchdate)
        {
            this.Id = id;
            this.MatchDate = matchdate;
        }

        public CGame(Guid id)
        {
            this.Id = id;
        }
        
        // insert method
        public void Insert()
        {
            try
            {
                // data context
                CardGameDataContext oDc = new CardGameDataContext();

                tblGame game = new tblGame();
                game.Id = Guid.NewGuid();
                game.PlayerId = this.PlayerId;
                game.OpponentId = this.OpponentId;
                game.MatchDate = this.MatchDate;

                this.Id = game.Id;

                oDc.tblGames.InsertOnSubmit(game);
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

                var game = oDc.tblGames.Where(p => p.Id == Id).FirstOrDefault();

                if (game != null)
                {

                    game.MatchDate = this.MatchDate;

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

                var game = oDc.tblGames.Where(p => p.Id == Id).FirstOrDefault();

                if (game != null)
                {
                    oDc.tblGames.DeleteOnSubmit(game);
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

                var game = oDc.tblGames.Where(p => p.Id == Id).FirstOrDefault();

                // set the properties
                this.Id = game.Id;
                this.PlayerId = game.PlayerId;
                this.OpponentId = game.OpponentId;
                this.MatchDate = (DateTime)game.MatchDate;
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }
        
    }
    // make a list class
    public class CGameList : List<CGame>
    {
        // Load Method
        public void Load()
        {
            try
            {
                // data context
                CardGameDataContext oDc = new CardGameDataContext();

                var results = (from c in oDc.tblGames
                               select c).ToList();
                foreach (var game in results)
                {
                    CGame oGame = new CGame(game.Id, game.PlayerId, game.OpponentId, (DateTime)game.MatchDate);

                    Add(oGame);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
    }
}
