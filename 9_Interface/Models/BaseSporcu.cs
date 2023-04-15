using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Interface.Models
{
    internal abstract class BaseSporcu
    {
        //propları sınıfa gömdüm
        //yetenekleri interfacelere gömdüm
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int FormaNumarasi { get; set; }
    }
}
