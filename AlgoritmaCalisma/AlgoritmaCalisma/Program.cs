using System;
using System.Linq;
using System.Collections.Generic;

namespace AlgoritmaCalisma
{
    class Program
    {
        static void Main(string[] args)
        {
            //     Dizi En Buyuk Elemanini Bulma
            //int[] dizi = { 123, 123, 5, 9, 1, 2, 12, 11, 123 };
            //int eb = dizi[0];
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    if (eb < dizi[i])
            //    {
            //        eb = dizi[i];
            //    }
            //}
            //Console.WriteLine(eb);

            //  Dizi En Buyuk Elemanini Bulma
            //int[] dizi = { 123, 123, 5, 9, 1, 2, 12, 11, 123 };
            //int maxValue = dizi.Max();
            //int maxIndex = dizi.ToList().IndexOf(maxValue);
            //Console.WriteLine("Max Deger:" + maxValue);
            //Console.WriteLine("Deger Index:" + maxIndex);


            //  Dizi En Buyuk Elemanini Bulma
            //int[] anArray = { 1, 5, 2, 7 };
            // Finding max
            //int m = anArray.Max();
            // Positioning max
            //int p = Array.IndexOf(anArray, m);
            //Console.WriteLine("Max :{0} Index:{1}" , m, p);

            // Dizi En Buyuk Elemanini Bulma 
            //static int MaxAt(int[] arr, out int index)
            //{
            //    index = -1;
            //    int max = Int32.MinValue;

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] > max)
            //        {
            //            max = arr[i];
            //            index = i;
            //        }
            //    }

            //    return max;
            //}
            //int m, at;
            //m = MaxAt(new int[] { 1, 2, 7, 3, 4, 5, 6 }, out at);
            //Console.WriteLine("Max: {0}, found at: {1}", m, at);

            // En buyuk 2. elemani bulma
            //int[] dizi = { 12, 123, 123, 5, 9, 1, 23, 12, 11, 123 };
            //int eb1 = dizi[0];
            //int eb2 = dizi[1];
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    if (eb1 < dizi[i])
            //    {
            //        eb2 = eb1;
            //        eb1 = dizi[i];
            //    }
            //    else if (eb2 < dizi[i])
            //    {
            //        if (eb1 != dizi[i])
            //        {
            //            eb2 = dizi[i];
            //        }

            //    }
            //}
            //Console.WriteLine(eb2);


            // en buyuk 2. elemani bulama

            //int n, i, j = 0, lrg, lrg2nd;
            //int[] arr1 = new int[50];

            //Console.Write("\n\nFind the second largest element in an array :\n");
            //Console.Write("-----------------------------------------\n");

            //Console.Write("Input the size of array : ");
            //n = Convert.ToInt32(Console.ReadLine());
            ///* Stored values into the array*/
            //Console.Write("Input {0} elements in the array :\n", n);
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("element - {0} : ", i);
            //    arr1[i] = Convert.ToInt32(Console.ReadLine());
            //}
            ///* find location of the largest element in the array */
            //lrg = 0;

            //for (i = 0; i < n; i++)
            //{
            //    if (lrg < arr1[i])
            //    {
            //        lrg = arr1[i];
            //        j = i;
            //    }
            //}
            ///* ignore the largest element and find the 2nd largest element in the array */
            //lrg2nd = 0;
            //for (i = 0; i < n; i++)
            //{
            //    if (i == j)
            //    {
            //        i++;  /* ignoring the largest element */
            //        i--;
            //    }
            //    else
            //    {
            //        if (lrg2nd < arr1[i])
            //        {
            //            lrg2nd = arr1[i];
            //        }
            //    }
            //}

            //Console.Write("The Second largest element in the array is :  {0} \n\n", lrg2nd);

            // en buyuk ikinci eleman
            //static void print2largest(int[] arr,
            //              int arr_size)
            //{
            //    int i;

            //    // There should be 
            //    // atleast two elements
            //    if (arr_size < 2)
            //    {
            //        Console.Write(" Invalid Input ");
            //        return;
            //    }

            //    // Sort the array
            //    Array.Sort(arr);

            //    // Start from second last element
            //    // as the largest element is at last
            //    for (i = arr_size - 2; i >= 0; i--)
            //    {

            //        // If the element is not
            //        // equal to largest element
            //        if (arr[i] != arr[arr_size - 1])
            //        {
            //            Console.Write("The second largest " +
            //                          "element is {0}\n", arr[i]);
            //            return;
            //        }
            //    }

            //    Console.Write("There is no second " +
            //                  "largest element\n");
            //}

            // Driver code


            //int[] arr = { 12, 35, 1, 10, 34, 1 };
            //int n = arr.Length;

            //print2largest(arr, n);


            // en buyuk 2. eleman stack kullanimi
            //int[] dizi = { 12,123, 123, 5, 9, 1, 2, 12, 11, 123 };
            //Stack<int> st = new Stack<int>();
            //st.Push(dizi[0]);
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    if (st.Peek() < dizi[i])
            //    {
            //        st.Push(dizi[i]);
            //    }
            //}
            //Console.WriteLine(st.Pop());
            //Console.WriteLine(st.Pop());

            // en buyuk ikinci elemani bulma
            //int[] myArray = new int[] { 12, 123, 123, 5, 9, 1, 23, 12, 11, 123 };
            //int largest = int.MinValue;
            //int second = int.MinValue;
            //foreach (int i in myArray)
            //{
            //    if (i > largest)
            //    {
            //        second = largest;
            //        largest = i;
            //    }
            //    else if (i > second)
            //    {
            //        if (largest != i)
            //        {
            //            second = i;
            //        }
                    
            //    }
                    
            //}
            //Console.WriteLine(second);

            //Console.WriteLine(second);

            // en buyuk ikinci elemani bulma
            //int[] arr = { 12, 123, 123, 5, 9, 1, 23, 12, 11, 123 };
            //int largest = int.MinValue;
            //int secondlargest = int.MinValue;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > largest)
            //    {
            //        secondlargest = largest;
            //        largest = arr[i];
            //    }
            //    else if (arr[i] < largest && arr[i] > secondlargest)
            //    {
            //        secondlargest = arr[i];
            //    }
            //}
            //Console.WriteLine(secondlargest);

        }
    }
    }

