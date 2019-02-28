using System;


namespace EnumsDemoApp
{
    enum Directions
    {
        East = 1,
        West,
        North,
        South
    }
    class Program
    {
        static void Main(string[] args)
        {
            int northVal = (int)Directions.North;
            Console.WriteLine($"Enum Directions.North has value as {northVal}");

            Directions parsedDirection;
            Enum.TryParse("abc", out parsedDirection);

            int parsedVal = (int)parsedDirection;
            Console.WriteLine($"Parsed enum value: {parsedVal}");

        }
    }
}
