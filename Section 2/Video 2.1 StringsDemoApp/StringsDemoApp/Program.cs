using System;
using System.Text;

namespace StringsDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char charA = 'a';
            //char.ToUpper(charA); 
            Console.WriteLine("Charter charA in upper case char.ToUpper(charA) = " + char.ToUpper(charA));

            //char.ToLower

            //Escape Sequence
            // '\n' -- New Line
            // '\t' -- tab
            // \\

            string name = "John Smith";
            Console.WriteLine(name);

            //Escape sequence for new line.
            string sentence = "My name is John.\nI am a doctor.";
            Console.WriteLine(sentence);

            //Empty Strings or strings with Length as Zero.
            string emptyStringOne = "";
            string emptyStringTwo = string.Empty;

            Console.WriteLine(emptyStringOne.Length);
            Console.WriteLine(emptyStringTwo.Length);

            //Null Strings
            string nullString = null;
            //Console.WriteLine(nullString.Length); // This will give null Reference Error

            //Contains method
            Console.WriteLine("Contains Method: " + sentence.Contains("John"));

            //Starts With
            Console.WriteLine("StartsWith Method: " + sentence.StartsWith("My"));

            //Ends With
            Console.WriteLine("EndsWith Method: " + sentence.EndsWith("doctor"));

            //IndexOf
            Console.WriteLine("Index of John: " + sentence.IndexOf("John"));

            //LastIndexOf
            Console.WriteLine("Last Index of John: " + sentence.LastIndexOf("John"));

            //substring, position, length
            string subStringValue = sentence.Substring(0, 15);//My name is John
            Console.WriteLine("Substring with sentence.Substring(0, 15) : " + subStringValue);

            string insertedString = sentence.Insert(16, ",I am from Texas ");
            Console.WriteLine(insertedString);

            string removedString = insertedString.Remove(16, 17);
            Console.WriteLine(removedString);

            Console.WriteLine("John,Bill,Sam".Replace(',', '*'));

            //Concatenation
            string first = "John";
            string second = "Smith";

            string result = first + second;


            StringBuilder sb = new StringBuilder();
            sb.Append(first);
            sb.Append(second);

            string appendedString = sb.ToString();

            Console.WriteLine(appendedString);

            ////String Formatting
            Console.Write("What is your name: ");
            string userName = Console.ReadLine();
            Console.Write("\nWhat is your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(string.Format("Hello {0}, how are you doing? As you said, you are {1} years old", userName, age));
            //Console.WriteLine();

            decimal price = 2.5m;
            Console.WriteLine(string.Format("Currency Format: {0:C2}", price));

            DateTime todaysDate = DateTime.Now;
            Console.WriteLine(string.Format("Today's Date {0:d} at {0:t}", todaysDate));

            //Interpolation
            Console.WriteLine(string.Format($"Hello {userName}, how are you doing? As you said, you are {age} years old"));            
            //Console.WriteLine();

        }
    }
}
