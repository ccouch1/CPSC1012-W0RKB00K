using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, total, cash, change;
            string input;

            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            if (username.Equals("cashier") && password.Equals("NOPassword!"))
            {
                //* the above code was also difficult to figure out but the code below was easy to over think
                Console.WriteLine("--Change Calculator--");
                Console.Write("Enter the Purchase Price in Dollars and Cents:");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter the number of $100 bills tendered:");
                num2 = double.Parse(Console.ReadLine());
                Console.Write("Enter the number of $50 bills tendered:");
                num3 = double.Parse(Console.ReadLine());
                Console.Write("Enter the number of $20 bills tendered:");
                num4 = double.Parse(Console.ReadLine());
                Console.Write("Enter the number of $10 bills tendered:");
                num5 = double.Parse(Console.ReadLine());
                Console.Write("Enter the number of $5 bills tendered:");
                num6 = double.Parse(Console.ReadLine());
                Console.Write("Enter the number of $2 coins tendered:");
                num7 = double.Parse(Console.ReadLine());
                Console.Write("Enter the number of $1 coins tendered:");
                num8 = double.Parse(Console.ReadLine());
                Console.Write("Enter the number of quarters <25> tendered:");
                num9 = double.Parse(Console.ReadLine());
                Console.Write("Enter the number of dimes <10> tendered:");
                num10 = double.Parse(Console.ReadLine());
                Console.Write("Enter the number of nickels <5> tendered:");
                num11 = double.Parse(Console.ReadLine());

                Console.WriteLine("total = ${0}", total = num1);
                cash = ((num2 * 100) + (num3 * 50) + (num4 * 20) + (num5 * 10) + (num6 * 5) + (num7 * 2) + (num8 * 1) + (num9 * .25) + (num10 * .10) + (num11 * .05));
                Console.WriteLine("cash = ${0}", cash);
                change = (cash - total);
                Console.WriteLine("change = ${0}", change);

                //* I found this part to be difficult to figure out but I did it
                change = Math.Round(change * 20, MidpointRounding.AwayFromZero) / 20;
                num2 = (int)(change / 100);
                num3 = (int)((change % 100) / 50);
                num4 = (int)(((change % 100) % 50) / 20);
                num5 = (int)((((change % 100) % 50) % 20) / 10);
                num6 = (int)(((((change % 100) % 50) % 20) % 10) / 5);
                num7 = (int)((((((change % 100) % 50) % 20) % 10) % 5) / 2);
                num8 = (int)(((((((change % 100) % 50) % 20) % 10) % 5) % 2) / 1);
                num9 = (int)((((((((change % 100) % 50) % 20) % 10) % 5) % 2) % 1) / 0.25);
                num10 = (int)(((((((((change % 100) % 50) % 20) % 10) % 5) % 2) % 1) % 0.25) / 0.10);
                num11 = (int)((((((((((change % 100) % 50) % 20) % 10) % 5) % 2) % 1) % 0.25) % 0.10) / 0.05);

                Console.Write("\n \n Return the following number of each denomination to the customer: \n \n $100 \t $50 \t $20 \t $10 \t $5 \t $2 \t $1 \t 25¢ \t 10¢ \t 5¢ \n ---- \t ---- \t ---- \t ---- \t ---- \t ---- \t ---- \t ---- \t ---- \t ----");
                Console.WriteLine("\n {0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6} \t {7} \t {8} \t {9}", num2, num3, num4, num5, num6, num7, num8, num9, num10, num11);
            }
            else
            {
                System.Environment.Exit(0);
            }
            Console.ReadLine();
        }
    }
}
