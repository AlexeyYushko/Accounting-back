SELECT 
	cto.Name AS Currency
	,ExchangeRate.Rate
FROM ExchangeRate
JOIN Currency cto ON ExchangeRate.[To] = cto.Id
JOIN Currency cfrom ON ExchangeRate.[From] = cfrom.Id
WHERE cfrom.[Name] = @baseCurrencyName