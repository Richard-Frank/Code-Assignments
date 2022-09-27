CREATE PROCEDURE [dbo].[spGetVehicles]
AS
	SELECT v.Id, v.ColorId, v.MakeId, v.ModelId, c.Description, ma.Description, mo.Description,
	c.Description ColorName,
	ma.Description MakeName,
	mo.Description ModelName,
	v.VIN,
	v.Year	
	FROM tblVehicle v
	JOIN tblColor c on v.ColorId = c.Id
	JOIN tblMake ma on v.MakeId = ma.Id
	JOIN tblModel mo on v.ModelId = mo.Id
RETURN 0
