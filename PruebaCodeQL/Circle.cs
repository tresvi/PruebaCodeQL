using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCodeQL
{
    class Circle
    {
        private double radius;
        public double area()
        {
            return Math.Pow(radius, 2) * 3.14;
        }
        public double circumference()
        {
            return radius * 2 * 3.14;
        }
    }

}
