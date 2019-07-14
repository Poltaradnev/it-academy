using System;

namespace hometask5._2
{

    class Program

    {

        static void Main(string[] args)

        {
            do
            {
                Console.WriteLine("Enter how much money is the accaunt");
                double initial_contribution = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the number of months to calculate the amount");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter account interest %");
                double InterestRate = Convert.ToDouble(Console.ReadLine());
                double InterestRateIncome = 0, TotalSum = initial_contribution;
                if (initial_contribution < 0 || month < 0 || InterestRate < 0)
                {
                    Console.WriteLine("Invalid data entered! " +
                        "\nPress 'enter' to try again or another button +'enter' to stop.");
                }
                else
                {
                    Console.WriteLine("increase in the amount of the deposit");
                    for (int i = 1; i <= month; i++)
                    {
                        InterestRateIncome = TotalSum * (InterestRate / 100 / 12);
                        TotalSum = TotalSum + InterestRateIncome;
                        Console.Write("{0: #.##}, ", InterestRateIncome);
                    }
                    Console.WriteLine("\nThe amount of the initial deposit {2}, " +
                        "Interest rate {3: #.##}% after {0} months = {1: #.##} " +
                        "\nPress 'enter' to try again or another button +'enter' to stop.", month, TotalSum, initial_contribution, InterestRate);
                }
            }
            while (Console.ReadKey(true).Key == ConsoleKey.Enter);
            Console.Read();
        }
    }
}


