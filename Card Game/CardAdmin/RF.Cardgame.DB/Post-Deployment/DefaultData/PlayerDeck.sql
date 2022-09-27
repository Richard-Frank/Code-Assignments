BEGIN

Declare @PlayerId uniqueidentifier

SELECT @PlayerId = Id
FROM tblPlayer
WHERE Name = 'player'

Declare @DeckId uniqueidentifier

SELECT @DeckId = Id
FROM tblDeck
WHERE Name = 'Basic Deck'

INSERT INTO tblPlayerDeck(Id, PlayerId, DeckId)
VALUES
(
	NEWID(), @PlayerId, @DeckId
)

END