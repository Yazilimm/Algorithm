using System;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "1";
            for (int i = 0; i < 4; i++)
            {
                string st = "1";
                for (int j = 1; j < s.Length; j++)
                {
                    int sayi = int.Parse(s[j].ToString()) + int.Parse(s[j - 1].ToString());
                    st = st + sayi.ToString();

                }
                st = st + "1";
                s = st;
                Console.WriteLine(s);
            }

        }
    }
}
