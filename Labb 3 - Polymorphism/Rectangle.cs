using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorphism
{
    internal class Rectangle : Geometry
    {
        public double Lenght { get; set; }
        public double Height { get; set; }

        public Rectangle() 
        {
            Lenght = 2;
            Height = 4;
        }

        public override double Area()
        {
            return Lenght * Height;
        }
        public override string ToString()
        {
            return $"Area för rektangel med måtten {Lenght}cm x {Height}cm: {Area()}cm2";
        }
    }
}
