DECLARE @NewId UNIQUEIDENTIFIER = NEWID()

INSERT dbo.Category(Id, Name, Capacity)
SELECT 
	@NewId,
	@name,
	@capacity

SELECT @NewId