using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter character to move");
            string char1 = Console.ReadLine();
            Char char2 = Convert.ToChar(char1);

            if (char2.Equals('w'))
            {
                Console.WriteLine("you go forward");
            }
            else if (char2.Equals('s'))
            {
                Console.WriteLine("you go back");
            }
            else if (char2.Equals('a'))
            {
                Console.WriteLine("you go left");
            }
            else if (char2.Equals('d'))
            {
                Console.WriteLine("you go right");
            }
            else  
            {
                Console.WriteLine("incorrect command");
            }                
        }
    }
}
