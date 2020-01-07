using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Circle : Shape
    {
        private static float PI = 3.1415f;
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public float getPerimeter()
        {
            return radius * 2 * PI;
        }

        public float getArea()
        {
            return (float)(Math.Pow(radius, 2) * PI);
        }
    }
}
