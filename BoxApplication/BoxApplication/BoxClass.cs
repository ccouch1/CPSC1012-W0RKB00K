using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxApplication
{
    class BoxClass
    {
        public double height { get; set; }
        public double width { get; set; }
        public double depth { get; set; }
        public double GetVolume()
        {
            return height * width * depth;
        }
        public double GetSurfaceArea()
        {
            return 2 * (width * height) + 2 * (height * depth) + 2 * (width * depth);
        }
    }
}
