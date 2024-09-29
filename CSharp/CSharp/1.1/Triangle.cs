using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle : Shape.Shape
    {
        public double a, b, c;
        public Triangle(int x, int y, double a, double b, double c) : base(x, y)
        {
            this.a = a; this.b = b; this.c = c;
        }
        public double A { get { return a; } set { if (value > 0) a = value; } }
        public double B { get { return b; } set { if (value > 0) b = value; } }
        public double C { get { return c; } set { if (value > 0) c = value; } }

        public override string Name { get { return "Triangle"; } }
        public override double Area()
        {
            if (IsTriangle())
            {
                double p = 0.5 * (a + b + c);
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else return 0;
        }
        public override void Draw()
        {
            if(IsTriangle())
            {
                Console.WriteLine($"Drawing a Triangle at ({X},{Y}), Edge A {A}, Edge B {B}, Edge C {C}");
            }
            else Console.WriteLine("Can't Draw");
        }

        private bool IsTriangle()
        {
            bool isTri = false;
            if (a + b > c && a + c > b && b + c > a)
                isTri = true;
            return isTri;
        }
    }
}
