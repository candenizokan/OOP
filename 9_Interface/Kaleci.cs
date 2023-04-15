using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Interface
{
    internal class Kaleci : IFutbolcu
    {
        public string Ad { get ; set; }
        public string Soyad { get ; set ; }
        public bool MilliTakimOyuncusuMu { get; set ; }

       

        public void SutCek()
        {
            throw new NotImplementedException();
        }

        public void TopKurtar()
        {
            throw new NotImplementedException();
        }
    }
}
