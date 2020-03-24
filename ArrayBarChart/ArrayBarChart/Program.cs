using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBarChart
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBars;
            const int MAX_SIZE = 10;

            int[] intergerArray = new int[MAX_SIZE];

            Console.Write("Enter number of bars (up to 10): ");
            numberOfBars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfBars;  i++)
            {
                Console.Write("Enter a number: ");
                intergerArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numberOfBars; i++)
            {
                Console.Write("|");
                for (int j = 0; j < intergerArray[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
