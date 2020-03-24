using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDApplication
{
    class CD
    {
        public int Year { get; set; }
        public string Artist { get; set; }
        public string AlbumName { get; set; }
        public string Label { get; set; }
        public int NumberOfRecords { get; set; }

        public CD(int year, string artist, string albumname, string label, int numofrecords)
        {
            Year = year;
            Artist = artist;
            AlbumName = albumname;
            Label = label;
            NumberOfRecords = numofrecords;
        }
    }
}
