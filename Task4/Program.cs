var country1 = new Country("Tajikistan", "Dushanbe", 9537645, "Tajik");

country1.SetCapital("Dushanbe");
System.Console.WriteLine($"Capital: {country1.GetCapital()}");
country1.SetPopulation(9537645);
System.Console.WriteLine($"Population: {country1.GetPopulation()}");
country1.SetOfficialLanguage("Tajik");
System.Console.WriteLine($"Official Language: {country1.GetOfficialLanguage()}");

