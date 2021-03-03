DECLARE @NewId UNIQUEIDENTIFIER = NEWID()

INSERT INTO [dbo].[Event]
           ([Id]
           ,[Type]
           ,[CategoryId]
           ,[Description]
           ,[Date]
           ,[Amount])
     VALUES
           (@NewId
           ,@Type
           ,@CategoryId
           ,@Description
           ,@Date
           ,@Amount)

SELECT @NewId