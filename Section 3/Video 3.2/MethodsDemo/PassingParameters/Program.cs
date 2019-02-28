using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 10;
            MethodByVal(10);
            Console.WriteLine($"Parameters by Value {first}"); // 10

            int second = 10;
            MethodByRef(ref second);
            Console.WriteLine($"Parameters by Reference {second}"); //20

            int third;
            MethodByOut(out third);
            Console.WriteLine($"Parameters by Reference(out) {third}"); //30

            //Directions directVal;
            //Enum.TryParse("East", out directVal);
        }

        static void MethodByVal(int first)
        {
            first = 20;
        }

        static void MethodByRef(ref int first)
        {
            first = 20;
        }

        static void MethodByOut(out int first)
        {
            first = 30; // Compile Error if 'first' is not assigned any value.
        }

        static void MethodUsingIn(in int number)
        {
            //number = 12;
        }
    }
}
