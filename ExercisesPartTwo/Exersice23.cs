namespace ExercisesPartTwo;

public class Exercise23
{
  public static void CalculateRabbitPopulation(int today_population, int yesterday_population)
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

    

    Console.WriteLine($"day to export rabbit remaning {counter}");
  }

}