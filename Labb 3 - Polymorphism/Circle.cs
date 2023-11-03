using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorphism
{
    internal class Circle : Geometry
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 5;
        }

        public override double Area()
        {
            return Radius * Radius * 3.14159265359f;
        }
        public override string ToString()
        {
            return $"Area för cirkel med radie på {Radius}cm: {Area()}cm2";
        }
    }
}
