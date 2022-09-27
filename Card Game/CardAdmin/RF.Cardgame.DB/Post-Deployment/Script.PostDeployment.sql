/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
:r .\DefaultData\Admin.sql
:r .\DefaultData\Card.sql
:r .\DefaultData\Player.sql
:r .\DefaultData\Decks.sql
:r .\DefaultData\Game.sql
:r .\DefaultData\PlayerDeck.sql
:r .\DefaultData\DeckCards.sql
