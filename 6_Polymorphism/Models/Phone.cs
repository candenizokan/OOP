using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _6_Polymorphism.Models
{
    internal class Phone
    {
        public int ID { get; set; }
        public int Model { get; set; }
        public decimal Price { get; set; }

        //virtual: işaretlenmiş metodlar inherit edildikleri yerde isterse metodu aynı kullanılır isterse ezebilir
        public virtual void CallSound()
        {
            //SoundPlayer sp = new SoundPlayer(); burada yaparsan garbage collector geldiğinde siler
            //garbage collector'a iş bırakılmadan sp isimli nesne oluşturulur ve using parantezinden  çıkıldığı anda nesneyi dispose eder.(siler)
            //garbage collector: çöp toplayıcı. Ramde kullanılmayan/ işi bitmiş nesneleri belli bir algoritmaya göre silen ve rami rahatlatan yapı.

            //ramin 2 kısmı var.ramde boş kalan nesneler garbage collector çalışıyor. boşta kalan nesneleri silip silip duruyor. burada usingde kullanılınca garbage collector gelmeden işin bitince nesneyi çöpe atıyorum. sisteme yük bırakmıyorum.
            using (SoundPlayer sp = new SoundPlayer())
            {
                sp.SoundLocation = @"..\..\SesDosyasi\cellph.wav";
                sp.PlaySync();
            }
        }
    }
}
