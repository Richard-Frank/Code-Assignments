CREATE PROCEDURE [dbo].[spGetCardsByDeck]
	@deckId UNIQUEIDENTIFIER
	
AS
	SELECT dc.CardId, c.Name, c.Attack, c.Health, c.Cost
	FROM tblCard c
	JOIN tblDeckCards dc on c.Id = dc.CardId
	WHERE @deckId = dc.DeckId
RETURN 0
