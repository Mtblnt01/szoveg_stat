using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szoveg_stat
{
    class Program
    {
        static string szoveg_visszaf(string s)
        {
            string s_visszafele = "";
            for (int i = s.Length-1; i >= 0; i--)
            {
                s_visszafele+=s[i];
            }

            return s_visszafele;
        }

        static void Main(string[] args)
        {
            //0. feladat
            string forras = "szöveg";
            //2. feladat
            string szoveg_visszafele = szoveg_visszaf(forras);
            Console.WriteLine(szoveg_visszafele);

            Console.WriteLine("Nyomj egy gombot a kilépéshez");
            Console.ReadKey();
        }
    }
}
