CREATE PROCEDURE [dbo].[spGetQuestions]
AS
	SELECT Id, QuestionText
	FROM tblQuestion
RETURN 0
