using AbstructFactoryDPby_compbelltech.Services;

Country country = Country.Spain;

IInternationalFactory factory = InternationalProvider.Create(country);

ILanguege languege = factory.CreateLanguege();
ICapitalCity capitalCity = factory.CreateCapitalCity();


Console.WriteLine($"Country Name: {country}");

Console.WriteLine(capitalCity.GetType().Name);

languege.WelcomeMessage();

Console.WriteLine("Total Population: " + capitalCity.GetPopulation());
Console.WriteLine("Top Attractions: " + string.Join(", ", capitalCity.ListTopAttractions()));

Console.ReadLine();

