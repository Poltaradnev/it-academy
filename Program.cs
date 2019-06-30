using System;

namespace Преобразование_типов
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                decimal x = 7.999m;
                short a;
                // Cast decimal to short.
                a = (short)x;
                System.Console.WriteLine(a);

            }
            {
                double x = 13.9;
                int a;
                // Сast double to int.
                a = (int)x;



                System.Console.WriteLine(a);
            }
            {
                short x = 266;
                byte a;
                // Cast byte to short.
                a = (byte)x;
                System.Console.WriteLine(a);



            }
            { sbyte x = 124;
                int a;
                a = (int)x;
                System.Console.WriteLine(a);

            }
            { byte a = 7;
                byte b = 70; //77
                int c = a + b;
               
                System.Console.WriteLine(c);

            }
            { sbyte a = 80;
                sbyte b = 90;
                int c = a + b;
                System.Console.WriteLine(c);

            }
            { int i = 140;
                object o = i;
                System.Console.WriteLine(o);


                o = 140;
                i = (int)o; //unboxing
                System.Console.WriteLine(o);



            }
        }
    }
}
