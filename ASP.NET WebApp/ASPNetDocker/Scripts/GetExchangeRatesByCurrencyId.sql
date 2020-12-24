SELECT 
	Currency.Name AS Currency
	,ExchangeRate.Rate
FROM ExchangeRate
JOIN Currency ON ExchangeRate.[To] = Currency.Id
WHERE [From] = @currencyId