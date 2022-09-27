BEGIN

	INSERT into [dbo].[tblAnswer] (Id, Answertext)
	VALUES
	(NEWID(), 'Blue'),
	(NEWID(), 'True'),
	(NEWID(), 'False'),
	(NEWID(), 'Green'),
	(NEWID(), 'Tokyo')

END