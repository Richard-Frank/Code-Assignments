CREATE PROCEDURE [dbo].[spDeleteCards]
	@cardId UNIQUEIDENTIFIER

AS

	DELETE FROM tblCard where Id = @cardId
	DELETE FROM tblDeckCards where CardId = @cardId

RETURN 0
