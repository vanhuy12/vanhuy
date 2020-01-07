using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class ShapeManager
    {
        private Shape shape;

        public void setShape(Shape shape)
        {
            this.shape = shape;
        }

        public float calculatePerimeter()
        {
            return this.shape.getPerimeter();
        }

        public float calculateArea()
        {
            return this.shape.getArea();
        }
    }
}
