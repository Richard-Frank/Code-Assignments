CREATE PROCEDURE [dbo].[spGetDecksByPlayer]
	@playerId UNIQUEIDENTIFIER

AS
	SELECT pd.DeckId, d.Name
	FROM tblDeck d
	JOIN tblPlayerDeck pd on d.Id = pd.DeckId
	WHERE @playerId = pd.PlayerId;

RETURN 0
