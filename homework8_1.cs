using System;

namespace homework8_1
{

    class Program

    {

        static void Main(string[] args)

        {
            Console.WriteLine("Enter sentence,if you want to enter several sentences, separate them(;)");
            string[] letters = Console.ReadLine().Replace('o', 'A').Split(';');
            foreach (var letter  in letters )
            {
                Console.WriteLine($"{letter}");
            }

        }

    }

}

