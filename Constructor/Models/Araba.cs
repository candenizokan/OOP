using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.Models
{
    internal class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set;}
        public int MotorGucu { get; set; }

        public Araba()//benden başka cons varsa beni yazman lazım. beni boş halimle oluşturmalısın. başka cons yoksa ben zaten defaultum beni yazmasanda olur
        {

        }
        public Araba(string marka,string model)
        {
            Marka = marka;
            Model = model;
        }

        public Araba(string marka, string model, int motorGucu)
        {
            Marka = marka;
            Model = model;
            MotorGucu = motorGucu;
        }
    }
}
