using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation.Geometrik
{
    class Daire
    {
        public double YariCap { get; set; }

        public Daire(double yariCap)
        {
            YariCap = yariCap;
        }

        public double AlanHesapla()
        {
            return Math.PI * YariCap * YariCap;
        }

        public double CevreHesapla()
        {
            return 2 * Math.PI * YariCap;
        }
    }
}
