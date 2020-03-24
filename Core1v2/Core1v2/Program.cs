using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core1v2
{
    class Program
    {
        static void Main(string[] args)
        {
             double num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, total, cash, change;
             string input;
        

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
            cash = ((num2*100) + (num3*50) + (num4*20) + (num5*10) + (num6*5) + (num7*2) + (num8*1) + (num9*.25) + (num10*.10) + (num11*.05));
            Console.WriteLine("cash = ${0}", cash);
            change = (cash - total);
            Console.WriteLine("change = ${0}",change);
            Console.WriteLine("Return the following number of each denomination to the customer:");
            Console.ReadLine();
        }
        
    }
}
