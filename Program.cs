﻿using System;

namespace hometask3._2
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
            Console.WriteLine("a + b =");
            Console.WriteLine(x);
        }
              
    }
}
