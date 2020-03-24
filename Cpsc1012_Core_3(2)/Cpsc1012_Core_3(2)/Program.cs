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
            int digit;
            string name;
            Console.WriteLine("==Welcome to Master-Mined==");
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Welcome {0}.", name);
            Console.ReadLine();
            int numberCount = 0;
            int difficultyLevel = 0;

            int digitNumber = GetRandomNumberCount(numberCount);
            Console.Write(digitNumber + " it is. Let's play.");
            Console.WriteLine();
            int[] PCArray = GenerateRandomNumbers(digitNumber);
            //PCArray = GenerateRandomNumbers();

            Console.WriteLine("A " + digitNumber + "-digit number has been chosen. Each possible digit may be the number 1, 2, 3 or 4.");
            Console.WriteLine("    ******");

            int difficulty = GetGameDifficulty(difficultyLevel);
            int attempts = difficulty * digitNumber;
            Console.WriteLine("Enter your guess ({0} guesses remaining)", attempts);
            int remaining = attempts;
            while (attempts > 0)
            {
                Console.Write("digit {0}:", digit = attempts - 1);
                attempts--;
                Console.ReadLine();
            }
        }
        static int GetUserGuess(int userSize)
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
            return number;
        }

        static int GetRandomNumberCount(int numberCount)
        {
            int input, number = 0;
            do
            {


                Console.Write("How many numbers would you like to play with (4-10)?", 4, 10);
                //number=int.Parse(Console.ReadLine());
                if (int.TryParse(Console.ReadLine(), out input) == true)
                {
                    number = input;

                }
                else
                {

                    Console.WriteLine("Please choose a number between 4 and 10. Please choose again ");//<-- Edit so displayed when incorrect number inputted\\
                }

            } while ((number < 4) || (number > 10));
            return number;
        }
        static int GetGameDifficulty(int difficultyLevel)
        {
            int input, difficulty = 0;
            do
            {
                try
                {
                    Console.Write("Choose a diffculty level (1= Hard, 2= Medium, 3=Easy)?");
                    //difficulty = int.Parse(Console.ReadLine());
                    if (int.TryParse(Console.ReadLine(), out input) == true)
                    {
                        difficulty = input;
                    }
                }
                catch
                {
                    Console.Write("       Incorrect entry: Please enter a valid Difficulty");
                }
            } while ((difficulty < 1) || (difficulty > 3));
            return difficulty;
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
                    Console.Write("/tIncorrect entry: Please re-enter");
                }
            } while (validInt == false);

            return validNumber;
        }

        static int CountHits(int[] computerArray, int[] userArray, int attempts)
        {
            int hit = 0;
            int miss = 0;
            int hits = 0;
            for (int i = 0; i < computerArray.Length; i++)
            {

                if (computerArray[i] == userArray[i])
                {
                    hit = hit + 1;
                    hits = hit;
                }
                else
                {
                    miss = miss + 1;
                }
                Console.WriteLine("Results: {0} Hit(s), {1} Miss(es)", hit, miss);

            }
            return hits;
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
            Console.ReadLine();
            return randomNumber;
            //return rnd.Next(1, 5);
        }
        //this part below gave me some major difficulty for some reason I couldn't quiet figure out what was going wrong
        //static char PlayGame()
        //{
        //int numberCount = 0, attempts = 0,
        //}
        //static char PlayGame(string name, char playAgain)
        //{
        //int numberCount = 0, attempts = 0, hitMiss = 0, gameDifficulty = 0, input = 0;
        //int min = 0, max = 0, userGuess = 0;
        //string prompt = "";

        //numberCount = GetRandomNumberCount(numberCount, input);

        // attempts = numberCount * GetGameDifficulty(gameDifficulty);
        //int remaining = attempts;
        //int[] userArray = new int[numberCount];
        //int[] computerArray = new int[numberCount];
        //for (int i = 1; i < numberCount; i++)
        //{
        //computerArray[i - 1] = GenerateRandomNumbers();
        // }
        //   do
        //     {
        //   Console.WriteLine("/nEnter your guess (" + remaining + " guess remaining): ");

        //   remaining--;

        //           for (int i = 1; i <= numberCount; i++)
        //             {

        //      userArray[i - 1] = GetUserGuess(userGuess);
        //      Console.Write("Digit " + i + ": ");
        //               }

        //    Console.Write("Your Guess:");
        //for (int i = 1; i <= numberCount; i++)
        //{
        //        Console.Write(" " + userArray[i - 1]);
        //}

        //   hitMiss = CountHits(userArray, computerArray);

        //   int misses = numberCount - hitMiss;

        //     Console.Write("\nResults:\t" + hitMiss + "Hit(s), " + misses + " Miss(es)\n");

        //   if (misses == 0)
        //{
        //        Console.WriteLine("You win, " + name);
        //          Console.WriteLine("The correct numbers were:", );

        // for (int j = 1; j <= numberCount; j++)
        //  {

        //             computerArray[j - 1] = GenerateRandomNumbers();
        //
        //             int displayNumbers = GenerateRandomNumbers();

        //            Console.Write(displayNumbers + " ");
        //               }
        //         }

        //}while(' ')
        //{
        //Console.Write(' ');
        //}
        //return PlayGame;
        //}


    }
}

