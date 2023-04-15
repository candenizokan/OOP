using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Delegate
{
    internal class Program
    {
        public delegate void Logger(string message);
        static void Main(string[] args)
        {
            /*
             Delegate 
            * bir olay gerçekleştiği zaman birden fazla fonksiyonu çağırmak istersek delegate oluşturup kullanırız.
            * bir delegate oluşturmak için aşamalar
            * tanımlama - declare
            * orneklem - instance
            * çağrıda bulunma - invoke
            * 
            * temsilci olarak da adlandırılan bu yapı projeyi ayakta tutan yapıları yormadan, onların işlemlerini üzerine alan tiptir
            * unutmayalım => delegate lerde birer sınıftır (value type ve referans tiplerde geçmişti)
             
             */

            //2. INTANCE-ORNEKLEM

            void SmsLogger(string message)
            {
                Console.WriteLine("SmsLogger"+message);
            }

            void MailLogger(string message)
            {
                Console.WriteLine("MailLogger"+message);
            }

            void XmlLogger(string message)
            {
                Console.WriteLine("XmlLogger"+message);
            }

            Logger logger = new Logger(MailLogger);
            logger += SmsLogger;
            logger += XmlLogger;

            //3.Invoke - çağrı

            logger.Invoke("merhabalar beklediğiniz üründe indirim var !");

            Console.ReadLine();




        }
    }
}
