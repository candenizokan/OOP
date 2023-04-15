using _9_Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             
             Interface
            * Interfacelerin adlandırılması I harfi ile başlar ve pascal case ile yazılır.
            * Interfaceler katı kontrat mantığındadır., içindeki metod ve proplar implemantasyon yapıldığı yerde rek tek açıklanmak ve çalışmak zorundadır.
            * Interfaceler hem prop hemde metod barındırailir.
            * Interface içindeki metodların gövdeleri(süslü parantezlerin içi yani çalışma şekilleri) yeni açıklamaları yoktur, implemantasyon yapıldığı yerde zaten açıklanır.
            * 
            * NOT =Z Abstract sınıfın içindeki abstract metod ile interface içindeki metodların gövdeleri yoktur çünkü gittikleri yerde açıklanacaktır.. multiinheritance da bir sınıf yalnızca! bir sınıftan kalıtım alabildiğinde ikisininde varlığı ayrı ayrı önemlidir. Tek bir sınıf bizim için yeterli olmadığında interfacelerden destek alabiliriz.
            
             */

            Sporcu sporcu = new Sporcu();

            sporcu.Ad = "Okan";
            sporcu.Soyad = "Candeniz";
            sporcu.FormaNumarasi = 7;

            Console.WriteLine(sporcu.GolSevinci());

            Console.ReadLine();

            
        }
    }
}
