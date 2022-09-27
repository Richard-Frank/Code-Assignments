BEGIN

Declare @GamePlayerId uniqueidentifier

SELECT @GamePlayerId = Id
FROM tblPlayer
WHERE Name = 'player'

Declare @GamePlayer2Id uniqueidentifier

SELECT @GamePlayer2Id = Id
FROM tblPlayer
WHERE Name = 'playerTwo'

INSERT INTO tblGame(Id, PlayerId, OpponentId, MatchDate)
VALUES
(
	NEWID(), @GamePlayerId, @GamePlayer2Id, GETDATE()
)

END