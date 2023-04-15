using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Enum
{
    //enumı sınıfın dışında namespace altında tanımlıyabiliyorum ama önermem
    public enum Departman
    {
        Yazilim,
        Muhasebe,
        İK
    }
    internal class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public KanGrup kanGrup { get; set; }

        public Departman DepartmanBilgisi { get; set; }
    }
}
