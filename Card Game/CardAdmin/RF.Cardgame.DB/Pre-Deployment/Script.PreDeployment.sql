/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

DELETE FROM tblDeckCards
DELETE FROM tblPlayerDeck
DELETE FROM ErrorLog
DELETE FROM tblGame
DELETE FROM tblAdmin
DELETE FROM tblCard
DELETE FROM tblDeck
DELETE FROM tblPlayer
