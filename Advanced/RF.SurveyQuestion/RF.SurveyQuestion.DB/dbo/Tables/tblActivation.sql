CREATE TABLE [dbo].[tblActivation](
	[Id] [uniqueidentifier] NOT NULL,
	[QuestionId] [uniqueidentifier] NOT NULL,
	[StartDate] datetime NOT NULL,
	[EndDate] datetime NOT NULL,
	[ActivationCode] varchar(5)
 CONSTRAINT [PK_tblActivation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
