using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ValueReferenceType
{
    internal class Program
    {
        class Ogrenci //reference type
        {
            private string _ad;

            public string Ad
            {
                get { return _ad; }
                set { _ad = value; }
            }

            private string _soyAd;

            public string Soyad
            {
                get { return _soyAd; }
                set { _soyAd = value; }
            }


        }
        static void Main(string[] args)
        {
            /*
             
             ASP.Net core framework mantığı gereği uygulamada bazı nesneler RAM'in STACK kısmında bazı nesneler RAM'in  HEAP kısmında tutulur

            STACK=> value type(değer tipler) + reference typların adreslerini barındırır.
            HEAP=> referans tiplerin nesneleri yaşa

            * heap kısmındaki bir nesne birden fazla adres taafından gösterilir ANCAK bir adres bir nesneyi gösterir.
            * 
            * VALUE TYPE kopyalanabilir ANCAK REFERENCE TYPE değer taşıma işlemi yapar.
            * 
            * Bir değerdin NULL olması HEAP de karşılığının olmaması demektir. Bu yüzden reference tipler null olabilir ama değer tipler null olamaz.
            * 
            * VALUE TYPE => tüm veriyi kendi içinde tutar. int-sbye-long-decimal-struct-enum-...
            * 
            * REFERENCE TYPE => adresi stack de kendi heapte bulunur. string-class-delegate
            * 
            * STRIN BU KONUNUN İSTİSNASIDIR. DİKKAT EDİLMELİDİR:
             */
        }
    }
}
