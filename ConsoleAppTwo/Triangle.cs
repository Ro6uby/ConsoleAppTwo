using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppTwo
{
    public class Triangle : Polygone
    {
        protected double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }


        public double GetPerim()
        {
            double res = this.a + this.b + this.c;
            return res;
        }
    }
}