using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Circle : Shape.Shape
    {
        private double radius;

        public Circle(int x, int y, double radius) : base(x, y) { Radius = radius; }

        public override string Name { get { return "Circle"; } }
        public double Radius
        {
            get { return radius; }
            set { if (value > 0) radius = value; }
        }
        public double Diameter() { return Radius * 2; }
        public override double Area() { return Math.PI*Math.Pow(Radius, 2); }
        public override void Draw()
        {
            Console.WriteLine($"Drawing a Circle at ({X},{Y}), Radius {Radius}");
        }
    }
}
