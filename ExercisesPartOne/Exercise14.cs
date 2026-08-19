namespace ExercisesPartOne;

class Exercise14
{
    public static void CalculateFibonacci()
    {
        int nextValue = 0;
        int currentValue = 1;
        int prevValue = 0;

        Console.WriteLine("Enter the number of population from yesterday");
        int iterator = int.Parse(Console.ReadLine());

        for (int i = 0; i <= iterator; i++)
        {
            Console.WriteLine($"{prevValue}");

            nextValue = currentValue + prevValue;
            prevValue = currentValue;
            currentValue = nextValue;
        }
    }
}