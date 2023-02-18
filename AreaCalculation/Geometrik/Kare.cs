using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation.Geometrik
{
    class Kare
    {
        public double KenarUzunlugu { get; set; }

        public Kare(double kenarUzunlugu)
        {
            KenarUzunlugu = kenarUzunlugu;
        }

        public double AlanHesapla()
        {
            return KenarUzunlugu * KenarUzunlugu;
        }

        public double CevreHesapla()
        {
            return 4 * KenarUzunlugu;
        }
    }


}
