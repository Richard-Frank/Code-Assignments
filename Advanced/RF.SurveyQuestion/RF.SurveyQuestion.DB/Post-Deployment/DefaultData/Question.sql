BEGIN

	INSERT INTO [dbo].[tblQuestion] (Id, QuestionText)
	VALUES
	(NEWID(), 'What color is the sky?'),
	(NEWID(), 'Fire is hot.'),
	(NEWID(), 'Water is dry.'),
	(NEWID(), 'What color is grass?'),
	(NEWID(), 'What is Godzillas favorite city?')

END