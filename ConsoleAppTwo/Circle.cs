using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTwo
{
    public class Circle
    {
        public double rayon;

        


        public Circle(double rayon)
        {
            Console.WriteLine("Bonjour, je suis le rayon");
            this.rayon = rayon;
        }

        public double GetCirconf()
        {
            double res = 0;
            res = Math.PI * 2 * this.rayon;
            return res;
        }

        public double GetSurface()
        {
            double res = 0;
            res = Math.PI * Math.Pow(this.rayon, 2);
            return res;
        }

    }
}
