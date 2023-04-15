using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Sealed.Models
{
    internal class BaseBook
    {
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }

        public virtual void GetUser()
        {
            //çalışacak kodlar
        }

        public virtual void GetRead()
        {
            //çalışılacak kod blok
        }
    }
}
