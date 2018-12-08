using System;

namespace AdventOfCode2018
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Day2 day = new Day2();
            var result = day.Puzzle2();

            Console.WriteLine(result);
            System.IO.File.WriteAllText(@"CopyAnswersFromHere.txt", result.ToString());

            Console.WriteLine("Any key to exit...");
            Console.ReadKey();
        }
    }
}
