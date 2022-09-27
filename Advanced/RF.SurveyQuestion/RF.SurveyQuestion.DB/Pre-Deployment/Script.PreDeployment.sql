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

	if exists(select name from sysobjects where name = 'tblAnswer') delete from tblAnswer
	if exists(select name from sysobjects where name = 'tblQuestion') delete from tblQuestion
	if exists(select name from sysobjects where name = 'tblQAJunction')delete from tblQAJunction
	if exists(select name from sysobjects where name = 'tblActivation')delete from tblActivation
	if exists(select name from sysobjects where name = 'tblResponse')delete from tblResponse

	/*
	DELETE FROM tblAnswer
	DELETE FROM tblQuestion
	DELETE FROM tblQAJunction
	*/