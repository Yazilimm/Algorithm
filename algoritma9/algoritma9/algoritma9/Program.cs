using System;

namespace algoritma9
{
    class Program
    {
        static int max(int a , int b)
        {
            return a > b ? a : b;
        }
        static void Main(string[] args)
        {   
            //// longest comman substring
            //// dinamik programlama problemi recursive hem de dongulerle cozulebilir 
            //string m = "abcdefghj";
            //string n = "a1b23cdf45ab6abcdef78";
            //int[,] lcs = new int[m.Length, n.Length];
            //int eb = 0;
            //for (int i = 0; i < m.Length; i++)
            //{
            //    for (int j = 0;  j < n.Length;  j++)
            //    {
            //        if (m[i] == n[j])
            //        {
            //            if (i == 0 || j == 0)
            //            {
            //                lcs[i, j] = 1;
            //            }
            //            else
            //            {
            //                lcs[i,j] = lcs[i - 1, j - 1] + 1;
            //                if (eb < lcs[i, j])
            //                {
            //                    eb = lcs[i, j];
            //                }
            //            }
            //        }
                    
            //    }
            //}
            //Console.WriteLine(eb);

            // en uzun sunsequnece buluncakcak

            string t = "12a3b4cde";
            string z = "1dabtd3";
            int[,] lcs2 = new int[t.Length, z.Length];
            int eb2= 0;
            for (int i = 0; i < t.Length; i++)
            {
                for( int j =0; j< z.Length; j++)
                {
                    if (t[i] == z[j])
                    {
                        if (i*j==0)
                        {
                            lcs2[i, j] = 1;
                        }
                        else
                        {
                            lcs2[i, j] = lcs2[i - 1, j - 1] + 1;
                            if (eb2 < lcs2[i, j])
                            {
                                eb2 = lcs2[i, j];
                            }
                        }
                    }
                    else
                    {
                        if (i==0)
                        {
                            if (j!=0)
                            {
                                lcs2[i, j] = lcs2[i, j - 1];
                            }
                            else
                            {
                                lcs2[i, j] = 0;
                            }
                           
                        }
                        if (j== 0)
                        {
                            if (i!= 0)
                            {
                                lcs2[i, j] = lcs2[i-1,j];
                            }
                            else
                            {
                                lcs2[i, j] = 0;
                            }

                        }
                        if (i*j!=0)
                        {
                           lcs2[i,j]= max(lcs2[i, j - 1], lcs2[i - 1, j]);
                        }
                        
                    }

                }
            }
            Console.WriteLine(eb2);


        }
    }
}
