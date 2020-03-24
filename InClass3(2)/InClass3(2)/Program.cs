using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass3_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = "";
            int year, sign;
            Console.WriteLine("Please enter the year of Birth");
            year = int.Parse(Console.ReadLine());
            sign = (year - 1900) % 12;

            switch (sign)
            {
                case 0:
                    animal = "Rat";
                    break;
                case 1:
                    animal = "Ox";
                    break;
                case 2:
                    animal = "Tiger";
                    break;
                case 3:
                    animal = "Rabbit";
                    break;
                case 4:
                    animal = "Dragon";
                    break;
                case 5:
                    animal = "Snake";
                    break;
                case 6:
                    animal = "Horse";
                    break;
                case 7:
                    animal = "Goat";
                    break;
                case 8:
                    animal = "Monkey";
                    break;
                case 9:
                    animal = "Rooster";
                    break;
                case 10:
                    animal = "Dog";
                    break;
                case 11:
                    animal = "Pig";
                    break;
            }
            Console.Write("You are {0}", animal);
            Console.ReadLine();
        }
    }
}
