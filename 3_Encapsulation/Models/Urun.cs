using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Encapsulation.Models
{
    internal class Urun
    {
        public int MyProperty { get; set; }

        private int _id;

        public int Id
        {
            get { return _id; }//field'ın değerini yabi _id okuyup geri döndürüyor
            set { _id = value; }//dışarıdan gelen value yi atıyorum _id'ya
        }

        private int _ad;

        public int Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        private double _fiyat;

        public double Fiyat
        {
            get { return _fiyat; }
            set 
            {
                if (value>0)
                {
                    _fiyat = value;//atanacak değer sıfırdan büyükse ata
                }
                else
                {
                    Console.WriteLine("fiyat bilgisini kontrol ediniz");
                }
            
            }
        }



    }
}
