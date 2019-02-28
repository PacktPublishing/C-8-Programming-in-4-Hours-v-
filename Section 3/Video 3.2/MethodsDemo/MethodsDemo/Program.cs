using System;


namespace MethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int f1 = 10; int s1 = 20;
            int result1 = f1 + s1; // 30

            int f2 = 40; int s2 = 65;
            int result2 = f2 + s2; //105

            int result = Add(f2, s2);

            Console.WriteLine(result == result2);//True
            PrintMessage("Add method runs successfully");
        }

        // (AccessModifier) returnType MethodName (parameters)
        /// <summary>
        /// This method adds two integer numbers and returns the result.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>intger</returns>
        static int Add(int first, int second)
        {
            int result = first + second;
            return result;
        }

        static void PrintMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
