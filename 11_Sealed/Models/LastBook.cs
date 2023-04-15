using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Sealed.Models
{
    internal class LastBook:Book
    {
        public override void GetRead()
        {
            base.GetRead();
        }

        //NOT LASTBOOK un türetildiği sınıfta yeni BOOK sınıfındaki GetUser() metodu SEALED işaretlendiği için o metodun görülebileceği son yer artık orasıdır. Aktarımı yapılmaz. Haliyle LastBook sınıfı içinde görülmez.

        //getuser i book'ta sealed yaptığımdan kalıtımı kestim. burada override edemiyorum
    }
}
