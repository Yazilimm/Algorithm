//Console.WriteLine("Bir cumle giriniz");
//string cumle = Console.ReadLine();
//Console.WriteLine("Bir harf giriniz");
//char harf = Convert.ToChar(Console.ReadLine());
//harfsayisi(harf, cumle);
//static void harfsayisi(char harf, string cumle)
//{
//int sayac = 0;
//for (int i = 0; i < cumle.Length; i++)
//{
//if (cumle[i] == harf)
//{
//sayac++;
//}

//}
//Console.WriteLine("Cumle icinde secilen harften: {0} tane vardir", sayac);
//}

//int[] sayilar = new int[] { 2, 9, 4, 3, 5, 1, 7 };
//int temp = 0;
//for (int i = 0; i < sayilar.Length; i++)
//{
//    for (int j = 0; j < sayilar.Length; j++)
//    {
//        if (sayilar[i] < sayilar[j])
//        {
//            temp = sayilar[i];
//            sayilar[i] = sayilar[j];
//            sayilar[j] = temp;
//        }
//    }

//}
//Console.WriteLine("Artan Sıralı :");
//foreach (var item in sayilar)
//{
//    Console.Write(item + " ");
//}
//Console.ReadLine();

////Dizide tekrarlanan elemanlari silme
//    int[] arr = new int[100];
//int num; // Dizide toplam kaç eleman olacağını tutacak değişken 
//int n, m;

//Console.Write("Dizi Eleman Sayısını Girin: ");
//num = Convert.ToInt32(Console.ReadLine());

//Dizi elemanlarını gir

//for (n = 0; n < num; n++)
//{
//    Console.Write("Diziye Değer Gir: ");
//    arr[n] = Convert.ToInt32(Console.ReadLine());
//}


//for (int i = 0; i < num; i++)
//{
//    for (int j = i+1; j < num; j++)
//    {
//        if(arr[i] == arr[j])
//        {
//            for (int k = j; k < num; k++)
//            {
//                arr[k] = arr[k + 1];
//            }
//            num--;

//            j--;
//        }
//    }
//}
//// Yinelenen öğeleri sildikten sonra diziyi yazdır
//Console.WriteLine("\nYinelenen değerler silindikten sonra dizi içeriği : ");
//for (m = 0; m < num; m++)
//{
//    Console.WriteLine(arr[m]);
//}

//Console.ReadLine();

//string metin = "www,yazilimkodlama,com";

//Console.WriteLine(metin[0]);
//for (int i = 0; i < metin.Length; i++)
//{
//    if (metin[i].ToString() == ",")
//    {
//        continue;

//    }
//    else
//    {

//        Console.Write(metin[i]);
//    }
//}


//public class Program
//{
//    public int reverse(int n)
//    {
//        int r, rev = 0;

//        while (n > 0)
//        {
//            r = n % 10;
//            rev = rev * 10 + r;
//            n = n / 10;
//        }
//        return rev;
//    }

//    public static void Main(string[] args)
//    {
//        int x, res;

//        Console.Write("Enter a number:");
//        x = Convert.ToInt32(Console.ReadLine());

//        Program obj = new Program();
//        res = obj.reverse(x);

//        if (res == x)
//        {
//            Console.WriteLine("Number is palindrome:" + x);
//        }
//        else
//        {
//            Console.WriteLine("Number is not palindrome:" + x);
//        }
//    }
//}

// armstrong sayi
//    using System;
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        int n, num, r, rev = 0;

//        Console.Write("Enter a number:");
//        n = Convert.ToInt32(Console.ReadLine());

//        num = n;

//        while (n > 0)
//        {
//            r = n % 10;
//            rev = rev + r * r * r;
//            n = n / 10;
//        }

//        if (num == rev)
//        {
//            Console.WriteLine("Number is armstrong:" + num);
//        }
//        else
//        {
//            Console.WriteLine("Number is not armstrong:" + num);
//        }
//    }
//}


