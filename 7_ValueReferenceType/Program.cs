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

        struct Student  //value type
        {
            //STRUCT => en basit tanımıyla sınıfların değer tipli durumlarıdır. Sınıflardan farklı başka bir structtan yada sınıftan kalıtım almazlar.(interface'den implementasyon yapar).
            //sınıf ile struct arasında seçim yapmak zorunda kalındığında büyük yapılar için sınıfı küçükler için structı tercih edebiliriz.
            private string _firstName;

            public string FirstName
            {
                get { return _firstName; }
                set { _firstName = value; }
            }

            private string _lastName;

            public string LastName
            {
                get { return _lastName; }
                set { _lastName = value; }
            }


        }
        static void Main(string[] args)
        {
            //value typler kopyalanabilir
            Student student = new Student();
            student.FirstName = "Efe";
            student.LastName = "Çalışkan";

            Student student1 = student;
            student1.FirstName = "Ayşe";

            Console.WriteLine($" Student : {student.FirstName} - {student.LastName}");
            Console.WriteLine($" Student1 : {student1.FirstName} - {student1.LastName}");

            int a = 5;
            int b = a;
            b = b + 10;
            Console.WriteLine(a+"***"+b);


            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Ali";
            ogrenci.Soyad = "Yilmaz";
            
            Ogrenci ogrenci1 = ogrenci;
            ogrenci1.Ad = "Elif";

            Console.WriteLine($"ogrenci : {ogrenci.Ad} - {ogrenci.Soyad}");
            Console.WriteLine($"ogrenci1 : {ogrenci1.Ad} - {ogrenci1.Soyad}");



            Console.ReadLine();



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
