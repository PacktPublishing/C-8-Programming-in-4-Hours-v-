using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // For Commenting: Ctrl + k + c
            // For uncommenting : Ctrl + k + u\

            //Console.WriteLine("Hello World");
            //string name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello " + name);

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
    }
}
