using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApplication
{
    class Circle
    {
        public double Radius { get; set; }
        public double GetDiameter()
        {
            return 2 * Radius;
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public double GetCircumference()
        {
            return 2*Math.PI*Radius;
        }
    }
}
