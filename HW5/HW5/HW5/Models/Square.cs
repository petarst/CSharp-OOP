﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW5.Models
{
    public class Square : Shape
    {
        public Square(double side)
            : base (side, side)
        {

        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}