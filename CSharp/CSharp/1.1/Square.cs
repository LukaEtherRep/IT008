using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    public class Square : Rectangle.Rectangle
    {
        public Square(int x, int y, double length) : base(x, y, length, length) { }
        public override string Name { get { return "Square"; } }
        public override double Area() { return Height * Width; }
        public override void Draw()
        {
            Console.WriteLine($"Drawing a Square at ({X},{Y}), Length {Height}");
        }
    }
}
