using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLogiceMainDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            char menuItem;
            Console.WriteLine("Welcome to the Calculator");

            menuItem = GetMenuItem();

            while(menuItem !='X')
            {
                ProcessMenuItem(menuItem);
                menuItem = GetMenuItem();
            }
            Console.WriteLine("Thank you. Goodbye");
            Console.ReadLine();
        }
         static void DisplayMenu()
         {
            Console.WriteLine("Pleas pick an item");
            Console.WriteLine("F - Factorial");
            Console.WriteLine("C - Combinations");
            Console.WriteLine("I - Fibonacci");
            Console.WriteLine("X - Exit");
         }
        static void ProcessMenuItem(char menuItem )
        {
            switch(menuItem)
            {
                case 'F':
                    ProcessFactorial();
                    //Console.WriteLine("Factorial Called");
                    break;
                case 'I':
                    //ProcessFibonacci();
                    Console.WriteLine("Fibonacci Called");
                    break;
                case 'C':
                    //ProcessCombinations();
                    Console.WriteLine("Combinations Called");
                    break;
            }
        }
        static void ProcessFactorial()
        {
            int n, nFactorial;
            n = GetPositiveInteger("Enter positive n value");
            nFactorial = Factorial(n);
            Console.WriteLine(n + "Factorial is" + nFactorial);
        }
        static int Factorial(int n)
        {
            int nfactorial = 1;

            while ( n > 1)
            {
                //nfactorial *= n;
                nfactorial = nfactorial * n;
                n--;
                //n = n - 1;
            }
            return nfactorial; 
       }
        static int GetPositiveInteger(string prompt)
        {
            int n;
            Console.WriteLine(prompt);
            n = int.Parse(Console.ReadLine());
            while ( n < 0  )
            {
                Console.WriteLine("Error. Display positive value.");
                Console.WriteLine(prompt);
                n = int.Parse(Console.ReadLine());
            }
            return n;

        }


        static char GetMenuItem()
        {
            char menuItem;
            DisplayMenu();

            menuItem = char.Parse(Console.ReadLine());
            menuItem = char.ToUpper(menuItem);
            //menuItem = char.ToUpper(char.Parse(Console.ReadLine()));


            while (menuItem != 'F' && menuItem != 'C' && menuItem != 'I' && menuItem != 'X')
            {
                Console.WriteLine("Invalid Menu Choice");
                DisplayMenu();
                menuItem = char.Parse(Console.ReadLine());
                menuItem = char.ToUpper(menuItem);
            }
            return menuItem;
        }
    }
}
