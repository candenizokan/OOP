using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _6_Polymorphism.Models
{
    internal class Iphone:Phone
    {
        public override void CallSound()
        {
            // CallSound() methodu Phone sınıfında başka şekilde Iphone içinde farklı davranışlar sergiliyor. Buna polymorphism diyoruz.

            using (SoundPlayer sp = new SoundPlayer())
            {
                sp.SoundLocation = @"..\..\SesDosyasi\phonering.wav";
                sp.PlaySync();
            }
        }
    }
}
