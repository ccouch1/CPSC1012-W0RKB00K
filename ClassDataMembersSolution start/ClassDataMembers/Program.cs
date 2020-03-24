using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDataMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduction to class data members\n");
            Console.WriteLine("Creating an Animal instance");
            
            Animals myAnimal = new Animals();
            Console.WriteLine(" Type is >{0}< Status is >{1}< Population is >{2}<\n", myAnimal.Type, myAnimal.Status, myAnimal.Population);

            string inputSpecies;
            string inputPopulation;
            Int32 speciesPopulation;

            Console.WriteLine("Enter your animal details.");
            Console.Write("Species of animal.");
            inputSpecies = Console.ReadLine();
            Console.Write("Known population.");
            inputPopulation = Console.ReadLine();
            speciesPopulation = Int32.Parse(inputPopulation);

            myAnimal.Type = inputSpecies;

            myAnimal.RecordPopulation(speciesPopulation);

            Console.WriteLine(" Type is >{0}< Status is >{1}< Population is >{2}<\n", myAnimal.Type, myAnimal.Status, myAnimal.Population);

            Console.ReadKey();

        }
    }
}
