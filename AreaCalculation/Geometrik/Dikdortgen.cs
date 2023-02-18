using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation.Geometrik
{
    class Dikdortgen
    {
        public double KisaKenarUzunlugu { get; set; }
        public double UzunKenarUzunlugu { get; set; }

        public Dikdortgen(double kisaKenarUzunlugu, double uzunKenarUzunlugu)
        {
            KisaKenarUzunlugu = kisaKenarUzunlugu;
            UzunKenarUzunlugu = uzunKenarUzunlugu;
        }

        public double AlanHesapla()
        {
            return KisaKenarUzunlugu * UzunKenarUzunlugu;
        }

        public double CevreHesapla()
        {
            return 2 * (KisaKenarUzunlugu + UzunKenarUzunlugu);
        }

        public double KosegenHesapla()
        {
            return Math.Sqrt(Math.Pow(KisaKenarUzunlugu, 2) + Math.Pow(UzunKenarUzunlugu, 2));
        }
    }

}
