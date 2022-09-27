BEGIN

INSERT into [dbo].[tblCard] (Id, Name, Attack, Health, Cost)
VALUES 

(NewID(), 'Wardog', 1, 1, 1),
(NewID(), 'Soldier', 2, 2, 2),
(NewID(), 'Savage', 5, 1, 3),
(NewID(), 'Big Old Lizard', 4, 4, 4),
(NewID(), 'Drake', 7, 7, 7),
(NewID(), 'Wyvern', 7, 5, 6),
(NewID(), 'Billy', 0, 1, 0),
(NewID(), 'Large Expensive Dragon', 10, 10, 10 )


END