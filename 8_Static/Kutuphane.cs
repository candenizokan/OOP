using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Static
{
    internal static class Kutuphane
    {
        public static double YerCekimiSabiti { get { return 9.687578; } }
        public static double SurtunmeKatsayisi { get => 8.565; }

        //const sabit değer. kendiliğinden static olma özelliğine sahip bu yüzden bir kere daha static yazmayız

        public const int KaldırmaKuvveti = 4;

        //readonly=> yalnızca okunabilir değer anlamında değişken tanımlarken kullanılır

        public static readonly int MomentSabiti = 2;

        //toDo: o zaman const ve readonly farkı nedir?

        public static int Hesapla()
        {
            return 45;
        }

        //static sınıf üyeleri static olmak zorunda
    }
}
