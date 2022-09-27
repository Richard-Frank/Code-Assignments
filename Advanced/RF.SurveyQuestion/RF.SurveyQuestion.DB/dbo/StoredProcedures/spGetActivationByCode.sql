CREATE PROCEDURE [dbo].[spGetActivationByCode]
	@code varchar(5)
AS
	SELECT Id, QuestionId, StartDate, EndDate, ActivationCode
	FROM tblActivation
	WHERE ActivationCode = @code
RETURN 0
