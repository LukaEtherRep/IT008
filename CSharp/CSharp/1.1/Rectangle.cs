using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Rectangle : Shape.Shape
    {
        public double height;
        public double width;

        public Rectangle(int x, int y, double height, double width) : base(x, y)
        {
            this.height = height;
            this.width = width;
        }

        public double Height
        {
            get { return height; }
            set { if (value > 0) height = value; }
        }
        public double Width
        {
            get { return width; }
            set { if (value > 0) width = value; }
        }
        public override string Name { get { return "Rectangle"; } }
        public override double Area() { return height * width; }
        public override void Draw()
        {
            Console.WriteLine($"Drawing a Rectangle at ({X},{Y}), Width {Width}, Height {Height}");
        }
    }
}
