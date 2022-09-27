BEGIN

Declare @DCardId uniqueidentifier

SELECT @DCardId = Id
FROM tblCard
WHERE Name = 'Billy'

Declare @DDeckId uniqueidentifier

SELECT @DDeckId = Id
FROM tblDeck
WHERE Name = 'Basic Deck'

INSERT INTO tblDeckCards(Id, DeckId, CardId)
VALUES
(
	NEWID(), @DDeckId, @DCardId 
)

SELECT @DCardId = Id
FROM tblCard
WHERE Name = 'Soldier'

INSERT INTO tblDeckCards(Id, DeckId, CardId)
VALUES
(
	NEWID(), @DDeckId, @DCardId 
)

SELECT @DCardId = Id
FROM tblCard
WHERE Name = 'Wardog'

INSERT INTO tblDeckCards(Id, DeckId, CardId)
VALUES
(
	NEWID(), @DDeckId, @DCardId 
)

SELECT @DCardId = Id
FROM tblCard
WHERE Name = 'Wyvern'

INSERT INTO tblDeckCards(Id, DeckId, CardId)
VALUES
(
	NEWID(), @DDeckId, @DCardId 
)

SELECT @DCardId = Id
FROM tblCard
WHERE Name = 'Savage'

INSERT INTO tblDeckCards(Id, DeckId, CardId)
VALUES
(
	NEWID(), @DDeckId, @DCardId 
)

SELECT @DCardId = Id
FROM tblCard
WHERE Name = 'Drake'

INSERT INTO tblDeckCards(Id, DeckId, CardId)
VALUES
(
	NEWID(), @DDeckId, @DCardId 
)

SELECT @DCardId = Id
FROM tblCard
WHERE Name = 'Big Old Lizard'

INSERT INTO tblDeckCards(Id, DeckId, CardId)
VALUES
(
	NEWID(), @DDeckId, @DCardId 
)

SELECT @DCardId = Id
FROM tblCard
WHERE Name = 'Large Expensive Dragon'

INSERT INTO tblDeckCards(Id, DeckId, CardId)
VALUES
(
	NEWID(), @DDeckId, @DCardId 
)
END