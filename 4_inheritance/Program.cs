using _4_inheritance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            oop'un temel prensipleri

            **inheritance:örnek almak, ilgili sınıfta bir nesne alma işlemidir. inheritance: kalıtım, kod aktarımı. kavramlar karışmasın
            *
            *ortak özellik, yeteneklerin toplandığı bir ortak sınıfın diğer sınıflara kalıtım vererek kendi içindeki tüm özellikleri ilgili sınıfa aktarması, sınıf türetmesi işlemidir.
            *kod tekrarı önlenir, yönetim kolayaşır
            *özellikleri düşünürken ilgili özellik, yeteknk gerçekten düşünülen sınıftan varsa aktarıma müsade edilmelidirç.
            *unutmayalı=> özelliğe değer atanamamsı ile özelliğin olması farklı şeyle
             */

            MobilePhone mb = new MobilePhone(true,true,"Nokia","mobilBağlantı");
            Console.WriteLine(mb.Call());
            Console.WriteLine(mb.TakePhote());
            Console.WriteLine(mb.ConnectionStatus());

            SmartPhone sp = new SmartPhone();
            Console.WriteLine(sp.Call());
            Console.WriteLine(sp.ConnectionStatus());

            Console.ReadLine();


        }
    }
}
