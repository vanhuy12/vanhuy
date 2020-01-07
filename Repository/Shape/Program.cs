using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Shape square = new Square(5);

            ShapeManager manager = new ShapeManager();
            manager.setShape(circle);
            Console.WriteLine("Circle with perimeter and area: "
                    + manager.calculatePerimeter() + ":"
                    + manager.calculateArea());

            manager.setShape(square);
            Console.WriteLine("Square with perimeter and area: "
                    + manager.calculatePerimeter() + ":"
                    + manager.calculateArea());

            Console.ReadKey();
        }
    }
}
