using System;

namespace hometask3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number a?");
            string a = Console.ReadLine();
            Int32 d = Convert.ToInt32(a);
            Console.WriteLine("Number b?");
            string b = Console.ReadLine();
            Int32 c = Convert.ToInt32(b);
            Int32 x = c + d;
            Console.WriteLine("a + b?");
            string e = Console.ReadLine();
            Int32 f = Convert.ToInt32(e);
            Console.WriteLine(f.Equals(x));
            if (f < x)
            {
                Console.Write("Should be more");
            }
            if (f > x)
            {
                Console.Write("Should be less");
            }


        }
    }
}
