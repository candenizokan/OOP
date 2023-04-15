using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Interface.Models
{
    internal class Sporcu : BaseSporcu, ISpor, IFutbol
    {
        public string GolSevinci()
        {
            throw new NotImplementedException();
        }

        public string PenaltiKurtar()
        {
            throw new NotImplementedException();
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
