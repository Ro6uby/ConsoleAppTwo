using System;
using System.Collections.Generic;               
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTwo
{
    public class Para : Polygone
    {
        private double largeur, longueur, hauteur;

        public Para(double longueur, double largeur, double hauteur)
        {
            this.longueur = longueur;
            this.largeur = largeur;
            this.hauteur = hauteur;
        }

        public double GetSurf()
        {
            double res = 0;
            res = this.longueur * this.hauteur;
            return res;
        }

    }
}
