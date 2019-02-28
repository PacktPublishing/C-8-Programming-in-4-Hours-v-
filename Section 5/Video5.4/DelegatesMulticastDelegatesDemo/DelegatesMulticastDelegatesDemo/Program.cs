using System;


namespace DelegatesMulticastDelegatesDemo
{
    class Program
    {
        //Type - defines a method signature(return type and parameter)
        //Can refer any method that matches the method signature defined by Delegate.
        delegate int Calculate(int first, int second);
        delegate void PrintDel(string message);
        static void Main(string[] args)
        {
            int i1 = 20, i2 = 10;
            Calculate cal = new Calculate(Add);
            //Calculate cal = Add;

            //Calculate cal = new Calculate(Subtract);
            //Calculate cal = Subtract;

            int result = cal(i1, i2);
            //int result = cal.Invoke(i1, i2);
            Console.WriteLine($"Calculation result {result}");

            PrintDel log = PrintToConsoleLog;
            log += PrintToEventLog;

            log("Test Log message");
        }

        static void PrintToConsoleLog(string msg)
        {
            Console.WriteLine($"\nPrinting to console window: {msg}");
        }

        static void PrintToEventLog(string msg)
        {
            Console.WriteLine($"\nPrinting to window event log: {msg}");
        }

        static int Add(int x, int y)
        {
            Console.WriteLine("Executing Add Method");
            return x + y;
        }

        static int Subtract(int x, int y)
        {
            Console.WriteLine("Executing Subtract Method");
            return x - y;
        }
    }
}
