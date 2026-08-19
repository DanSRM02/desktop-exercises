namespace ExercisesPartOne;

class Exercise14
{
    public static void CalculateFibonacci(int iterator)
    {
        int nextValue = 0;
        int currentValue = 1;
        int prevValue = 0;

        for (int i = 0; i <= iterator; i++)
        {
            Console.WriteLine($"{prevValue}");

            nextValue = currentValue + prevValue;
            prevValue = currentValue;
            currentValue = nextValue;

        }
    }
}