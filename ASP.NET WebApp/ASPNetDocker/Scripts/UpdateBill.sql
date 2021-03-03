UPDATE dbo.Bill
SET Amount = @Amount
WHERE Id = @Id

SELECT Id,
	Amount
FROM Bill
WHERE Id = @Id