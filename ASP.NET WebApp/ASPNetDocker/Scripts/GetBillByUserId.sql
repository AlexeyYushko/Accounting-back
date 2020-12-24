SELECT Bill.Id,
	Currency.Name AS Currency,
	Bill.Amount
FROM Bill
JOIN Currency ON Bill.Currency = Currency.Id