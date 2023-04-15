using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Event
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             
            Event-olay
            * örnek olarak kullanıcının fareyle tıklanmış/linke butona tıklaması yada kod akışında beklediğinmiz yada olabileceğini düşündüğümüz bir olayın olması durumudur.
            * 
            * olay ilk önce eventHandler yani olay yakalıyıcı mekanizması tarafından yakalanır ve devamında mekanizma delegate ile akışa devam eder ve yapılacakları delegate yapar
            * 
            * delegate oluşturma işlemleri burada da gerçekleşir
            * 
            * dikkat edilmesi gereken nokta =>olaylar gerçekleştiğinde yakalayıcı mekanizma adı ile delegenin imzasının aynı olması gerektiğidir ki kimle kimin çalıştığı anlaşılsın.
            * 

             */

            Araba araba = new Araba("BMW", 78);
            araba.HizAsimi += new HizAsimiEventHandler();
        }
    }
}
