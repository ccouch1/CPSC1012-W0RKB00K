using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Console.WriteLine("{0} - {1} - {2} - {3} - {4}", myCar.Make, myCar.Model, myCar.Year, myCar.Color, myCar.OriginalPrice);

            Car myOtherCar = new Car("Ford","Shelby Cobra GT500", 1967, "Silver with Black racing stripes", 125000);
            Console.WriteLine("{0} - {1} - {2} - {3} - {4}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color, myOtherCar.OriginalPrice);

            myCar.Model = "Impala";
            myCar.Year = 2002;
            myCar.Color = "Gold";
            myCar.OriginalPrice = 4000;

            Console.WriteLine("{0} - {1} - {2} - {3} - {4}", myCar.Make, myCar.Model, myCar.Year, myCar.Color, myCar.OriginalPrice);

            Console.ReadKey();
        }
    }
}
