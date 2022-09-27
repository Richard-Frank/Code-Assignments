BEGIN

	DECLARE @QId uniqueidentifier

	SELECT @QId = Id
	FROM tblQuestion
	WHERE QuestionText = 'Water is dry.'

	DECLARE @AnId uniqueidentifier

	SELECT @AnId = Id
	FROM tblAnswer
	WHERE Answertext = 'True'

	INSERT INTO tblQAJunction(Id, QuestionId, AnswerId, IsCorrect)
	VALUES
	(
		NEWID(), @QId, @AnId, 0
	)

	SELECT @AnId = Id
	FROM tblAnswer
	WHERE Answertext = 'False'

	INSERT INTO tblQAJunction(Id, QuestionId, AnswerId, IsCorrect)
	VALUES
	(
		NEWID(), @QId, @AnId, 1
	)
END