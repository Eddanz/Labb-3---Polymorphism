using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorphism
{
    internal class Geometry
    {
        public virtual double Area()
        {
            return 0;
        }
        public static void Run()
        {
            Geometry rectangle = new Rectangle();
            Geometry square = new Square();
            Geometry circle = new Circle();
            List<Geometry> list = new List<Geometry>();
            list.Add(rectangle);
            list.Add(square);
            list.Add(circle);
            foreach (Geometry item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
