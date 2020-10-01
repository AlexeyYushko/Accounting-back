DECLARE @NewId UNIQUEIDENTIFIER = NEWID()

INSERT dbo.Users(Id, Username, Password, Email)
SELECT 
	@NewId,
	@name,
	@password,
	@email

SELECT @NewId