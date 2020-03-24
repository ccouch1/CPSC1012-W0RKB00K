using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method and Classes: An Introduction\n");
            Console.WriteLine("(a) Mile to Kilometers");
            Console.WriteLine("(b) Kilometers to Miles\n");
            Console.Write("Enter convert request ");

            string menuChoice;
            string inputValue;
            decimal convertValue;

            menuChoice = Console.ReadLine();

            Console.Write("Enter value to convert ");
            inputValue = Console.ReadLine();
            convertValue = decimal.Parse(inputValue);

            switch (menuChoice)
            {
                case "a":
                case "A":
                    {
                        /* use the StaticClass with static methods to call a method in another class you must refer to the otherclass use the dot operator and method name 

                        use the Instantiated Class with methods an instantiated  class MUST be created before being used creating a class is called instantaition an instance of an instantiated  class is referred to as an object (instance) of the class 

                        the use of the new command creates the instance of the class.


                            to use a method inside an instantiated  class

                        use the variable name from the declaration statement */
                        break;
                    }
                case "b":
                case "B":
                    {
                        InstantiatedClass myInstance = new InstantiatedClass();
                        myInstance.KilometersToMiles(convertValue);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please select a menu option.");
                        break;
                    }
            }// end of case structure

            Console.ReadKey();
        }

    }
}
