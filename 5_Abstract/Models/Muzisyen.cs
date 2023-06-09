﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Abstract.Models
{
    internal class Muzisyen
    {
        public Muzisyen()
        {
            CalabildigiMuzikAletleri = new List<MuzikAleti>();//eleman eklenebilecek pozisyona getiriyorum
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public override string ToString()
        {
            return Ad + " "+ Soyad;//ben bu proje içinde toStringi override ettim
        }

        public string FullName => Ad + " " + Soyad;

        public MuzikAleti EnFavoriMuzikAleti { get; set; }
        public List<MuzikAleti> CalabildigiMuzikAletleri { get; set; }//sınıf içinde list propertysi varsa bunu başlangçta ayağa kaldırmam lazım daha bu nesne ayağa kalkarken nedir ctorda bunu ayağa kaldırıcam
        //koleksiyon varsa mutlaka ctorda sepeti oluştur bırak o yapsın. çağırdığın yerde sen yapma
       // ne kadar koleksiyon yapısı varsa ctorda ayağa kaldırmam daha mantıklı
    }
}
