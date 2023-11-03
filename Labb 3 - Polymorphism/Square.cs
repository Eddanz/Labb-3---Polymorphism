using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorphism
{
    internal class Square : Geometry
    {
        public double Lenght { get; set; }

        public Square()
        {
            Lenght = 4;
        }

        public override double Area()
        {
            return Lenght * Lenght;
        }
        public override string ToString()
        {
            return $"Area för fyrkant med måtten {Lenght}cm x {Lenght}cm: {Area()}cm2";
        }
    }
}
