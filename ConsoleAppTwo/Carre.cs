using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTwo
{
    public class Carre : Para
    {

        public double cote;
        private int a;

        public Carre(double cote) : base(cote, cote, cote)

        {
            this.cote = cote;
        }
    }
}
