using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char menuItem;
            Console.WriteLine("Welcome to the Calculator");
            menuItem = GetMenuItem();
            while (menuItem != 'X')
            {
                ProcessMenuItem(menuItem);
                menuItem = GetMenuItem();
            }
            Console.WriteLine("Thanks you, goodbye");
            Console.ReadLine();
        }
        static void DisplayMenu()
            {
            Console.WriteLine("Please pick an Item:");
            Console.WriteLine("F- Factorial");
            Console.WriteLine("C- Combinations");
            Console.WriteLine("I- Fibonacci");
            Console.WriteLine("X- Exit");
            }
        static void ProcessMenu(char menuItem)
        {
            switch (menuItem)
            {
                case 'F':
                    ProcessFactorial();
                    break;
                case 'I':
                    ProcessFibonacci();
                    break;
                case 'C':
                    ProcessCombinations();
                    break;
            }
        }
        static char GetMenuItem()
        {
            char menuItem;
            DisplayMenu();
            menuItem = char.ToUpper(char.Parse(Console.ReadLine()));
            while (menuItem != 'F' && menuItem != 'C' && menuItem != 'I' && menuItem != 'X')
            {
                Console.WriteLine("Error- Invalid menu item");
                DisplayMenu();
                menuItem = char.ToUpper(char.Parse(Console.ReadLine()));
            }
            return menuItem;
         }

        static void ProcessFactorial()
        {
            Int32 n, nFactorial;
            n = GetPositiveInteger("Enter n Value");
            nFactorial = Factorial(n);
            Console.WriteLine("{0} factorial is {1}", n, nFactorial);
        }
            
                static void Process Combinations()
            {
                Int32 n, r, nChooseR;
                n = GetPositiveInteger("Enter number of Objects to choose from");
                r = GetPositiveInteger("Enter number of objects to choose");
                while (r> n)
                {
                    Console.WriteLine("Error - must be less than or equal to {0}", n);
                    r = GetPositiveInteger("Enter number of objects to choose");
                }
                nChooseR = Combinations(n, r);
                Console.WriteLine("There are {0} ways to chosse {1} of {2} objects", nChooseR, r, n);
            }
            static void ProcessFibonacci()
            {
                Int32 n, nthFibonacci;
                n = GetPositiveInteger("Enter position of fibonacci sequence");
                nthFibonacci = Fibonacci(n - 1);
                Console.WriteLine("The Fibonacci number at position {0} is {1}", n, nthFibonacci);
            }

           
            static Int32 Factorial(Int32 n)
            {
                Int32 nFactorial;
                for (nFactorial = 1; n > 1; n--)
                    nFactorial *= n;
                return nFactorial;
            }
            static Int32 Combinations(Int32 n, Int32 r)
            {
                return Factorial(n) / (Factorial(r) * Factorial(n - r));
            }

        static Int32 GetPositiveInteger(String prompt)
        {
            Int32 n;
            Console.WriteLine(prompt);
            n = Int32.Parse(Console.ReadLine());
            while (n < 0)
            {
                Console.WriteLine("Error: enter positive value");
                Console.WriteLine(prompt);
                n = Int32.Parse(Console.ReadLine());
            }
            return n;
        }
        }
}