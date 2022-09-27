BEGIN

INSERT into [dbo].[tblColor] (id, Description)
VALUES 
(NEWID(), 'CornflowerBlue'),
(NEWID(), 'VeryRed'),
(NEWID(), 'Green'),
(NEWID(), 'Chrome'),
(NEWID(), 'VeryUglyYellow')

END