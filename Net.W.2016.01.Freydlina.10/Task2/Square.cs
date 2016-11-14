using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Square: Rectangle
    {
        /// <summary>
        /// Creates square on rectangle base
        /// </summary>
        /// <param name="side"></param>
        public Square(double side) : base(side,side)
        {
        }
    }
}
