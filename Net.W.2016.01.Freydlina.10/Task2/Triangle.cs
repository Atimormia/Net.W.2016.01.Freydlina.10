using System;
using System.Linq;

namespace Task2
{
    public class Triangle : Poligon
    {
        /// <summary>
        /// Creates empty triangle
        /// </summary>
        public Triangle() : base(3)
        {
        }
        
        /// <summary>
        /// Creates triangle with spicified sides lenghts
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <exception cref="ArgumentException">Throws if some side is not positive or if specified sides can't be triangle sides</exception>
        public Triangle(double side1, double side2, double side3) : this()
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("Sides lenght must be positive");
            if (side1 + side2 <= side3 || side2+side3 <= side1 || side1+side3 <= side2)
                throw new ArgumentException("The two sides sum must be grater than third side");
            sides = new [] {side1, side2, side3};
        }

        /// <summary>
        /// Calculates triangle perimeter
        /// </summary>
        /// <returns>perimeter</returns>
        public override double Perimeter()
        {
            if (sides == null) return 0;
            return sides.Sum();
        }

        /// <summary>
        /// Calculates triangle area using Heron's formula
        /// </summary>
        /// <returns>area</returns>
        public override double Area()
        {
            if (sides == null) return 0;
            double halfPerimeter = Perimeter()/2;
            double heronComposition = halfPerimeter;
            foreach (var side in sides)
            {
                heronComposition *= halfPerimeter - side;
            }
            return Math.Sqrt(heronComposition);
        }
    }
}
