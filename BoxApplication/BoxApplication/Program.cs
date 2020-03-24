using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // replace with prompts to user after
            double width = 5;
            double height = 7;
            double depth = 3;

            BoxClass myBox = new BoxClass();
            myBox.width = width;
            myBox.height = height;
            myBox.depth = depth;

            Console.WriteLine("The volume of a box with a height of {0} and a widht of {1} and a depth of {2} is {3}", myBox.height, myBox.width, myBox.depth, myBox.GetVolume());
            Console.WriteLine("The Surface Area of a box with a height of {0} and a widht of {1} and a depth of {2} is {3}", myBox.height, myBox.width, myBox.depth, myBox.GetSurfaceArea());
            Console.ReadLine();
        }
    }
}
