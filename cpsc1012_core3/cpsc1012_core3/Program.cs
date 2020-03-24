using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc1012_core3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hits;
            int digit;
            string name;
            char playAgain=' ';
            Console.WriteLine("==Welcome to Master-Mined==");
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Welcome {0}.", name);
            playGame(name);
            do
            {
                Console.WriteLine("Play Again? Y/N");
                playAgain= char.Parse(Console.ReadLine());
            } while (playAgain == 0);
           
            
        }
        
        static int[] GetUserGuess(int userSize)
        {
            int number = 0;
            int[] userGuess = new int[userSize];
            for (int i = 0; i < userGuess.Length; i++)
            {
                Console.Write("Digit {0}; ", (i + 1));
                number = int.Parse(Console.ReadLine());
                userGuess[i] = number;
            }
            Console.WriteLine();
            Console.Write("Your guess: ");
            for (int i = 0; i < userGuess.Length; i++)
            {
                Console.Write(userGuess[i] + " ");
            }
            Console.ReadLine();
            return userGuess;
        }

        static int GetRandomNumberCount(int numberCount)
        {
            int number = 4;
            number=GetAValidNumber("How many numbers would you like to play with (4-10)?", 4, 10);
            return number;
        }
        static int GetGameDifficulty(int difficultyLevel)
        {
            int input, difficulty = 0;
            //do
            //{
            //    try
            //    {
            //        Console.Write("Choose a diffculty level (1= Hard, 2= Medium, 3=Easy)?");
            //        //difficulty = int.Parse(Console.ReadLine());
            //        if (int.TryParse(Console.ReadLine(), out input) == true)
            //        {
            //            difficulty = input;
            //        }
            //    }
            //    catch
            //    {
            //        Console.Write("       Incorrect entry: Please enter a valid Difficulty");
            //    }
            //} while ((difficulty < 1) || (difficulty > 3));
            return GetAValidNumber("Choose a diffculty Level (1= Hard, 2= Medium, 3=Easy)?",1,3);
        }

        static int GetAValidNumber(string prompt, int min, int max)
        {
            bool validInt = false;
            int validNumber;
            do
            {
                Console.Write(prompt);
                int.TryParse(Console.ReadLine(), out validNumber);

                if (validNumber >= min && validNumber <= max)
                {
                    validInt = true;
                }
                else
                {
                    Console.Write("\tIncorrect entry: Please re-enter");
                }
            } while (validInt == false);

            return validNumber;
        }

        static int CountHits(int[] computerArray, int[] userArray, int attempts)
        {
            int hit = 0;
            int miss = 0;
            for (int i = 0; i < computerArray.Length; i++)
            {

                if (computerArray[i] == userArray[i])
                {
                    hit = hit + 1;
                   
                }
                else
                {
                    miss = miss + 1;
                }
            }
            Console.WriteLine("Results: {0} Hit(s), {1} Miss(es)", hit, miss);
            return hit;
        }

        public static int[] GenerateRandomNumbers(int PCSize)
        //public static int GenerateRandomNumbers()
        {
            int eachNumber;
            int[] randomNumber = new int[PCSize];
            Random rnd = new Random();
            for (int i = 0; i < randomNumber.Length; i++)
            {
                eachNumber = rnd.Next(1, 5);
                randomNumber[i] = eachNumber;

            }
            //Console.ReadLine();
            return randomNumber;
            //return rnd.Next(1, 5);
        }
        static void playGame(string name)
        { 
            int numberCount = 0;
            int difficultyLevel = 0;
            int difficulty = GetGameDifficulty(difficultyLevel);
            int digitNumber = GetRandomNumberCount(numberCount);
            int[] userArray = GetUserGuess(digitNumber);
            int attempts = difficulty * digitNumber;
            int remaining = attempts;
            int[] pcArray = GenerateRandomNumbers(digitNumber);
            int hits = CountHits(pcArray, userArray, attempts);
            
        Console.Write(digitNumber + " it is. Let's play.");
            Console.WriteLine();
        Console.WriteLine("A " + digitNumber + "-digit number has been chosen. Each possible digit may be the number 1, 2, 3 or 4.");
            Console.WriteLine("    ******");
            do
            {

            }
            while()
            {

            }
            //for (int i = 0; i<attempts; i++)
            //{
               

            //    if ((hits != pcArray.Length) && (attempts > 0))
            //    {
            //        attempts--;
            //        Console.WriteLine("Enter your guess ({0} guesses remaining)", attempts);
            //    } else if ((attempts< 1))
            //    {
            //        Console.WriteLine("{0} couldn't get the right number. {0} should play games like this more oftern", name, name);
            //        Console.WriteLine("This is the right number: ");
            //        for (int j = 0; j<pcArray.Length; j++)
            //        {
            //            Console.WriteLine(pcArray[j] + " ");
            //        }
                   
            //    }
            //    else if(hits == pcArray.Length)
            //    {
            //        attempts = 0;
            //        Console.WriteLine("Congratlations Player {0}! You managed to beat a random number generator", name);
            //        for (int j = 0; j<pcArray.Length; j++)
            //        {
            //            Console.Write(pcArray[j] + " ");
            //        }
            //    }
            //}
            //for (int i = 1; i <= digitNumber; i++)
            //{
            //    Console.Write("Digit {0}:" ,i);
            //}
            //while (attempts > 0)
            //{
            //    Console.Write("digit {0}:", digit = attempts - 1);
            //    //attempts--;
            //    Console.ReadLine();
            //}
        }

}
}

