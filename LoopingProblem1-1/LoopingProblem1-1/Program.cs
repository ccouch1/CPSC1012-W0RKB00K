using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingProblem1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, total = 0;
            string message ="";
            Console.Write("Enter a positive Number");

            number = int.Parse(Console.ReadLine());

            for(int counter = 1; counter <= number; counter ++)
            {
                //Console.Write(counter + "x" + counter + "+");
                message = message + counter + "x" + counter + "+";
                total = total + (counter * counter);
            }
            message = message.TrimEnd('+');
            Console.Write(message +"=" + total);
            Console.ReadLine();
        }
    }
}
