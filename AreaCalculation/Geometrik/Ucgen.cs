using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation.Geometrik
{
    class Ucgen
    {
        public double TabanKenarUzunlugu { get; set; }
        public double Yükseklik { get; set; }
        public double IlkKenarUzunlugu { get; set; }
        public double IkinciKenarUzunlugu { get; set; }
        public double UcuncuKenarUzunlugu { get; set; }

        public Ucgen(double tabanKenarUzunlugu, double yükseklik, double ilkKenarUzunlugu, double ikinciKenarUzunlugu, double ücüncüKenarUzunlugu)
        {
            TabanKenarUzunlugu = tabanKenarUzunlugu;
            Yükseklik = yükseklik;
            IlkKenarUzunlugu = ilkKenarUzunlugu;
            IkinciKenarUzunlugu = ikinciKenarUzunlugu;
            UcuncuKenarUzunlugu = ücüncüKenarUzunlugu;
        }

        public double AlanHesapla()
        {
            return (TabanKenarUzunlugu * Yükseklik) / 2;
        }

        public double CevreHesapla()
        {
            return IlkKenarUzunlugu + IkinciKenarUzunlugu + UcuncuKenarUzunlugu;
        }
    }

}
