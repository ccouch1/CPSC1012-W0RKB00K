using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string album, artist, label;
            int year, numofrecords;

            CD[] cdLibrary = new CD[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter the Album Name: ");
                album = Console.ReadLine();
                Console.Write("Enter the Album Year: ");
                year = int.Parse(Console.ReadLine());
                Console.Write("Enter the Artist Name: ");
                artist = Console.ReadLine();
                Console.Write("Enter Label: ");
                label = Console.ReadLine();
                Console.Write("Enter Number of Records");
                numofrecords = int.Parse(Console.ReadLine());
                cdLibrary[i] = new CD(year, artist, album, label, numofrecords);
                Console.WriteLine("{0}- {1} - {2} - {3} - {4}", cdLibrary[i].Year, cdLibrary[i].Artist, cdLibrary[i].AlbumName, cdLibrary[i].Label, cdLibrary[i].NumberOfRecords);
            }

            CD myCD = new CD(1991, "Nirvana", "Nevermind", "DGC Records", 3);
          
            

            
        }
    }
}
