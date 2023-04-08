using System;

namespace Algoritmalar
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "12345233231133333333123449877656544ffddhtttyyywywywuıeı";
            int[] adetler = new int[255];
            
            for (int i = 0; i < s.Length; i++)
            {
                adetler[(byte)s[i]]++;
            }
            int eb = adetler[0];
            for (int i = 1; i < 255; i++)
            {
                if (eb < adetler[i]) eb = adetler[i];
            }
            Console.WriteLine(eb);
        }
    }
}
