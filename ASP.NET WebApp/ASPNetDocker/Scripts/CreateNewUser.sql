DECLARE @NewId UNIQUEIDENTIFIER = NEWID()

INSERT dbo.Users
SELECT 
	@NewId,
	@name,
	@password,
	@email

SELECT @NewId