using System;

namespace hometask6_1
{
    class Program
    {
        private static int summing(int x, int y)
        { return x + y; }

        static void Main(string[] args)

        {
            const int const1 = 1;
            Random rand = new Random();
            int[] random_number = new int[const1];
            int[] entered_number = new int[const1];
            int[] total_amount = new int[const1];
            for (int i = 0; i < const1; i++) random_number[i] = rand.Next(1, 100);            
            Console.WriteLine("Enter {0} random value:", const1);
            for (int s = 0; s < const1; s++)
            {
                entered_number[s] = Convert.ToInt32(Console.ReadLine());
                if (s < const1 - 1)
                { Console.WriteLine(const1 - s - 1); }
            }         

            for (int i = 0; i < const1; i++)
            {
               total_amount[i] = summing(random_number[i], entered_number[i]);
            }           
            Console.WriteLine("  \nrandom_number    " + "   entered_number   " + "   Total_amount  ");            
            for (int s = 0, d = 0, w = 0; s < const1; s++, d++, w++)
            {
                Console.Write(random_number[s] + "    \t");
                Console.Write("            " + entered_number[d] + "\t");
                Console.WriteLine("                 " + total_amount[w]);
            }

        }

    }

}
