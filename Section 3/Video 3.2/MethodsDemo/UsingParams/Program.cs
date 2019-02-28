using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingParams
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[3];
            //numbers[0] = 1;
            //numbers[1] = 5;
            //numbers[2] = 10;

            int[] numbers = new int[3] { 1,5,10};
            PrintIntArray(numbers);
            PrintIntArrayUsingParams(1, 3, 6, 7, 8);
        }

        static void PrintIntArray(int[] numbers)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Method: PrintIntArray");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Integer Array Element: {numbers[i]}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void PrintIntArrayUsingParams(params int[] numbers)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Method: PrintIntArrayUsingParams");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Integer Array Element: {numbers[i]}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
