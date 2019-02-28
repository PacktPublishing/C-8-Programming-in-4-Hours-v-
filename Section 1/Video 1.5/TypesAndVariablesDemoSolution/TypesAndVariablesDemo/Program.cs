using System;

namespace TypesAndVariablesDemo
{
    public struct Customer
    {
        public int Age;
        public string Name;
        public bool IsEmployee;
    }
    class Program
    {
        static void Main(string[] args)
        {
            const string ORGANIZATION_NAME = "ABC Consultants";

            //int age = 35;
            //string name = "John Smith";
            //bool isEmployee = true;
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine(name + " is " + age + " years old.");
            //Console.WriteLine("Is he an employee? " + (isEmployee? "Yes": "No"));
            //Console.ForegroundColor = ConsoleColor.White;

            Customer cust;
            cust.Age = 35;
            cust.Name = "John Smith";
            cust.IsEmployee = false;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(cust.Name + " is " + cust.Age + " years old.");
            Console.WriteLine("Is he an employee? " + (cust.IsEmployee ? "Yes" : "No"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(ORGANIZATION_NAME);
        }
    }
}
