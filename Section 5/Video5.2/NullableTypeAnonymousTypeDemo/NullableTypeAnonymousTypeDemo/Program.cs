using System;

namespace NullableTypeAnonymousTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Type, Reference type

            int? i = null;
            bool? flag = null;

            if (flag.HasValue)
            {
                bool test = flag.Value;
            }

            //Anonymous Types

            var anonymousTypeVariable = new { CompanyName = "ABC Corp", Year = 1998 };

            Console.WriteLine(anonymousTypeVariable.CompanyName);
            Console.WriteLine(anonymousTypeVariable.Year);

            var iSample = 10;
            var strSample = "John";
        }
    }
}
