CREATE TABLE [dbo].[tblResponse](
	[Id] [uniqueidentifier] NOT NULL PRIMARY KEY,
	[QuestionId] [uniqueidentifier] NOT NULL,
	[AnswerId] [uniqueidentifier] NOT NULL
)
