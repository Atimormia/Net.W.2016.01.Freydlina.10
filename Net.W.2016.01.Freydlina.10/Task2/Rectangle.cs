using System;
using System.Linq;

namespace Task2
{
    public class Rectangle: Poligon
    {
        /// <summary>
        /// Creates empty rectangle
        /// </summary>
        public Rectangle() : base(2)
        {
        }

        /// <summary>
        /// Creates rectangle with spicified sides lenghts
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <exception cref="ArgumentException">Throws if some side is not positive</exception>
        public Rectangle(double side1, double side2) : this()
        {
            if (side1 <= 0 || side2 <= 0)
                throw new ArgumentException("Sides lenght must be positive");
            sides = new[] { side1, side2 };
        }

        /// <summary>
        /// Calculates rectangle perimeter
        /// </summary>
        /// <returns>perimeter</returns>
        public override double Perimeter()
        {
            if (sides == null) return 0;
            return sides.Sum()*2;
        }

        /// <summary>
        /// Calculates rectangle area using Heron's formula
        /// </summary>
        /// <returns>area</returns>
        public override double Area()
        {
            if (sides == null) return 0;
            return sides[0]*sides[1];
        }
    }
}
