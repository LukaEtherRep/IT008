// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Contracts;

namespace Class_Abstract
{
    class Program
    {
        static void Main()
        {
            Shape.Shape[] shape = new Shape.Shape[4];
            shape[0] = new Rectangle.Rectangle(10, 10, 5, 2);
            shape[1] = new Circle.Circle(30, 20, 4.5);
            shape[2] = new Square.Square(10, 50, 3);
            shape[3] = new Triangle.Triangle(40, 20, 4, 5, 8);

            foreach (Shape.Shape s in shape)
            {
                s.Draw();
                Console.WriteLine($"Area of {s.Name} is {s.Area()}");
            }
        }
    }
}