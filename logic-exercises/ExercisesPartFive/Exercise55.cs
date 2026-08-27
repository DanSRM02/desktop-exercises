namespace ExercisesPartFive;

class Exercise55
{
  public static void CalculateLoan()
  {
    Console.WriteLine("Enter total amount loan");
    int.TryParse(Console.ReadLine(), out int amountLoan);

    int counter = 0;

    do
    {
      Console.WriteLine("Enter you amount for payment");
      int.TryParse(Console.ReadLine(), out int amountPayment);

      amountLoan -= amountPayment;
      counter++;

      Console.WriteLine($"you current balance it the total of {amountLoan}");

    } while (amountLoan > 0);

    Console.WriteLine($"You've paid all! In {counter} payments");
  }
}