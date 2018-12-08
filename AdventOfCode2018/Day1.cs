using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2018
{
    public class Day1
    {
        const string puzzleInputPath = @"../../InputDocs/AoC-D1.csv";
       
        private List<int> frequencyValues;
        private int frequency = 0;

        public Day1()
        {
            frequencyValues = new List<int>();
        }

        public int Puzzle1()
        {
            int returnValue = 0;
            using (var reader = new StreamReader(puzzleInputPath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    returnValue += int.Parse(line);
                }
            }

            return returnValue;
        }

        public int Puzzle2()
        {
            using (var reader = new StreamReader(puzzleInputPath))
            {
                while (!reader.EndOfStream)
                {
                    if (frequencyValues.Contains(frequency))
                        return frequency;
                    else
                        frequencyValues.Add(frequency);

                    var line = reader.ReadLine();
                    frequency += int.Parse(line);
                }
            }

            return Puzzle2();
        }
    }
}
