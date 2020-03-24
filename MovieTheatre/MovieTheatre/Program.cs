using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatre
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            decimal Price;

            string message;
            DisplayMenu();
            Console.Write("Enter Age of Movie Attendee:");
            age = int.Parse(Console.ReadLine());

            
            Price = GetTicketPrice(age);
            message = string.Format("\nThe ticket price is ${0:0.00}", Price);
            Console.WriteLine("The ticket price is $ " + Price);
            Console.ReadLine();
        }
        static void DisplayMenu()
        {
            Console.WriteLine("Children 6 and under are Free");
            Console.WriteLine("Students 7- 17 = $9.80");
            Console.WriteLine("Adults 18-54 = $11.35");
            Console.WriteLine("Seniors 55+ = $10.00");
        }

        static decimal GetTicketPrice(int age)
        {
            decimal Price = 0;
            if (age < 7)
            {
                Price = 0;
            }
            else
            {
                if( age < 18 )
                {
                    Price = 9.80M;
                }
                else
                {
                    if (age < 55)
                    {
                        Price = 11.35M;
                    }
                    else
                    {
                        Price = 10.00M;
                    }
                }
            }


            /// I Friggin Hate Computers right now I want to toss this out of a window on a 30 story building
            return Price;
        }
    }
}
