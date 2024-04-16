using LABA4_SHARPI;

TelephoneExchange telephoneExchange = TelephoneExchange.Instance("МТС", 10, 10);

telephoneExchange.PriceUp();
telephoneExchange.PriceUp();
telephoneExchange.PriceUp(30.54);
telephoneExchange.PriceDown();
telephoneExchange.PriceDown(11.54);
Console.WriteLine($"Адрес АТС: {telephoneExchange}, другой вывод: {telephoneExchange.Address}");
Console.WriteLine($"Абонентская плата для всех тарифов: {telephoneExchange.EstimateAbonentsFee()}");
Console.WriteLine($"Стоимость тарифа: {telephoneExchange.GetPriceOfTheTariff()}");
Console.WriteLine($"Количество абонентов: {telephoneExchange.NumberOfSubscribers}");