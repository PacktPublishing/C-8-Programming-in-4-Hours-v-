using System;

namespace AnonymousMethodsDemoApp
{
    class Program
    {
        delegate void PrintDelegate(string param);
        static void Main(string[] args)
        {
            //PrintDelegate del = PrintInformation;
            //LogAndPrintInformation(del);

            //Syntax: delegate (params) { }
            int n = 0;
            LogAndPrintInformation(delegate (string parameter) {
                n++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"PrintInformation with parameter: {parameter} ");
                Console.ForegroundColor = ConsoleColor.White;
            });
        }

        static void LogAndPrintInformation(PrintDelegate print)
        {
            print("This is Anonymous Method demo app");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Logging to console window.\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void PrintInformation(string parameter)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"PrintInformation with parameter: {parameter} ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
