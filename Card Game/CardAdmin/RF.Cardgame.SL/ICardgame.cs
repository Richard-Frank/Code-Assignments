using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RF.Cardgame.BL;

namespace RF.Cardgame.SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICardgame" in both code and config file together.
    [ServiceContract]
    public interface ICardgame
    {
        //CAdmin
        [OperationContract]
        CAdminList LoadAdmins();
        [OperationContract]
        CAdmin LoadAdminById(Guid id);
        [OperationContract]
        void InsertAdmin(string name, string password);
        [OperationContract]
        void UpdateAdmin(Guid id, string name, string password);
        [OperationContract]
        void DeleteAdmin(Guid id);
        [OperationContract]
        bool LoginAdmin(string name, string password);
        

        //CPlayer
        [OperationContract]
        CPlayerList LoadPlayers();
        [OperationContract]
        CPlayer LoadPlayerById(Guid id);
        [OperationContract]
        void InsertPlayer(string name, string password);
        [OperationContract]
        void UpdatePlayer(Guid id, string name, string password, int wins, int losses);
        [OperationContract]
        void DeletePlayer(Guid id);
        [OperationContract]
        bool LoginPlayer(string name, string password);
        [OperationContract]
        Guid GetPlayerByLogin(string playerName, string playerPass);
        

        //Ccard
        [OperationContract]
        CCardList LoadCards();
        [OperationContract]
        CCard LoadCardById(Guid id);
        [OperationContract]
        void InsertCard(string name, int attack, int health, int cost, string adminName, string adminPass);
        [OperationContract]
        void UpdateCard(Guid id, string name, int attack, int health, int cost, string adminName, string adminPass);
        [OperationContract]
        void DeleteCard(string adminName, string adminPass, Guid id);
        [OperationContract]
        CCardList SPGetCardsByDeck(Guid deckId);

        //CDeck
        [OperationContract]
        CDeckList LoadDecks();
        [OperationContract]
        CDeck LoadDeckById(Guid id);
        [OperationContract]
        void InsertDeck(string name, Guid playerId);
        [OperationContract]
        void UpdateDeck(Guid id, string name);
        [OperationContract]
        void DeleteDeck(Guid id);
        [OperationContract]
        void AssignCards(Guid deckId, CCardList cardList);
        [OperationContract]
        void AssignAndInsert(string name, Guid playerId, CCardList cardList);
        [OperationContract]
        CDeckList SPGetDecksByPlayer(Guid playerid);



        //CGame
        [OperationContract]
        CGameList LoadGames();
        [OperationContract]
        CGame LoadGameById(Guid id);
        [OperationContract]
        void InsertGame(Guid playerId, Guid opponentId, DateTime matchDate);
        [OperationContract]
        void UpdateGame(Guid id, DateTime matchdate);
        [OperationContract]
        void DeleteGame(Guid id);
    }
}
