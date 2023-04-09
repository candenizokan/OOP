using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Static
{
    internal static class Yardimci
    {

        public static string Duzenle(this string word)
        {
            word = word.ToLower()
                .Replace('ş', 's')
                .Replace('ı', 'i')
                .Replace('ğ', 'g');

            return word;
        }
    }
}
