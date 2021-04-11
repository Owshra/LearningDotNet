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
            Console.WriteLine("Pradžia");
            Console.WriteLine();
            Console.WriteLine("Pirmoji užduotis");
            Console.WriteLine();

            String[] FiveWords = new String[5];
            FiveWords[0] = "PirmasAK";
            FiveWords[1] = "AntrasAK";
            FiveWords[2] = "TrečiasAK";
            FiveWords[3] = "KetvirtasAK";
            FiveWords[4] = "PenktasAK";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kelintas čia žodis? -{FiveWords[i]}");
 //             Console.WriteLine("Kelintas čia žodis? -{0}", FiveWords[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Antroji užduotis");
            Console.WriteLine();

            int[] TwentyNumbersAndAZero = new int[21];
            for (int i = 0; i < 21; i++)
            {
                TwentyNumbersAndAZero[i] = i;
            }

            for (int i = 20; i > (-1); i--)
            {
                Console.WriteLine(TwentyNumbersAndAZero[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Pabaiga");
            Console.WriteLine();
            Console.WriteLine("By Aušra K./Owshra");
            Console.ReadKey();
        }
    }
}
