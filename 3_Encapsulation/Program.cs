using _3_Encapsulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Encapsulation:

            *oopnin temel prensiplerindendşr
            *sınıf üyesi olan propertylerin bir fieldı sarıp sarmalaması ve kendi üzerinde bulunan GET ve SET methodları sayesinde içerideki fielda kontrollü erişimin ve veri paylaşımının sağlanması olayıdır.
            *GET ve SET metodları her zaman beraber olmak zorunda değildir.
            *içerideki fielda erişim yalnızca public bir property üzerinden olur. Field access modifierı ise privatedir.
            *
            *propfull + tab tab tuşlarıyla encapsulation syntaxı oluşmuş olur
             */

            Urun urun = new Urun();

            urun.Id = 23;
            urun.Ad = "Elma";

            Urun urun1 = new Urun();
            urun1.Id = 20;
            urun1.Ad = "soğan";
            urun1.Fiyat = -5;

            Urun urun2 = new Urun();
            urun2.Id = 21;
            urun2.Ad = "soğan";
            urun2.Fiyat = 30;

            Console.WriteLine($"Urun =>{urun.Id} - {urun.Ad} - {urun.Fiyat}");
            Console.WriteLine($"Urun =>{urun1.Id} - {urun1.Ad} - {urun1.Fiyat}");
            Console.WriteLine($"Urun =>{urun2.Id} - {urun2.Ad} - {urun2.Fiyat}");

            Console.ReadLine();
        }
    }
}
