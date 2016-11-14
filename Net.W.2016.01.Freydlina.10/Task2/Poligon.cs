using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Abstaction extended shape term
    /// </summary>
    public abstract class Poligon: Shape
    {
        public int countVertices { get; }
        protected double[] sides;

        /// <summary>
        /// Creates some poligon with specified count vertices
        /// </summary>
        /// <param name="countVertices"></param>
        /// <exception cref="ArgumentException">Poligon must contain at least 3 vertices</exception>
        protected Poligon(int countVertices)
        {
            if (countVertices < 3) throw new ArgumentException("Poligon must contain at least 3 vertices");
            this.countVertices = countVertices;
        }
    }
}
