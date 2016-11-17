using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Circle: Shape
    {
        private double radius = 0;

        public Circle() {}

        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentException("Radius must be positive");
            this.radius = radius;
        }

        public override double Perimeter()
        {
            if (radius == 0) return 0;
            return 2*Math.PI*radius;
        }

        public override double Area()
        {
            if (radius == 0) return 0;
            return Math.PI*Math.Pow(radius, 2);
        }
    }
}
