using Constructor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Constructor:yapılandırıcı-yapıcı method
            yapıcı method: static olmayan(ileride göreceğiz), bir sınıftan bir nesne almak istediğimizde çalışan oluşturulduğunda parametreli de çalışabilen bir methoddur.
            Void tiplidir geriye değer döndürmezler!
            kesinlikle sınıfı ile aynı ismi taşırlar.
            aksi söylenmediğinde DEFAULT olarak zaten arka planda oluşur ve parametresiz çalışır ancak biz CONSTRUCTOR için overload yapmaya kalktığımızda !!! DEFAULTTA PARAMETRESİZ HALİNİ de SINIF içine yazmasak overload parametresiz halini ezmiş olur

            Metot olduğu için tabiki overloadlar oluşturulabilir.
             
             */

            //parametresiz-default constructor

            Araba araba = new Araba();
            araba.Marka = "audi";
            araba.MotorGucu = 600;
            araba.Model = "i5";

            //parametreli constructor
            Araba araba1 = new Araba("BMW","i6");
            araba1.MotorGucu = 9000;//daha sonra değişirebilirim
            araba1.Model = "a3";

            Araba araba2 = new Araba("Toyota", "yaris",105);
            araba2.Marka = "opel";

            Console.ReadLine();
        }
    }
}
