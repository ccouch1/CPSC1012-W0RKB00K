using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntArray
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_SIZE = 100;
            const int MIN_VALUE = 1;
            const int MAX_VALUE = 100;
            int[] randomNumbersArray = new int[MAX_SIZE];
            int number=0;
            int count = GetCountLessThanEntered(randomNumbersArray, MAX_SIZE, number);
            int sum = GetCountLessThanEntered(randomNumbersArray, MAX_SIZE, number);

            Random rnd = new Random();
 
            for (int i = 0; i < MAX_SIZE; i++)
            {
                randomNumbersArray[i] = rnd.Next(1, 101);
            }

            number = PromptForInt("Enter a positive number between 1 and 100", "That is not a valid number", MIN_VALUE, MAX_VALUE);
            
            if (count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine($"The count of numbers less than {number} is {count}");
            }

            sum = GetSumGreaterThanEntered(randomNumbersArray, MAX_SIZE, number);
           // foreach (var item in randomNumbersArray)
           // {
           //     Console.WriteLine(item);
           // }
            Console.ReadLine();
        }

       

        static int GetSumGreaterThanEntered(int[] randomNumbersArray, int MAX_SIZE, int number)
        {
            int sum = 0;
            for (int i = 0; i < MAX_SIZE; i++)
            {
                if (randomNumbersArray[i] > number)
                {
                    sum += randomNumbersArray[i];
                    if (sum == 0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        Console.WriteLine($"The sum of numbers less than {number} is {sum}");
                    }
                }
            }
            return sum; 
        }

        static int GetCountLessThanEntered(int[] randomNumbersArray, int MAX_SIZE, int number)
        {
            int count=0;
            for (int i = 0; i < MAX_SIZE; i++)
            {
                if(randomNumbersArray[i] < number)
                {
                    count++;
                }
            }
            return count;
        }

        static int PromptForInt(string message, string error, int MIN_VALUE, int MAX_VALUE)
    {
        bool validInt = false;
        int input;
        do
        {
            Console.Write(message);
            int.TryParse(Console.ReadLine(), out input);

            if (input > MIN_VALUE && input < MAX_VALUE)
            {
                validInt = true;
            }
            else
            {
                Console.Write(error);
            }
        } while (validInt == false);

        return input;
    }
    
    } 
    
               
           
}
