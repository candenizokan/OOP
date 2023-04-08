using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_inheritance.Models
{
    internal class MobilePhone:BasePhone
    {
        public bool HasCamera { get; set; }
        public bool IsTouched { get; set; }

        public MobilePhone()
        {
            //senin telefon tipin mobil telefondur. normalde kalıtım alıyorsun ama alma
            _phoneType = "Mobile Phone";
        }

        public MobilePhone(bool hasCamera, bool isTouched)
        {
            HasCamera = hasCamera;
            IsTouched = isTouched;
            _phoneType = "Mobile Phone";
        }

        //public MobilePhone(bool hasCamera, bool isTouched,string brand,string connectionType)
        //{
        //    HasCamera = hasCamera;
        //    IsTouched = isTouched;
        //    _phoneType = "Mobile Phone";
        //    Brand = brand;
        //    ConnectionType = connectionType;
        //}

        //Constructor Chaining :zincirleme constructor. atanın atamayı bildiği değerleri enum constructorına gönderiyorum.
        public MobilePhone(bool hasCamera, bool isTouched, string brand, string connectionType):base(brand, connectionType)
        {
            HasCamera = hasCamera;
            IsTouched = isTouched;
            _phoneType = "Mobile Phone";
            //Brand = brand;
            //ConnectionType = connectionType;
        }

        public string TakePhote()
        {
            if (HasCamera)
            {
                return "Fotoğraf çekiliyor...";
            }
            else
            {
                return "Fotoğraf çekilemez";
            }
        }

        //kalıtım alınan sınıfta virtual olarak tanımlanan metodu ezerek(override) içini istediğimiz gibi işlemiş olduk
        public override string ConnectionStatus()
        {
            return "Mobil bağlantı mevcut";
        }
    }
}
