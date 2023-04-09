using _6_Polymorphism.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             oop un temel premsiplerindendir. birbirinden kalıtım alan sınıfların ortak bir kökenden geldiği taktirde birbirinin yerine geçebilmesi yada sınıflar içinde bir metodun inherit edildiği (kalıtım aldığı) yerde farklı şekilde içinin doldurularak kullanılnası yani metodun farklı davranışlar sergilemesi olarak düşünebiliriz.

             */

            Phone phone = new Phone();
            phone.CallSound();
            

            Iphone iphone = new Iphone();
            iphone.CallSound();

            while (true)
            {
                iphone.CallSound();
            }

            Console.ReadLine();
        }
    }
}
