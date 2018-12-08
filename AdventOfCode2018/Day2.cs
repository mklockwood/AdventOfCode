using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2018
{
    public class Day2
    {
        const string puzzleInputPath = @"../../InputDocs/AoC-D2.csv";

        private Dictionary<string, int> frequencyValues;

        public Day2()
        {
            frequencyValues = new Dictionary<string, int>();
        }

        public int Puzzle1()
        {
            int linesWith3 = 0;
            int linesWith2 = 0;
            List<string> input = new List<string>();

            using (var reader = new StreamReader(puzzleInputPath))
            {
                while (!reader.EndOfStream)
                {
                    input.Add(reader.ReadLine());
                }
            }

            foreach (var row in input)
            {
                var counts = row.GroupBy(p => p)
                                  .ToDictionary(group => group.Key, group => group.Count());

                linesWith2 += counts.Any(p => p.Value == 2) ? 1 : 0;
                linesWith3 += counts.Any(p => p.Value == 3) ? 1 : 0;
            }

            return linesWith2 * linesWith3;
        }

        public string Puzzle2()
        {
            List<string> input = new List<string>();

            using (var reader = new StreamReader(puzzleInputPath))
            {
                while (!reader.EndOfStream)
                {
                    input.Add(reader.ReadLine());
                }
            }

            for (int rowNumber = 0; rowNumber < input.Count; rowNumber++)
            {
                for (int rowCompare = rowNumber + 1; rowCompare < input.Count; rowCompare++)
                {
                    Console.WriteLine($"Comparing {input[rowNumber]} and {input[rowCompare]}");

                    int numberOfDifferences = 0;
                    int indexOfDifference = 0;
                    for (int i = 0; i < input[rowNumber].Length; i++)
                    {
                        if (input[rowNumber][i] == input[rowCompare][i])
                            continue;
                        else
                        {
                            numberOfDifferences++;
                            indexOfDifference = i;
                        }
                    }

                    if (numberOfDifferences == 1)
                        return input[rowNumber].Remove(indexOfDifference, 1);

                    else
                        numberOfDifferences = 0;
                }
            }

            return "THIS IS BROKEN";
        }
    }
}
