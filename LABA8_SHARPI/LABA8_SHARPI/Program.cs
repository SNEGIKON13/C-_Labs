using LABA8_SHARPI;

ATS atc = new ATS();

atc.AddRegularTariff("Regular Tariff 1", 100);
atc.AddRegularTariff("Regular Tariff 2", 150);

atc.AddDiscountedTariff("Discounted Tariff 1", 200, 0.1);
atc.AddDiscountedTariff("Discounted Tariff 2", 250, 0.2);

double averageCost = atc.CalculateAverageCost();
Console.WriteLine("Средняя стоимость тарифов: " + averageCost);