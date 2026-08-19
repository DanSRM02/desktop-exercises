Console.WriteLine("Hello, World!");

static string CalculateRabbitPopulation(int today_population, int yesterday_population)
{
  int counter = 0;
  int tomorrow_population = 0;

  while (tomorrow_population < 70000)
  {
    tomorrow_population = today_population + yesterday_population;
    yesterday_population = today_population;
    today_population = tomorrow_population;
    counter++;
  }

  return $"day to export rabbit remaning {counter}";
}

Console.WriteLine(CalculateRabbitPopulation(15000, 25000));