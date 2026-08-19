Console.WriteLine("Which exercise do you want to run? (1-100)");
string input = Console.ReadLine() ?? "empty";

switch (input)
{
    case "23":
        ExercisesPartTwo.Exercise23.CalculateRabbitPopulation(15000, 7000);
        break;
    case "14":
        ExercisesPartOne.Exercise14.CalculateFibonacci(5);
        break;
    default:
        Console.WriteLine("Exercise not found.");
        break;
}