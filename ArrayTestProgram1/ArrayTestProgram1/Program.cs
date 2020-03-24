using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTestProgram1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_ARRAY_SIZE = 100;

            double[] scoreArray = new double[MAX_ARRAY_SIZE];
            double sum = 0, avg;
            int numberOfScores;

            Console.Write("Enter the number of Scores: ");
            numberOfScores = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfScores; i++)
            {
                Console.Write("Enter a Score: ");
                scoreArray[i] = double.Parse(Console.ReadLine());
                sum += scoreArray[i];
            }

            avg = sum / numberOfScores;
            Console.Write("You entered these numbers: ");
            foreach (var item in scoreArray)
            {
                Console.Write(item + " ");
            }


            Console.WriteLine("The Average is:" + avg);
            Console.ReadLine();


        }
    }
}
