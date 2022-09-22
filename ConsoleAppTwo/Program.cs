using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TriangleEqui t = new TriangleEqui(10);

            double perm = t.GetPerim();
            Console.WriteLine("Le perimetre est de {0}", perm);

            Console.ReadLine();
        }                   
    }
}
