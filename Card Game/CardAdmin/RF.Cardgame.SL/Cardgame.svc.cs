using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RF.Cardgame.BL;

namespace RF.Cardgame.SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Cardgame" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Cardgame.svc or Cardgame.svc.cs at the Solution Explorer and start debugging.
    public class Cardgame : ICardgame
    {
        //Admin
        public CAdmin LoadAdminById(Guid Id)
        {
            CAdmin admin = new CAdmin(Id);
            admin.LoadById();
            return admin;
        }
        public CAdminList LoadAdmins()
        {
            CAdminList admins = new CAdminList();
            admins.Load();
            return admins;
        }
        public void DeleteAdmin(Guid id)
        {
            new CAdmin(id).Delete();
        }
        public void InsertAdmin(string name, string password)
        {
            new CAdmin(name, password).Insert();
        }
        public void UpdateAdmin(Guid id, string name, string password)
        {
            new CAdmin(id, name, password).Update();
        }
        public bool LoginAdmin(string name, string password)
        {
            CAdmin admin = new CAdmin(name, password);
            return admin.Login();
        }
      


        //Player
        public CPlayer LoadPlayerById(Guid Id)
        {
           CPlayer player = new CPlayer(Id);
            player.LoadById();
            return player;

        }
        public Guid GetPlayerByLogin(string playerName, string playerPass)
        {
            bool login = new CPlayer(playerName, playerPass).Login();

            if (login == true)
            {
                CPlayer player = new CPlayer();
                player.GetPlayerByName(playerName);
                return player.Id;
            }
            else
            {
                return Guid.Empty;
            }

        }
        public CPlayerList LoadPlayers()
        {
            CPlayerList players = new CPlayerList();
            players.Load();
            return players;
        }
        public void DeletePlayer(Guid id)
        {
            new CPlayer(id).Delete();
        }
        public void InsertPlayer(string name, string password)
        {
            new CPlayer(name, password).Insert();
        }
        public void UpdatePlayer(Guid id, string name, string password, int wins, int losses)
        {
            new CPlayer(id, name, password, wins, losses).Update();
        }
        public bool LoginPlayer(string name, string password)
        {
            CPlayer player = new CPlayer(name, password);
            return player.Login();
        }
        


        //Deck
        public CDeck LoadDeckById(Guid id)
        {
            CDeck deck = new CDeck(id);
            deck.LoadById();
            return deck;

        }

        public CDeckList LoadDecks()
        {
            CDeckList decks = new CDeckList();
            decks.Load();
            return decks;
        }

        public void AssignCards(Guid deckId, CCardList cardlist)
        {
            CDeck deck = new CDeck(deckId);
            deck.AssignCards(cardlist);
        }

        public void AssignAndInsert(string name, Guid playerId, CCardList cardlist)
        {
            CDeck deck = new CDeck(name);
            deck.InsertPlayerDeck(playerId);
            deck.AssignCards(cardlist);
        }

        public void DeleteDeck(Guid id)
        {
            new CDeck(id).Delete();
        }
        public void InsertDeck(string name, Guid playerId)
        {
            new CDeck(name).InsertPlayerDeck(playerId);
        }

        public CDeckList SPGetDecksByPlayer(Guid playerid)
        {
            CDeckList decks = new CDeckList();
            decks.SPGetDecksByPlayer(playerid);
            return decks;
        }

        public void UpdateDeck(Guid id, string name)
        {
            new CDeck(id, name).Update();
        }



        //Card
        public CCard LoadCardById(Guid id)
        {
            CCard card = new CCard(id);
            card.LoadById();
            return card;
        }

        public CCardList LoadCards()
        {
            CCardList cards = new CCardList();
            cards.Load();
            return cards;
        }

        public CCardList SPGetCardsByDeck(Guid deckId)
        {
            CCardList cards = new CCardList();
            cards.SPGetCardsByDeck(deckId);
            return cards;
        }
        public void DeleteCard(string adminName, string adminPass, Guid id)
        {
            bool login = new CAdmin(adminName, adminPass).Login();

            if (login == true)
            {
                new CCard(id).Delete();
            }
            
        }
        public void InsertCard(string name, int attack, int health, int cost, string adminName, string adminPass)
        {
            bool login = new CAdmin(adminName, adminPass).Login();

            if (login == true)
            {
                new CCard(name, attack, health, cost).Insert();
            }
            }
        public void UpdateCard(Guid id, string name, int attack, int health, int cost, string adminName, string adminPass)
        {
            bool login = new CAdmin(adminName, adminPass).Login();
            if (login == true)
            {
                new CCard(id, name, attack, health, cost).Update();
            }
        }

        //Game
        public CGame LoadGameById(Guid id)
        {
            CGame game = new CGame(id);
            game.LoadById();
            return game;
        }
        public CGameList LoadGames()
        {
            CGameList games = new CGameList();
            games.Load();
            return games;
        }
        public void DeleteGame(Guid id)
        {
            new CGame(id).Delete();
        }
        public void InsertGame(Guid playerId, Guid opponentId, DateTime matchDate)
        {
            new CGame(playerId, opponentId, matchDate).Insert();
        }
        public void UpdateGame(Guid id, DateTime matchdate)
        {
            new CGame(id, matchdate).Update();
        }

        
    }
}
