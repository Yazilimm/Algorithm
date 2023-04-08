 using System;
 using System.Collections.Generic;

namespace AlgoritmaCalisma2
{
    class Program
    {
        static void Main(string[] args)
        {
            // En cok tekrar edeni yazmak



            // Cozum 1
            //int[] array = { 1, 2, 3, 3, 3, 32, 3, 5, 6, 7, 8, 9, 12, 34, 55, 2, 2, 3, 3 };
            //int eba = 0;
            //for (int i = 0; i < x.Length; i++)
            //{
            //    int adet = 0;
            //    for (int j = 0; j < x.Length; j++)
            //    {

            //        if (x[i]==x[j])
            //        {
            //            adet++;

            //        }
            //        if (adet > eba)
            //        {
            //            eba = adet;
            //        }

            //    }

            //}
            //Console.WriteLine(eba);

            // en cok tekrar eden 
            int[] x = { 1, 2, 3, 3, 3, 3, 2, 3, 5, 6, 7, 8, 9, 12, 34, 55, 2, 2, 3 };
            int[] deger = new int[56];
            for (int i = 0; i < x.Length; i++)
            {
                deger[x[i]]++;
            }
            int eb = 0;
            for (int i = 0; i < deger.Length; i++)
            {
                if (eb < deger[i])
                {
                    eb = deger[i];

                }
            }
            Console.WriteLine(eb);

            // Cozum 2
            //int[] array = { 1, 2, 3, 3, 3, 32, 3, 5, 6, 7, 8, 9, 12, 34, 55, 2, 2, 3, 3 };
            //int count = 1, tempCount;
            //int frequentNumber = array[0];
            //int tempNumber = 0;
            //for (int i = 0; i < (array.Length - 1); i++)
            //{
            //    tempNumber = array[i];
            //    tempCount = 0;
            //    for (int j = 0; j < array.Length; j++)
            //    {
            //        if (tempNumber == array[j])
            //        {
            //            tempCount++;
            //        }
            //    }
            //    if (tempCount > count)
            //    {
            //        frequentNumber = tempNumber;
            //        count = tempCount;
            //    }
            //}
            //Console.WriteLine("The most frequent number in this array is {0} has been repeated {1} times.", frequentNumber, count);

            // Cozum
            //string s = "123132123345646798845654333333";
            //int[] x = new int[100];
            //int a = 0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    a = x[(byte)s[i] - (byte)'0']++;

            //}
            //Console.WriteLine(a);
            //Console.WriteLine("islem bitti");

            //Cozum kac tane ayni eleman var
            //int[] a1 ={ 1, 3, 5, 7, 9, 12, 23, 45 };
            //int[] a2 = { 1, 5, 6, 9, 12, 55, 77, 8 };
            //int adet = 0;
            //for (int i = 0; i < a1.Length; i++)
            //{
            //    for (int j = 0; j < a2.Length; j++)
            //    {
            //        if (a1[i] == a2[j])
            //        {
            //            adet++;
            //        }
            //    }
            //}
            //Console.WriteLine(adet);

            // cozum ayni eleman sayisi
            //int[] a1 = { 1, 3, 5, 7, 9, 12, 23, 45 };
            //int[] a2 = { 1, 5, 6, 9, 12, 55, 77, 8 };

            //int[] x = new int[80];
            //for (int i = 0; i < a1.Length; i++)
            //{
            //    x[a1[i]]++;
            //}
            //for (int i = 0; i < a2.Length; i++)
            //{
            //    x[a2[i]]++;
            //}
            //int adet = 0;
            //for (int i = 0; i < x.Length; i++)
            //{
            //    if (x[i] > 1)
            //    {
            //        adet++;
            //    }
            //}
            //Console.WriteLine(adet);

            // ayni eleman cozum
            //static void EnterArray1IntoHashSet(int[] array1, HashSet<int> hs)
            //{
            //    foreach (int num in array1)
            //    {
            //        if (!hs.Contains(num))
            //        {
            //            hs.Add(num);
            //        }
            //    }
            //}

            //static int FindCommonInt(int[] array2, HashSet<int> hs)
            //{
            //    foreach (int num in array2)
            //    {
            //        if (hs.Contains(num))
            //        {
            //            return num;
            //        }
            //    }
            //    return -1;
            //}

            //int[] array1 = new int[7] { 5, 6, 7, 8, 1, 2, 3 };
            //int[] array2 = new int[7] { 13, 22, 3, 45, 67, 73, 85 };
            //HashSet<int> hs = new HashSet<int>();
            //EnterArray1IntoHashSet(array1, hs);
            //int commonElement = FindCommonInt(array2, hs);
            //if (commonElement != -1)
            //{
            //    Console.WriteLine(commonElement);
            //}
            //else
            //{
            //    Console.WriteLine("No Common Element");
            //}












        }
    }
}
