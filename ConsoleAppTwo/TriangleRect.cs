using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppTwo
{
    public class TriangleRect : Triangle
    {
        public TriangleRect(double a, double b) : 
            base(a, b, Math.Sqrt(a*a + b*b))
        {
            
        }
    }
}