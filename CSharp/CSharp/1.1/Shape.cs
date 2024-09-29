using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public abstract class Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Shape(int x, int y) { X = x; Y = y; }

        public void MoveTo(int x, int y) { X = x; Y = y; }

        public abstract double Area();
        public abstract void Draw();

        public abstract string Name { get; }
    }
}
