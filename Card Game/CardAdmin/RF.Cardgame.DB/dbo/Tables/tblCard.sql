CREATE TABLE [dbo].[tblCard]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(25) NOT NULL, 
    [Attack] INT NULL, 
    [Health] INT NULL, 
    [Cost] INT NULL 
)
