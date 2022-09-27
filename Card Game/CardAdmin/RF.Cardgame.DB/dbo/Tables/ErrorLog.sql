CREATE TABLE [dbo].[ErrorLog]
(
	[ErrDate] DATETIME NULL, 
    [ErrThread] VARCHAR(200) NULL, 
    [ErrLevel] VARCHAR(200) NULL, 
    [ErrLogger] VARCHAR(20) NULL, 
    [ErrMessage] VARCHAR(2000) NULL, 
    [ErrUser] VARCHAR(250) NULL 
)
