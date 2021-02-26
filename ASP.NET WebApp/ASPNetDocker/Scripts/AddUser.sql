DECLARE @NewId UNIQUEIDENTIFIER = NEWID()

INSERT dbo.Users(Id, Username, Password, Email)
SELECT 
	@NewId,
	@UserName,
	@Password,
	@Email

SELECT @NewId