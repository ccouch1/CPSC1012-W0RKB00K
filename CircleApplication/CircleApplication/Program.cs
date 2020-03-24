using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double input;
            Console.WriteLine("Enter Radius of Circle");
            input = double.Parse(Console.ReadLine());
            Circle newCircle = new Circle();
            newCircle.Radius= input;
            Console.WriteLine("Diameter of a Circle is {0}", newCircle.GetDiameter());
            Console.WriteLine("Area of a Circle is {0}", newCircle.GetArea());
            Console.WriteLine("Circumfrence of a Circle is {0}", newCircle.GetCircumference());
            Console.ReadLine();
        }
    } 
}
