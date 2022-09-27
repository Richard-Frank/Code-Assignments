CREATE TABLE [dbo].[tblPlayer]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
	[Name] VARCHAR(25) NOT NULL, 
	[Password] VARCHAR(25) NOT NULL,
    [Wins] INT NULL, 
    [Losses] INT NULL, 
)
