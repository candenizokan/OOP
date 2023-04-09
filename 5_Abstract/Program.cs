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
            gitar.Id = 1;
            gitar.Model = "yamaha";

            gitar.Cal();
            gitar.SesKontrol();

            Davul davul = new Davul();
            davul.Id = 2;
            davul.Model = "ucy56";

            YanFlut yanFlut = new YanFlut();
            yanFlut.Id = 3;
            yanFlut.Model = "vino578";

            Muzisyen muzisyen = new Muzisyen();
            muzisyen.Ad = "Okan";
            muzisyen.Soyad = "Candeniz";

            muzisyen.EnFavoriMuzikAleti = gitar;
            muzisyen.EnFavoriMuzikAleti = yanFlut;
            muzisyen.EnFavoriMuzikAleti = davul;//en son k,m, okuduysa en favori müzik aleti o olacak

            muzisyen.CalabildigiMuzikAletleri = new List<MuzikAleti>();

            muzisyen.CalabildigiMuzikAletleri.Add(gitar);
            muzisyen.CalabildigiMuzikAletleri.Add(yanFlut);
            muzisyen.CalabildigiMuzikAletleri.Add(davul);

            foreach (var item in muzisyen.CalabildigiMuzikAletleri)
            {
                Console.WriteLine(item.Id +"---"+ item.Model);
            }

            Console.ReadLine();


        }
    }
}
