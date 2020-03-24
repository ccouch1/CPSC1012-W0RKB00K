using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPollution
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_SIZE = 6;
            int[] pollutionLevel = new int[MAX_SIZE];

            for (int i = 0; i < MAX_SIZE; i++)
            {
                Console.Write($"Enter the Pollution Level {i+1} Reading: ");
                pollutionLevel[i] = int.Parse(Console.ReadLine());

            }
            //display back to user
            Console.WriteLine("The six pollution levels are: ");
            for (int i = 0; i < pollutionLevel.Length; i++)
            {
                Console.WriteLine(pollutionLevel[i] + " ");
            }
            Console.Write("The Average pollution is: ");
            int pollutionLevelSum = 0, pollutionLevelAverage;

            for (int i = 0; i < pollutionLevel.Length; i++)
            {
                pollutionLevelSum += pollutionLevel[i];
            }
            pollutionLevelAverage = pollutionLevelSum / pollutionLevel.Length;

            Console.Write(pollutionLevelAverage);

            //display highest and lowest

            int largest = pollutionLevel[0];
            int smallest = pollutionLevel [0];

            for (int i = 0; i < MAX_SIZE; i++)
            {
                if(pollutionLevel[i] > largest)
                {
                    largest = pollutionLevel[i];
                }
                if (pollutionLevel[i] < smallest)
                {
                    smallest = pollutionLevel[i];
                }
            }
            Console.WriteLine($"the Smallest is {smallest} and the largest is {largest}");

            Console.ReadKey();
        }
    }
}
