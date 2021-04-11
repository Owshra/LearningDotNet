using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pradžia\n\nPirmoji užduotis\n");

            string[] FiveWords = new String[5]{ "PirmasAK", "AntrasAK", "TrečiasAK", "KetvirtasAK", "PenktasAK" };
            foreach (string i in FiveWords)
            {
                Console.WriteLine($"Kelintas čia žodis? -{i}");
            }

            Console.WriteLine("\nAntroji užduotis\n");

            int[] TwentyNumbersAndAZero = new int[21];
            for (int i = 0; i < 21; i++)
            {
                TwentyNumbersAndAZero[i] = i;
            }

            foreach (int i in TwentyNumbersAndAZero.Reverse())
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nPabaiga\n\nBy Aušra K./Owshra");
            Console.ReadKey();
        }
    }
}
