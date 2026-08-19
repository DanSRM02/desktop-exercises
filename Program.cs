Console.WriteLine("Which exercise do you want to run? (1-100)");
string input = Console.ReadLine() ?? "empty";

switch (input)
{
    case "23":
        ExercisesPartTwo.Exercise23.CalculateRabbitPopulation();
        break;
    case "14":
        ExercisesPartOne.Exercise14.CalculateFibonacci();
        break;
    case "73":
        ExercisesPartSeven.Exercise73.CalculateFactorialNumber();
        break;
    default:
        Console.WriteLine("Exercise not found.");
        break;
}