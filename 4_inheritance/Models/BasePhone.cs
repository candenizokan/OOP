using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_inheritance.Models
{
    internal class BasePhone
    {
        private string _brand;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        protected string _phoneType;//privateden bir tık daha iyi. kendi sınıfımda kullanabilirim + kalıtım verdiğim yerde de gösterebilirim. kendi sınıfımda zaten çalışıyor. BasePhone'dan inherit aldığı yerde de gösteriyor. hocanotu:private+yalnızca bu sınıftan kalıtım alan yerlerde çalışır.

        public string PhoneType
        {
            get { return _phoneType; }
            set { _phoneType = value; }
        }

        protected string _connectionType;

        public string ConnectionType
        {
            get { return _connectionType; }
            set { _connectionType = value; }
        }

        public BasePhone()//konstructru oluşturuyorum
        {
            _phoneType = "ahizeli telefon";//defaultta ben değer atadım. atama yaptığım için null gelmez. defaultta benim dediğim ahizeliyi alacak.
        }

        public BasePhone(string brand,string connectionType)
        {
            _brand = brand; 
            _connectionType = connectionType;
            _phoneType = "ahizeli telefon";
        }

        public virtual string Call()//virtual: ister buradaki gibi kullan. ister inherit ettiğin yerde içini ez. çalışma şekili.
            /*kahveGetir() bu katta amerikano getiriyor alt katta amerikano getiriyor
             virtual kahveGetir() normalde görevi amerikano getirmek, alt kat bunu filtre kahve isteyerek ezebilir.*/
        {
            return "Arama başlatılıyor";
        }

        //VIRTUAL => virtual olarak işaretlenmiş methodalar kalıtım verilen yerden istenirse aynen kullanılabilir. istenirse ezilip (override edilip) farklı bir şekilde kullanılmaya devam edilir. Ezmek zorunlu değil opsiyoneldir. // virtual keywordü hiç kullanmasaydık tanımlandığı gibi kullanmak zorundaydık.

        public virtual string ConnectionStatus()
        {
            return "Kablolu bağlantı mevcut.";
        }

    }
}
