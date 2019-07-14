using System;

namespace hometask5._1
{
    class Program

    {

        static void Main(string[] args)

        {
            do
            {
                Console.WriteLine("Enter yer of birth");
                int YearOfBorn = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter month of birth");
                int MonthOfBorn = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the actual year");
                int YearNow = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number of actual month");
                int MonthNow = Convert.ToInt32(Console.ReadLine());
                int YearsOld = YearNow - YearOfBorn - 1;
                if (YearsOld >= 0)
                {
                    int ExtraYear = MonthNow - MonthOfBorn;
                    if (ExtraYear >= 0)

                    {
                        Console.WriteLine($"The person have {++YearsOld} years old. ");                            
                    }
                    else
                    {
                        Console.WriteLine($"The person have {YearsOld} years old. " +

                            $"\nPress 'enter' to try again or another button + 'enter' to stop.");
                    }

                }               

            }

            while (Console.ReadKey(true).Key == ConsoleKey.Enter);
            Console.Read();

        }

    }

}
