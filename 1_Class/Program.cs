using _1_Class.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            CLASS- sınıf: oluşmasını istediğimiz nesnelerin kalıplarıdır. soyut haldedir. doğrudan doğruya iş yapamayız ancak instance(örnek alam-örneklem) dediğimizde ortaya çıkan nesne sayesine iş yapabilir alanlarına değer atayabiliriz.
            
            sınıftan INSTANCE almadıkça nesne(object) varlığından söz edilemez'

            Sınıf üyeleri: field, property ve metodlar olabilir.
            field: dışarıya kapalı alanlardır. Ancak propertyler yardımıyla içindeki değer okunabilir/atama yapılabilir.
            Property: sınıf içinde özellik atadığımız alanlardır. GET ve SET methodları sayesinde değerleri okunabilir ve değiştirilebilinir.

             */

            Personel personel = new Personel();//instancee:örneklem
            personel.Id = 1;
            personel.Ad = "okan";
            personel.Soyad = "candeniz";
            personel.Yas = 30;
            personel.SaglikProblemiVarMi = false;

            Personel personel1 = new Personel();//instancee:örneklem
            personel1.Id = 2;
            personel1.Ad = "ali";
            personel1.Soyad = "candeniz";
            personel1.Yas = 55;
            personel1.SaglikProblemiVarMi = false;

            Personel personel2 = new Personel();//instancee:örneklem
            personel2.Id = 3;
            personel2.Ad = "aynur";
            personel2.Soyad = "candeniz";
            personel2.Yas = 48;
            personel2.SaglikProblemiVarMi = false;

            Personel personel3 = new Personel();//instancee:örneklem
            personel3.Id = 4;
            personel3.Ad = "ege";
            personel3.Soyad = "candeniz";
            personel3.Yas = 1;

            List<Personel> list = new List<Personel>();
            list.Add(personel);
            list.Add(personel1);
            list.Add(personel2);
            list.Add(personel3);

            foreach (var item in list)
            {
                Console.WriteLine(item.Id+" "+item.Ad + " " +item.Soyad + " " +item.Yas + " " +item.SaglikProblemiVarMi);
            }

            //yaşı 35 den küçük olanları yaz
            foreach (var item in list)
            {
                if (item.Yas<=35)
                {
                    Console.WriteLine(item.Id + " " + item.Ad + " " + item.Soyad + " " + item.Yas + " " + item.SaglikProblemiVarMi);
                }
            }
            Console.WriteLine(personel.Id);

            Console.ReadLine();
        }
    }
}
