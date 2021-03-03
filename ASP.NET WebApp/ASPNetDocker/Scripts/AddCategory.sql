DECLARE @NewId UNIQUEIDENTIFIER = NEWID()

INSERT dbo.Category(Id, Name, Capacity)
SELECT 
	@NewId,
	@Name,
	@Capacity

SELECT @NewId