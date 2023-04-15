using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Interface
{
    internal interface IFutbolcu
    {
        string Ad { get; set; }
        string Soyad { get; set; }

        bool MilliTakimOyuncusuMu { get; set; }

        void SutCek();
        void TopKurtar();
    }
}
