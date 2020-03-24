using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicclassPerson
{
    class Program
    {
        static void Main(string[] args)
        {
        Person newPerson = new Person();
            newPerson.Name = "Sally";
            newPerson.Haircolour = "Pink";
            Console.WriteLine("{0} has {1} hair", newPerson.Name, newPerson.Haircolour);
            Console.ReadLine();
        }
    }
}
 public class Person
        {
            public string  Name { get; set; }
    public string Haircolour { get; set; }       
        }  
       
