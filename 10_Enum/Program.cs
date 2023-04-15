using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             ENUM(Enumaration - sıralama- numaralandırma)
            * Enumlar geliştiriciye yani bize yönelik seçeneklerdir.
            * biz kod geliştirirken yada kullanıcıdan alacağımız bilgiyi kendi standartımızda sunmak isterken enumdan faydalanırız
            * enumlar arka planlarında sayısal değerler tutarlar  defaultta 0 dan başlayıp ardışık devam eder ve tipi int tir.
            * 
            * istenirse bu tip değişebilir yada bu numaralar değiştirilir ve kaldığı yerden 1er artmaya devam eder.
            * 
            * bir enumdan yazılı değer teslim alabilmek için Enum.GetNames ()
            * yazılı hale getirilmiş bir enumu tekrar enum çevirmek için Enum.Parse(9 kullanılır.
            * 
            *  **Arkaplandaki değerden ötürü Enum.Parse() bize object döner bu yüzden enum istiyorsak enuma, enumdakini yazılı ifadenin sayısal değerini istiyıorsak int cast etmek gerekir.
            *  
            *  Enumlar namespace ve sınıf arasında tanımlanabilir ancak ayrı bir klasör altında enumları toplamak daha mantıklı olacaktır.
             
             */

            Personel personel = new Personel();
            personel.Ad = "Okan";
            personel.Soyad = "Candeniz";

            personel.kanGrup = KanGrup.O;
            personel.DepartmanBilgisi = Departman.Yazilim;

            foreach (var item in Enum.GetNames(typeof(Departman)))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
