CREATE PROCEDURE [dbo].[spGetQA]
	@QId uniqueidentifier
AS
	SELECT Id, QuestionId, AnswerId, IsCorrect
	FROM tblQAJunction
	WHERE QuestionId = @QId
RETURN 0
