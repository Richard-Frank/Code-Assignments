CREATE PROCEDURE [dbo].[spGetVehiclesByColor]
	@colorname varchar(32)
AS
	SELECT v.Id, v.ColorId, v.MakeId, v.ModelId,
	c.Description ColorName,
	ma.Description MakeName,
	mo.Description ModelName,
	v.VIN,
	v.Year	
	FROM tblVehicle v
	JOIN tblColor c on v.ColorId = c.Id
	JOIN tblMake ma on v.MakeId = ma.Id
	JOIN tblModel mo on v.ModelId = mo.Id

	WHERE c.Description like '%' + @colorname + '%'
RETURN 0
