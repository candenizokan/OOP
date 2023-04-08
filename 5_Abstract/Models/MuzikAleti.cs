using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Abstract.Models
{
    internal abstract class MuzikAleti
    {
        //abstract sınıflar kalıtım verebilen, atalık yapan ancak kendinden bir örnek alınmayan sınıflardır.

        public int Id { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }

        public string SesKontrol()
        {
            return "Akort edildi";
        }
        public abstract string Cal();
        /*
         *abstract methodlar private tanımlamazlar! kalıtım alınan yerde kendini muhakkak açıklamak zorunda kalacağından mantığa ters.
         *Abstract metodlar yalnızca abstract sınıflarda bulunabilir
         *abstract sınıflarda abstract olan - olmayan metodlar bulunabilir
         *abstract metodlar static olarak işaretlenmezler. static öğelere instance'tan bağımsız ulaşılırki burada açıklamaları olmayacağından ulaşılamaz.
         *
         *abstractlar gittikleri yerde açıklanacağınadn imzaları(dönüş tipi, adı,parametresi) var, gövdeleri(açıklaması yani süslü parantez içi) yok. 
         */
    }
}
