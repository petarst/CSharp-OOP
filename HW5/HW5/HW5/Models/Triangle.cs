using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW5.Models
{
    public class Triangle : Shape
    {
        public Triangle(double height, double width)
            : base (height,width )
        {

        }

        public override double CalculateSurface()
        {
            return (this.Height*this.Width)/2;
        }
    }
}
