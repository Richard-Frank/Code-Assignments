CREATE PROCEDURE [dbo].[spDeleteDecks]
	@deckId UNIQUEIDENTIFIER

AS

	DELETE FROM tblDeck where Id = @deckId
	DELETE FROM tblDeckCards where DeckId = @deckId
	DELETE FROM tblPlayerDeck where DeckId = @deckId

RETURN 0
