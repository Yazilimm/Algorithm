using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "ABCDEFGHJKLMN";
            //string s2 = "ABC";
            //int k = 0;
            //for (int i = 0; i < s1.Length - s2.Length; i++)
            //{
            //    k = 0;
            //    for (int j = 0; j < s2.Length; j++)
            //    {
            //        if (s1[i + j] == s2[j])
            //        {
            //            k++;
            //        }
            //    }
            //    if (k == s2.Length)
            //    {
            //        Console.WriteLine("bulundu");
            //        break;
            //    }
            //}

            // kelimenin icinde kelime bulma 
            //string s = "abcdefghjklmn";
            //string st = "defgh";

            //for (int i = 0; i < s.Length - st.Length; i++)
            //{
            //    int adet = 0;
            //    while (s[i + adet] == st[adet])
            //    {
            //        adet++;
            //        if (adet == st.Length) break;
            //    }
            //    if (adet == st.Length) Console.WriteLine("Bulundu");
            //}


            string s1 = "BBBBBABCCCCCCBBBBB";
            string s2 = "ABC";
            int[,] Q = new int[4, 3];
            int state = 0;
            Q[0, 0] = 1; Q[0, 1] = 0; Q[0, 2] = 0;
            Q[1, 0] = 1; Q[1, 1] = 2; Q[1, 2] = 0;
            Q[2, 0] = 1; Q[2, 1] = 0; Q[2, 2] = 3;
            Q[3, 0] = 3; Q[3, 1] = 3; Q[3, 2] = 3;

            for (int i = 0; i < s1.Length; i++)
            {
                state = Q[state, s1[i] - (byte)'A'];
            }
            if (state == 3)
            {
                Console.WriteLine("Bulundu");
            }


            //string s1 = "BBBBBABCCCCCCBBBBBSDGHJLMN";
            //string s2 = "ABC";
            //int[,] Q = new int[4, 30];
            //int state = 0;
            //Q[0, 0] = 1; Q[0, 1] = 0; Q[0, 2] = 0;
            //Q[1, 0] = 1; Q[1, 1] = 2; Q[1, 2] = 0;
            //Q[2, 0] = 1; Q[2, 1] = 0; Q[2, 2] = 3;
            //Q[3, 0] = 3; Q[3, 1] = 3; Q[3, 2] = 3;
            //for (int i = 0; i < 30; i++)
            //{
            //    Q[3, i] = 3;
            //}
            //for (int i = 0; i < s1.Length; i++)
            //{

            //    state = Q[state, s1[i] - (byte)'A'];

            //}
            //if (state == 3)
            //{
            //    Console.WriteLine("Bulundu");
            //}

            //kelimenin icinde kelime bulma
            //string s = "abcdefghjklmn";
            //string st = "defgh";
            //bool b = s.Contains(st);
            //Console.WriteLine("'{0}' is in the string '{1}': {2}", s, st, b);
            //if (b)
            //{
            //    int index = s.IndexOf(st);
            //    if (index >= 0)
            //    {
            //        Console.WriteLine("'{0} begins at character position {1}", st, index + 1);
            //    }

            //}



        }
    }
}
