using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndClasses
{
    class StaticClass
    {
        public static void MilesToKilometers(decimal
                                              convertValue)
        {
            Console.WriteLine("{0} miles is equal to {1} kilometers", convertValue, convertValue * 1.6m);
        }

        public static void KilometersToMiles(decimal
                                               convertValue)
        {
            Console.WriteLine(" {0} kilometers is equal to {1} miles", convertValue, convertValue / 1.6m);
        }

    }
}
