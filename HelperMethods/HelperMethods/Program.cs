using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            
         }
        static int PromptForInt(string message, string error)
        {
            bool validInt = false;

            int input;
            do
            {
                Console.Write(message);
                int.TryParse(Console.ReadLine(), out input);

                if (input > 0)
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
    
