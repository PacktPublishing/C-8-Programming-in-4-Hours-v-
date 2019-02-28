using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemoApp
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
            int[] intArray = new int[4] { 10, 20, 5, 30 };
            //intArray[0] = 10;
            //intArray[1] = 20;
            //intArray[2] = 5;
            //intArray[3] = 30;

            //Console.WriteLine($"Array first element is {intArray[0]}");
            //Console.WriteLine($"Array second element is {intArray[1]}");

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine($"Array element is {intArray[i]}");
            }

            foreach (int item in intArray)
            {
                Console.WriteLine($"Array element is {item}");
            }

            Console.WriteLine();
            string[] stringArray = new string[5];
            Person[] people = new Person[2];
            Person p1;
            p1.FirstName = "John";
            p1.LastName = "Smith";

            Person p2;
            p2.FirstName = "Sam";
            p2.LastName = "Smith";
            people[0] = p1;
            people[1] = p2;

            foreach (var item in people)
            {
                Console.WriteLine($"{item.LastName}, {item.FirstName}");
            }

            System.Array.Sort(intArray);

            Console.WriteLine("After Sorting");
            foreach (int item in intArray)
            {
                Console.WriteLine($"Array element is {item}");
            }


        }
    }
}
