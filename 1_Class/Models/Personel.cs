using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Class.Models
{
    //access modifiers: private-public-protected-internal-protect internal
    public class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public bool SaglikProblemiVarMi { get; set; }
    }
}
