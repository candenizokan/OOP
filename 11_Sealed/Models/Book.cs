using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Sealed.Models
{
    internal class Book:BaseBook
    {
        public int Id { get; set; }
        public string Detail { get; set; }

        public override void GetRead()
        {
            base.GetRead();
        }

        //SEALED: keyword. kendinden nesne türetilebilir ancak kalıtım vermez. ABSTRACT kelimesinin tam tersi mantığında çalışır. Abstractlar kalıtım verebilir, nesne alınamaz. sealed newlerim kalıtım aldıramam. abs newleyemem kalırım veririm
        public sealed override void GetUser()
        {
            base.GetUser();
        }
    }
}
