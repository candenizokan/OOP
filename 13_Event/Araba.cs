using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Event
{
    internal class Araba
    {
        public Araba(string marka,int hiz)
        {
            Marka = marka;
            Hiz = hiz;
        }

        private string _marka;

        public string Marka
        {
            get { return _marka; }
            set { _marka = value; }
        }

        private int _hiz;

        public int Hiz
        {
            get { return _hiz; }
            set 
            { 
                _hiz = value;
                if (value>120)
                {
                    HizAsimi();//değer 120 den büyükse bizim için bu bir olay ve eventHandler mekanizması bunu yakalamalı ve delege iletmeli
                }
            }
        }


    }
}
