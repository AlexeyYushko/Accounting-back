UPDATE dbo.Category
SET Name = @name,
	Capacity = @capacity
WHERE Id = @id

SELECT *
FROM Category
WHERE Id = @id