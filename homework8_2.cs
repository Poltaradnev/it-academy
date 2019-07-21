using System;
using System.Linq;

namespace homework8_2
{
    class Program

    {

        static void Main(string[] args)

        {          

            Console.WriteLine("Enter sentences to count letters and punctuation signs");
            string s = Console.ReadLine(); 
            string[] words = s.Split(' ');
            int c = words.Count();
            string[] words2 = new string[c - 1];
            int[] letters = new int[c];
            for (int i = 0; i < c; i++) letters[i] = words[i].Length;
            Console.WriteLine("------Array processing------");
            for (int i = 0; i < letters.Length; i++)
            {
                Array.Sort(letters, words);
                Console.WriteLine(words[i] + " " + i);
            }
            // Task1 Finding the longest word
            for (int i = 0; i < words2.Length; i++)
            {
                words2[i] = words[i + 1];
            }
            for (int i = 0; i < words2.Length; i++)
                Console.WriteLine(words[i] + " " + i);
            // Task2 Replacing the longest word with the shortest one
            Console.WriteLine("-------Replacing long word places with short-----");
            for (int i = 0; i < words.Length; i++)
            {
                if (i.Equals(0))
                {
                    string first = Convert.ToString(words[0]);
                    string last = Convert.ToString(words[c - 1]);
                    words[0] = last;
                    words[c - 1] = first;
                    break;
                }
            }
            //  Output of results
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i] + " " + i);
            }

            // Task3 Calculating letters and punctuation marks
            Console.WriteLine("--------Calculating letters and punctuation marks------");
            Console.WriteLine(s.Count(char.IsLetter) + "Number of letters"); 
            Console.WriteLine(s.Count(char.IsPunctuation) + "Number of punctuation marks");

            //Task4 Sorting array descending
            Console.WriteLine("------Sorting array descending-------");
            Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));
            Array.Reverse(words);
            int f = 0;
            foreach (string st in words)
            {
                Console.WriteLine(st + " " + f);
                f++;
            }          

        }

    }

}
