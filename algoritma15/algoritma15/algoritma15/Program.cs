using System;
using System.Linq;
namespace algoritma15
{
    class Program
    {
        
        static int knapSack(int[] v, int[] w, int c, int a)
        {
            if (a <= 0) return 0;
            if (c == -1) return 0;
            if (w[c] > a) return knapSack(v, w, c - 1, a);
            else return max(knapSack(v, w, c - 1, a), v[c] + knapSack(v, w, c - 1, a - w[c]));

        }
        static void Main(string[] args)
        {
            //string s = "1";
            //for (int i = 0; i < 4; i++)
            //{
            //    string st = "1";
            //    for (int j = 1; j < s.Length; j++)
            //    {
            //        int sayi = int.Parse(s[j].ToString()) + int.Parse(s[j - 1].ToString());
            //        st = st + sayi.ToString();

            //    }
            //    st = st + "1";
            //    s = st;
            //    Console.WriteLine(s);
            //}

            int n = 10;
            int[,] arr = new int[n, n];
          
            for (int line = 0; line < n; line++)
            {
                
                for (int i = 0; i <= line; i++)
                {

                    if (line == i || i == 0)
                    {
                        arr[line, i] = 1;
                    }
                        
                    else
                    {
                        arr[line, i] = arr[line - 1, i - 1] + arr[line - 1, i];
                    }
                        

                    Console.Write(arr[line, i]);
                }
                Console.WriteLine("");
            }

            int[] v = { 10, 20, 30, 40, 25 };
            int[] w = { 2, 3, 4, 5, 16 };
            int a = 6;


        }
    }
}
