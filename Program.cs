Console.WriteLine("Which exercise do you want to run? (1-100)");
string input = Console.ReadLine() ?? "empty";

switch (input)
{
    case "1":
        Exersice23.CalculateRabbitPopulation(15000, 7000);
        break;
    default:
        Console.WriteLine("Exercise not found.");
        break;
}