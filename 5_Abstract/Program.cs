using _5_Abstract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MuzikAleti muzikAleti = new MuzikAleti();//abstract tanımladığım için kızıyor

            Gitar gitar = new Gitar();
            gitar.Cal();
            gitar.SesKontrol();
        }
    }
}
