using LABA5_SHARPI;

var telephoneExchange = new TelephoneExchange();

telephoneExchange.TariffsList.Add(new Tariffs {Area = EnumOfTariffAreas.Minsk, Price = 10});
telephoneExchange.TariffsList.Add(new Tariffs {Area = EnumOfTariffAreas.Brest, Price = 5});
telephoneExchange.TariffsList.Add(new Tariffs {Area = EnumOfTariffAreas.Homiel, Price = 15});

var valiulin = new Clients { Surname = "Валиуллин" };

valiulin.NumberOfCallsPerArea.Add(EnumOfTariffAreas.Minsk, 2);
valiulin.NumberOfCallsPerArea.Add(EnumOfTariffAreas.Brest, 3);
valiulin.NumberOfCallsPerArea.Add(EnumOfTariffAreas.Homiel, 4);

var lenin = new Clients { Surname = "Ленин" };

lenin.NumberOfCallsPerArea.Add(EnumOfTariffAreas.Minsk, 2);
lenin.NumberOfCallsPerArea.Add(EnumOfTariffAreas.Brest, 11);
lenin.NumberOfCallsPerArea.Add(EnumOfTariffAreas.Homiel, 2);
// lenin.NumberOfCallsPerArea.Add(EnumOfTariffAreas.Mogilev, 7);
// lenin.NumberOfCallsPerArea.Add(EnumOfTariffAreas.Hrodna, 6);

telephoneExchange.ClientsList.Add(valiulin);
telephoneExchange.ClientsList.Add(lenin);

Console.WriteLine("Звонки обошлись Ленину во столько:" +
                  telephoneExchange.CalculateClientCost(lenin));
Console.WriteLine("Звонки обошлись Валиуллину во столько:" +
                  telephoneExchange.CalculateClientCost("Валиуллин"));

Console.WriteLine("Всем абонентам звонки стоили столько:" + telephoneExchange.CalculateAllClientsCost());

