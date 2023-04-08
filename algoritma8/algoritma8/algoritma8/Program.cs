using System;

namespace algoritma8
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 4;
            //int[] x = new int[n + 1];
            //int[] sayilar ={123,456,789,900};
            //int s = 2;
            //int adet = 0;

            //while (x[n]!=1)
            //{
            //    adet++;
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (x[i] == 1)
            //        {
            //            Console.Write(sayilar[i] + "  ");
            //        }

            //    }
            //    Console.WriteLine();
            //    x[0]++;
            //    //if (x[0] == s)
            //    //{
            //    //    x[0] = 0;
            //    //    x[1]++;
            //    //}
            //    //if (x[1]==s)
            //    //{
            //    //    x[1] = 0;
            //    //    x[2]++;
            //    //}
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (x[j]==s)
            //        {
            //            x[j] = 0;
            //            x[j + 1]++;
            //        }
            //    }
            //}


            // -------------------------------------------------
            static bool kontrol(int[,] x)
            {
                return true;
            }
            int[,] tahta = new int[8, 8];
            int[] v = new int[8];
            int length = 8;
            int adet = 0;
            for ( v[0] = 0; v[0] < length; v[0]++)
            {
                tahta[0, v[0]] = 1;
                for (v[1] = 0;  v[1]< length; v[1]++)
                {
                    tahta[1, v[1]] = 1;
                    for (v[2] = 0; v[2] < length; v[2]++)
                    {
                        tahta[2, v[2]] = 1;
                        for (v[3] = 0; v[3] < length; v[3]++)
                        {
                            tahta[3, v[3]] = 1;
                            for (v[4] = 0; v[4] < length; v[4]++)
                            {
                                tahta[4, v[4]] = 1;
                                for (v[5] = 0; v[5] < length; v[5]++)
                                {
                                    tahta[5, v[5]] = 1;
                                    for (v[6] = 0; v[6] < length; v[6]++)
                                    {
                                        tahta[6, v[6]] = 1;
                                        for (v[7] = 0; v[7] < length; v[7]++)
                                        {
                                            tahta[7, v[7]] = 1;
                                            if (kontrol(tahta))
                                            {
                                                adet++;
                                            }
                                            tahta[7, v[7]] = 0;
                                        }
                                        tahta[6, v[6]] = 0;
                                    }
                                    tahta[5, v[5]] = 0;
                                }
                                tahta[4, v[4]] = 0;
                            }
                            tahta[3, v[3]] = 0;
                        }
                        tahta[2, v[2]] = 0;
                    }
                    tahta[1, v[1]] = 0;
                }
                tahta[0, v[0]] = 0;
            }
            Console.WriteLine(adet);

        }
    }
}
