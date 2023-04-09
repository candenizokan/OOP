using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Eğer nesneye ait işlemler gerçekleştiriyorsak yani amaç belli bir duruma hizmet eden öğeleri bir sınıf / bir çatı altında toplamaksa ilgili sınıf STATIC olarak işaretleyebiliriz.
             * 
             * Static sınıflar kendi içlerinde SADECE STATIC öğeler barındırabilir. (prop, field, metod vb.)
             * 
             * Static bir sınıf başka bir sınıftan kalıtım alamaz ! ANCAK .NET mantığı gereği tüm sınıflar Sysetem.Objectten kalıtım alır ve bu sınıfın istisnasıdır.
             * 
             * Static sınıflara örnek olarak MATH sınıfı verilebilir çünkü static işaretli olduğundan o sınıftan bir instance(örnek/nesne) almadan sınıf içindeki metodlara erişebilir/kullanılabilir hale geldik.
             * 
             * Her sınıf static olarak işaretlenmemelidir çünkü RAM de stack yada heap haricinde kendilerine ait bir alanları vardır sistem düzenini bozmamak için bu alan şişirilmemelidir. Static işaretliler sabit bir şekilde hep orada yaşar.
             * 
             * Static sayesinde instancetan bağımsız olarak sınıfa ulaşılır.
             */
        }
    }
}
