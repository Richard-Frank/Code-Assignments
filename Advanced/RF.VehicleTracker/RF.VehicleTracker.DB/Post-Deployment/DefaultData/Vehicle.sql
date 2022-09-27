BEGIN

	DECLARE @ColorId uniqueidentifier

	SELECT @ColorId = Id
	FROM tblColor
	WHERE Description = 'VeryRed';

	DECLARE @MakeId uniqueidentifier

	SELECT @MakeId = Id
	FROM tblMake
	WHERE Description = 'Ford';

	DECLARE @ModelId uniqueidentifier

	SELECT @ModelId = Id
	FROM tblModel
	WHERE Description = 'Mustang';

	INSERT INTO tblVehicle(Id, ColorId, MakeId, ModelId, Year, VIN)
	VALUES
	(
		NEWID(), @ColorId, @MakeId, @ModelId, 1965, '1001FAKEVIN123'
	)
END