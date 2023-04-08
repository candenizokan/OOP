using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_inheritance.Models
{
    internal class SmartPhone:MobilePhone
    {
        //multiinheritance : çoklu kalıtım. bir sınıf yalnızca ve en fazla 1 sınıftan ama istediği kadar interfaceten kalıtım alabilir

        public bool FrontCamera { get; set; }

        public SmartPhone()
        {
            _phoneType = "akıllı telefon";
            HasCamera = true;
        }

        public SmartPhone(bool frontCamera, string connectionType, string brand, bool isTouched, bool hasCamera=true):base(hasCamera,isTouched,brand,connectionType)
        {
            _phoneType = "akıllı telefon";
            FrontCamera = frontCamera;
        }
        public string VideoCall()
        {
            if (FrontCamera)
            {
                return "Görüntülü arama başlatılıyor";
            }
            else
            {
                return "arama gerçekleştirilemiyor";
            }
        }

        public override string ConnectionStatus()
        {
            return  "Mobil bağlantı yok";  
        }
    }
}
