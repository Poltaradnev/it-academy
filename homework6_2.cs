using System;



namespace homewor6_2

{

    class Program
    {
        static void Main(string[] args)
        {
            const int w = 3;
           int[] manualinput = new int[w];    

            Console.WriteLine("Enter {0} times any number:", w - 1);
            for (int s = 0; s < w - 1; s++)
            {
                manualinput[s] = Convert.ToInt32(Console.ReadLine());
                if (s < w - 2) { Console.WriteLine("One more, please, only {0} insertions left", w - s - 1); }
            }   
                      
            for (int s = 0; s < w; s++)                
            Console.Write(manualinput[s] + "\n");              
                       
            Console.WriteLine("Enter another array value");
            int value = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(" Cell with which number will replace this cell?\nThe first one is 0 index, remember, please");
            int position = Convert.ToInt16(Console.ReadLine());            
            for (int i = 0; i < w; i++)
            {
                if (i == position)
                {
                    for (int s = w - 1; s > i; s--)
                    {
                        manualinput[s] = manualinput[s - 1];
                    }
                    manualinput[i] = value;
                }
                Console.WriteLine(manualinput[i]);
            }

        }

    }

}