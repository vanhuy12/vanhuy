using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Square : Shape
    {
        private int size;

        public Square(int size)
        {
            this.size = size;
        }

        public float getPerimeter()
        {
            return size * 4;
        }

        public float getArea()
        {
            return (float)Math.Pow(size, 2);
        }

    }
}
