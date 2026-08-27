namespace ExercisesPartSeven;

class Exercise73
{
  public static void CalculateFactorialNumber()
  {
    Console.WriteLine("Enter a number to know its factorial result");
    int.TryParse(Console.ReadLine(), out int iterator);

    int accumulator = 1;

    for (int i = 1; i <= iterator; i++)
    {
      accumulator *= i;
    }

    Console.WriteLine($"Result:{accumulator} Number:{iterator}");
  }
}