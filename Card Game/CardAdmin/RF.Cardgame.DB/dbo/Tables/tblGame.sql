﻿CREATE TABLE [dbo].[tblGame]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [PlayerId] UNIQUEIDENTIFIER NOT NULL, 
    [OpponentId] UNIQUEIDENTIFIER NOT NULL, 
    [MatchDate] DATETIME NULL
)
