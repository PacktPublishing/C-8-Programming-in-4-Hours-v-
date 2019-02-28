using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    public struct Person
    {
        public string FirstName;
        public string LastName;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 10; // Break point press F9, Step into F11, Step over F10
            //string name = "John";
            //Person p1;
            //p1.FirstName = "John";
            //p1.LastName = "Smith";
            //int result = Add(10, 20);

            //Unhandled Exception: System.DivideByZeroException: Attempted to divide by Zero.


            try
            {
                int number = 10; // Break point press F9, Step into F11, Step over F10
                Console.Write("Enter the number you want to divide with :");
                int val = Convert.ToInt32(Console.ReadLine());
                int result = number / val;
                int[] randomNumbers = new int[2] { 2, 3 };
                Console.WriteLine($"An integer in randomNumbers array is:{randomNumbers[2]}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Result:{result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You cannot divide an interger by ZERO");
                Console.ForegroundColor = ConsoleColor.White;  
                
                //WRite to Windows.Events
                //Write details to log file
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Index out of boundary");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"An exception occured in app:{ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }

            Console.WriteLine("Hello World");
            Console.ReadLine();


        }

        static int Add(int f1, int f2)
        {
            return f1 + f2;
        }
    }
}
