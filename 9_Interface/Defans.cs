﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Interface
{
    internal class Defans : IFutbolcu, IPenalti
    {
        public string Ad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Soyad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool MilliTakimOyuncusuMu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string GolSevinci()
        {
            return "Gooolll";
        }

        public string PenaltiKurtar()
        {
            return "Penaltı kurtar";
        }

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
