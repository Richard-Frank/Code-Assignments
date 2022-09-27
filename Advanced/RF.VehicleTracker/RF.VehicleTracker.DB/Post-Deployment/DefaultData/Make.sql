BEGIN

INSERT into [dbo].[tblMake] (id, Description)
VALUES 
(NEWID(), 'Ford'),
(NEWID(), 'Chevy'),
(NEWID(), 'Canyonero'),
(NEWID(), 'Toyota'),
(NEWID(), 'AMC')

END