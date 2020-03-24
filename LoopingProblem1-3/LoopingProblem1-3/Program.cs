using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingProblem1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString, newString = "", tempString;
            Console.Write("Enter String");
            userString = Console.ReadLine();
            
            foreach(char character in userString)
            {
                tempString = newString;
                newString = character + "\n" + tempString;
            }
            Console.WriteLine(newString);
            Console.ReadLine();
        }
    }
}
