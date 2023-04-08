
//Cumledeki Kelime Sayisi
//Console.Write("Bir cumle giriniz: ");
//string cumle = Console.ReadLine();
//Console.Write("Bir harf giriniz: ");
//char harf = Convert.ToChar(Console.ReadLine());
//HarfSayac(harf, cumle);

//Console.ReadLine();

//static void HarfSayac(char harf, string cumle)
//{
//    int sayac = 0;
//    for (int i = 0; i < cumle.Length; i++)
//    {
//        if (cumle[i] == harf)
//        {
//            sayac++;
//        }
//    }
//    Console.WriteLine("Girdiginiz cumlede " + harf + " den " + sayac + " tane vardır.");
//}



//Dizideki Asal Sayi
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };


//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = 2; j < arr[i]; j++)
//    {
//        if ((arr[i] % j == 0))
//        {
//            Console.WriteLine("{0} :Asal Sayi Degil", +arr[i]);
//            break;

//        }
//        else
//        {
//            Console.WriteLine("{0} :Asal Sayi ", +arr[i]);
//            break;
//        }

//    }
//}

//// Dizi Siralama Artan
//int[] sayilar = new int[] { 2, 9, 4, 3, 5, 1, 7 };
//int temp = 0;
//for (int i = 0; i < sayilar.Length; i++)
//{
//    for (int j = i+1; j < sayilar.Length; j++)
//    {
//        if (sayilar[i] > sayilar[j])
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

//// Dizi Siralama Azalan
//int[] sayilar = new int[] { 2, 9, 4, 3, 5, 1, 7 };
//int temp = 0;
//for (int i = 0; i < sayilar.Length; i++)
//{
//    for (int j = i + 1; j < sayilar.Length; j++)
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


//Dizide tekrarlanan elemanlari silme
//int[] arr = new int[100];
//int num; // Dizide toplam kaç eleman olacağını tutacak değişken 
//int i, j, k;


//Console.Write("Dizi Eleman Sayısını Girin: ");
//num = Convert.ToInt32(Console.ReadLine());

////Dizi elemanlarını gir

//for (i = 0; i < num; i++)
//{
//    Console.Write("Diziye Değer Gir: ");
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}


//// Tekrarlayan elemanları bul

//for (i = 0; i < num; i++)
//{
//    for (j = i + 1; j < num; j++)
//    {
//        //Tekrarlı eleman varsa */
//        if (arr[i] == arr[j])
//        {
//            // Tekrarlı elemanı sil
//            for (k = j; k < num; k++)
//            {
//                arr[k] = arr[k + 1];
//            }

//            //Yinelenen öğeyi kaldırdıktan sonra boyutu azalt
//            num--;


//            j--;
//        }
//    }
//}

//// Yinelenen öğeleri sildikten sonra diziyi yazdır
//Console.WriteLine("\nYinelenen değerler silindikten sonra dizi içeriği : ");
//for (i = 0; i < num; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//Console.ReadLine();

//Dizide her kelimenin ilk harfini yazdirma
//string metin = "www yazilimkodlama com";

//Console.Write(metin[0]);
//for (int i = 0; i < metin.Length; i++)
//{
//    if (metin[i].ToString() != " ")
//    {
//        continue;
//    }
//    else
//    {
//        Console.Write(" " + metin[i + 1]);
//    }
//}
//Console.ReadKey();


// Mukemmel Sayi
//Console.WriteLine("Sayı giriniz");
//int sayi = Convert.ToInt32(Console.ReadLine());
//int toplam = 0;
//for (int i = 1; i < sayi; i++)
//{
//    if (sayi % i == 0)
//    {
//        toplam = toplam + i;
//    }
//}
//if (toplam == sayi)
//{
//    Console.WriteLine(sayi + "sayı Mükemmel Sayıdır");
//}
//else
//{
//    Console.WriteLine(sayi + "sayı Mükemmel Sayı Değildir");
//}
//Console.ReadLine();

//Dizide hangi sayidan kac adet var
//int sayac = 0;
//Random rnd = new Random();
//int[] dizi = new int[20];

//Console.WriteLine("Oluşturulan Dizi");
//Console.WriteLine("==============================================================");
//for (int i = 0; i < dizi.Length; i++)
//{
//    dizi[i] = rnd.Next(15, 25);
//    Console.Write(dizi[i].ToString() + " ");
//}
//Console.WriteLine();
//Console.WriteLine("==============================================================");

//for (int i = 10; i <= 25; i++)
//{
//    sayac = 0;
//    for (int j = 0; j < dizi.Length; j++)
//    {
//        if (i == dizi[j])
//        {
//            sayac++;
//        }
//    }
//    if (sayac != 0)
//        Console.WriteLine(i + "  Sayısından  " + sayac + "  tane  ");
//}
//Console.ReadKey();

////Buble Sort
//int gecici;
//Console.Write("Kaç Adet Sayı Girilecek ? >>>> ");
//int k = Convert.ToInt32(Console.ReadLine());

//int[] dizi = new int[k];
//for (int i = 0; i < k; i++)
//{
//    Console.Write("Dizinin {0}. elemanını girin : ", i + 1);
//    dizi[i] = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine("******************************");
//Console.WriteLine("Oluşturulan Dizi");
//DiziYazdir(dizi);

//////////Bubble Sort Sıralama/////////////////
//////////www.yazilimkodlama.com///////////////

//for (int i = 0; i <= dizi.Length - 1; i++)
//{
//    for (int j = 1; j <= dizi.Length - 1; j++)
//    {
//        if (dizi[j - 1] > dizi[j])
//        {
//            gecici = dizi[j - 1];
//            dizi[j - 1] = dizi[j];
//            dizi[j] = gecici;
//        }
//    }
//    DiziYazdir(dizi);
//}
//Console.WriteLine("Dizinin Sıralı Hali");
//DiziYazdir(dizi);
//Console.ReadKey();


//static void DiziYazdir(int[] dizi)
//{
//    for (int i = 0; i < dizi.Length; i++)
//    {
//        Console.Write("{0}   ", dizi[i]);
//    }
//    Console.WriteLine();
//    Console.WriteLine("==================================");
//}

////Palindrome sayi (saynin tersi ile kendisi ayni olan)
//public class Program
//{
//	public int reverse(int n)
//	{
//		int r, rev = 0;

//		while (n > 0)
//		{
//			r = n % 10;
//			rev = rev * 10 + r;
//			n = n / 10;
//		}
//		return rev;
//	}

//	public static void Main(string[] args)
//	{
//		int x, res;

//		Console.Write("Enter a number:");
//		x = Convert.ToInt32(Console.ReadLine());

//		Program obj = new Program();
//		res = obj.reverse(x);

//		if (res == x)
//		{
//			Console.WriteLine("Number is palindrome:" + x);
//		}
//		else
//		{
//			Console.WriteLine("Number is not palindrome:" + x);
//		}
//	}
//}

//// faktoriyel
//public class Program
//{
//	public int findFact(int n)
//	{
//		int i, f = 1;

//		for (i = 1; i <= n; i++)
//		{
//			f = f * i;
//		}
//		return f;
//	}

//	public static void Main(string[] args)
//	{
//		int x, f;

//		Console.Write("Enter a number:");
//		x = Convert.ToInt32(Console.ReadLine());

//		Program obj = new Program();
//		f = obj.findFact(x);

//		Console.WriteLine("Factorial is:" + f);
//	}
//}

//// diziden eleman silme
//using System;
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        int i, n, num, p = 0;
//        int[] arr = new int[10];

//        Console.Write("Enter size of an array:");
//        n = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Enter array elements:");
//        for (i = 0; i < n; i++)
//        {
//            arr[i] = Convert.ToInt32(Console.ReadLine());
//        }
//        Console.Write("Enter element for delete:");
//        num = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Before delete array elements:");
//        for (i = 0; i < n; i++)
//        {
//            Console.Write(arr[i] + " ");
//        }


//        for (i = 0; i < n; i++)
//        {
//            if (arr[i] == num)
//            {
//                arr[i] = arr[i + 1];
//                p = 1;
//            }
//            else if (p > 0)
//            {
//                arr[i] = arr[i + 1];
//            }
//        }

//        Console.Write("\nList After Deletion :");
//        for (i = 0; i < n - p; i++)
//        {
//            Console.Write(arr[i] + " ");
//        }
//    }
//}

//// diziye eleman ekleme
//using System;
//public class Program
//{
//	public static void Main(string[] args)
//	{
//		int[] arr = new int[10];

//		int n, i, num, loc;

//		Console.Write("Enter size of an array:");
//		n = Convert.ToInt32(Console.ReadLine());

//		Console.Write("Enter array elements:");
//		for (i = 0; i < n; i++)
//		{
//			arr[i] = Convert.ToInt32(Console.ReadLine());
//		}

//		Console.Write("Enter element for insert:");
//		num = Convert.ToInt32(Console.ReadLine());

//		Console.Write("Enter location:");
//		loc = Convert.ToInt32(Console.ReadLine());

//		for (i = n; i >= loc; i--)
//		{
//			arr[i] = arr[i - 1];
//		}
//		n++;
//		arr[loc - 1] = num;

//		Console.Write("\nList After Insertion :");
//		for (i = 0; i < n; i++)
//		{
//			Console.Write(arr[i] + " ");
//		}
//	}
//}

////dizide tekrar edilen elemanlari bulma
//using System;
//public class Program
//{
//	public static void Main(string[] args)
//	{
//		int i, j, v = 1;
//		int[] arr = new int[5];

//		Console.Write("Enter Five numbers:");
//		for (i = 0; i < arr.Length; i++)
//		{
//			arr[i] = Convert.ToInt32(Console.ReadLine());
//		}

//		Console.Write("duplicate elements:");
//		for (i = 0; i < arr.Length; i++)
//		{
//			for (j = i + 1; j < arr.Length; j++)
//			{
//				if (arr[i] == arr[j])
//				{
//					if (v == 1 && arr[j] != '\0')
//					{
//						Console.Write(arr[i] + " ");
//					}
//					arr[j] = '\0';
//					v++;
//				}
//			}
//			v = 1;
//		}
//	}
//}


//// dizide 2. en kucuk eleman 
//using System;
//public class Program
//{
//	public static void Main(string[] args)
//	{
//		int i, j, temp;
//		int[] arr = new int[5];

//		Console.Write("Enter five numbers:");
//		for (i = 0; i < arr.Length; i++)
//		{
//			arr[i] = Convert.ToInt32(Console.ReadLine());
//		}

//		for (i = 0; i < 5; i++)
//		{
//			for (j = i + 1; j < 5; j++)
//			{
//				if (arr[i] > arr[j])
//				{
//					temp = arr[i];
//					arr[i] = arr[j];
//					arr[j] = temp;
//				}
//			}
//		}
//		Console.WriteLine("Second smallest element:" + arr[1]);
//	}
//}

//// armstrong sayi (kuplerinin toplami sayiya esit olan)
//using System;
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

//// ekok
//Console.Write("1. Sayiyi giriniz: ");
//int sayi1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("2. Sayiyi giriniz: ");
//int sayi2 = Convert.ToInt32(Console.ReadLine());
//int max = sayi1 * sayi2;
//int ekok = 0;
///* 2 sayı eger aralarında asal ise ekoku
//çarpımlarıdır. Yanı 2 sayının ekoku maximum çarpımlarıdır.*/

//for (int i = max; i > 0; i--)
//{
//    if (i % sayi1 == 0 && i % sayi2 == 0)
//    {
//        ekok = i;
//    }
//}
//Console.WriteLine("Ekok = " + ekok);

//Console.ReadLine();

////ebob
//Console.Write("1. Sayiyi giriniz: ");
//int sayi1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("2. Sayiyi giriniz: ");
//int sayi2 = Convert.ToInt32(Console.ReadLine());
//int ebob = 0;

//for (int i = 1; i < sayi1; i++)
//{
//    if (sayi1 % i == 0 && sayi2 % i == 0)
//    {
//        ebob = i;
//    }
//}
//Console.WriteLine("Ebob = " + ebob);

//Console.ReadLine();

//// fibonocci
//int a = 0;
//int b = 1;
//int adet;
//Console.Write("Kaç Tane Fibonoççi Sayısı Görmek İstiyorsunuz = ");
//adet = Convert.ToInt32(Console.ReadLine());
//Console.Write(a + " " + b + " ");
//for (int i = 3; i <= adet; i++)
//{
//    int c = a + b;
//    Console.Write(c + " ");
//    a = b;
//    b = c;
//}
//Console.ReadLine();

//// mukemmel sayi
//int sayi;
////Klavyeden sayı okutuyoruz
//Console.Write("Bir Sayı Giriniz :");
//sayi = Convert.ToInt32(Console.ReadLine());
//int toplam = 0;
////Sayıya kadar bir döngü kuruyoruz
//for (int i = 1; i <= sayi / 2; i++)
//{
//    if (sayi % i == 0)
//    {
//        toplam = toplam + i;
//    }
//}
//Console.WriteLine("----------------------------------------------------");
////Sayının mükemmel sayı olup olmadığını kontrol ediyoruz.
//if (sayi == toplam)
//{
//    Console.WriteLine(sayi + " Sayısı Bir Mükemmel Sayıdır");
//}
//else
//{
//    Console.WriteLine(sayi + " Sayısı Bir Mükemmel Bir Mükemmel Sayı Değildir");
//}
//Console.WriteLine("----------------------------------------------------");
//Console.ReadKey();


//// ref deger
//public class F_DoubleRef
//{
//    public static void Double(ref int n)
//    {
//        n = n + n;
//    }

//    public static void Main()
//    {
//        int x = 2;

//        Double(ref x);
//        Console.WriteLine(x);
//    }
//}


//// ref ornek
//static string GetNextName(ref int id)
//{
//    string returnText = "Next-" + id.ToString();
//    id += 1;
//    return returnText;
//}
//static void Main(string[] args)
//{
//    int i = 1;
//    Console.WriteLine("Previous value of integer i:" + i.ToString());
//    string test = GetNextName(ref i);
//    Console.WriteLine("Current value of integer i:" + i.ToString());
//}

//// out ornek
//static string GetNextNameByOut(out int id)
//{
//    id = 1;
//    string returnText = "Next-" + id.ToString();
//    return returnText;
//}
//static void Main(string[] args)
//{
//    int i = 0;
//    Console.WriteLine("Previous value of integer i:" + i.ToString());
//    string test = GetNextNameByOut(out i);
//    Console.WriteLine("Current value of integer i:" + i.ToString());
//}
////string compare
//bool CompareStrings(string str1, string str2)
//{
//    int length = str1.Length;
//    if (length != str2.Length)
//        return false;
//    for (int i = 0; i < length; i++)
//        if (str1[i] != str2[i])
//            return false;
//    return true;
//}

//// subtring
//Console.Write("Please enter your word : ");
//string word = Console.ReadLine();

//Console.Write("Starting position : ");
//int start = Convert.ToInt32(Console.ReadLine());

//Console.Write("Number of letters : ");
//int numberOfLetters = Convert.ToInt32(Console.ReadLine());

//int x = word.Length - numberOfLetters;

//int end = word.Length - x;

//for (int counter = start; counter <= end; counter++)
//{
//    Console.Write(word[counter]);
//}

//Console.ReadLine();

////string split
//static string[] split(string txt, char[] delim)
//{
//    char[] text = txt.tochararray();
//    string[] result = new string[0];
//    int count = 0;
//    int i = 0;
//    stringbuilder buff = new stringbuilder();
//    while (i < text.length)
//    {
//        bool found = false;
//        foreach (char del in delim)
//        {
//            if (del == txt[i])
//            {
//                found = true;
//                break;
//            }
//        }
//        if (found)
//        {
//            count++;
//            array.resize(ref result, count);
//            result[count - 1] = buff.tostring();
//            buff = new stringbuilder();
//        }
//        else
//        {
//            buff.append(txt[i]);
//        }

//        i++;
//    }

//    if (buff.length != 0)
//    {
//        count++;
//        array.resize(ref result, count);
//        result[count - 1] = buff.tostring();
//    }

//    return (result);
//}



//  public class PalindromeExample
//{
//    public static void Main(string[] args)
//    {
//        int a, b, toplam = 0, sayi;
//        Console.Write("Bir sayı giriniz:");
//        a = int.Parse(Console.ReadLine());
//        sayi = a;
//        while (a > 0)
//        {
//            b = a % 10;
//            toplam = (toplam * 10) + b;
//            a = a / 10;
//        }
//        if (sayi == toplam)
//            Console.Write("Girdiğiniz sayı palindrom bir sayıdır.");
//        else
//            Console.Write("Girdiğiniz sayı palindrom bir sayı değildir.");
//    }
//}


int no, r, toplam = 0, n = 0;
Console.WriteLine("Bir Sayı Girinn");
no = Int32.Parse(Console.ReadLine());
n = no;
while (n > 0)
{
    r = n % 10;
    n = n / 10;
    toplam += r * r * r;
}

if (toplam == no)
{
    Console.WriteLine("{0}  Armstrong sayısıdır", no);
}
else
{
    Console.WriteLine("{0} Armstrong sayısı değildir", no);
}
Console.ReadLine();