using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass6
{
    class Program
    {
        static void Main(string[] args)
        {
            int length=3;

            Console.Write("Length of side=");
                length = GetLength("Length of side=");
                int.Parse(Console.ReadLine());
                Console.Write("Fill box with: ");
                Console.ReadLine();
          
             for (int i = 3; i <= 15; i++)
            {
                
                Console.Write("-");
                
            }
            for (int i = 3; i <=15; i++)
            {
                Console.WriteLine("|");
            }
            for (int i = 3; i <= 15; i++)
            {

                Console.Write("-");

            }
            
            Console.ReadLine();     

        }
        static void DisplayBox (int length)
        {

            for (int i = 0; i < 15; i++)
            {
            
            }
            
            
        }
        static void DisplayBox(int length, char fillChar)
        {
            //length= 
           //fillChar=
        }
     static int GetLength(string prompt)
     {
       int length=0;
       return length;     
     } 
    }
}