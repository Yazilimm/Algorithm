using System;

namespace algoritma10
{
    class Program
    {
        static string[] hash = new string[32];
        static int hf ( string text)
        {
            int a = 0;
            for (int i = 0; i < text.Length; i++)
            {
                a += (byte)text[i];
            }
            // return a % hash.Length ; //bolmeli hash
            return a & 0x1f; // carpmali hash
        }
        static void hashinsert(string text)
        {
            hash[hf(text)] = text;
        }
        static bool hashsearch(string text)
        {
            if (hash[hf(text)] == text)
            {
                return true;
            }
            return false;
            // return hash[hf(text)] == text ? true : false;
        }
        static void hashdelete(string text)
        {
            hash[hf(text)] = "";
        }
        static void Main(string[] args)
        {
            hashinsert("mustafa");
            hashinsert("ahmet");
            Console.WriteLine(hashsearch("mustafa"));
            Console.WriteLine(hashsearch("ahmet"));
            Console.WriteLine(hashsearch("Turan"));
            hashdelete("mustafa");
            Console.WriteLine(hashsearch("mustafa"));

            //-----------
            /*
            static string[] hash = new string[32];
            static int hf(string text)
            {
                int a = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    a += (byte)text[i];
                }
                //  return a % hash.Length;
                return a & 0x1f;
            }
            static void hashInsert(string text)
            {
                hash[hf(text)] = text;
            }

            static bool hashSearch(string text)
            {

                return hash[hf(text)] == text ? true : false;
            }
            static void hashDelete(string text)
            {
                hash[hf(text)] = "";
            }

            static void Main()
            {

                // hashing nedir?
                // çok hızlı arama metodudur?
                // verilerle süreklki çalışıyor
                // insert, delete ve SEARCH
                // arama çok önemlidir
                // veritabanı dünyasında arama
                // b+ tree yapılarıyla çözülmüş
                // RAMdeki arama
                // 2 şekilde binary search ikili arama
                // sequential sorasız arama
                // O(n); log(n) hızlanacak   gidipte bir b+ rmde oluşturmak sağlıklı dğei
                //  diziler imdadımıza yetişiyor

                // dizi için ulaşma maliyeti O(1)
                //  dizileri kullnarak gerçekleştirilen bir arama yöntemidir
                // veriler dizi üzerinde haritalanır yönlendirilir
                //  HASHİNG   dizi
                // data search   string, int
                // hash function görevi
                // "mustafa"  hash
                // hf("mustafa")  sayı    hash[sayı]="mustafa";
                //  hash[ hf("mustafa") ] = "mustafa";
                //   Writeline(hash[hf("mustafa")])
                //  hash function
                // basit matematiksel ifadelerden oluşmalıdır
                // deterministic, aynı input her daim aynı output (100)
                // homojen evenly-distributed eşit dağılmış
                //  hf(....)    hemen hemen her inpu için farklı bir değer üretsin  100 imkansız
                //  mustafa   ASCII karşılığğını toplasam ne olur;  bu sayıyıda   
                // mod 20


                hashInsert("mustafa");
                hashInsert("ahmet");
                Console.WriteLine(hashSearch("mustafa"));
                Console.WriteLine(hashSearch("ahmet"));
                Console.WriteLine(hashSearch("Turan"));

                hashDelete("mustafa");
                Console.WriteLine(hashSearch("mustafa"));

                //     return;
                Stopwatch sw = new Stopwatch();
                int a = 1;
                sw.Start();
                for (int i = 0; i < 100000000; i++)
                {
                    a = i >> 1;
                }
                sw.Stop();
                Console.WriteLine(sw.ElapsedMilliseconds);
            }
                */

            hashinsert("ayla");
            hashinsert("alay");
            Console.WriteLine(hf("ayla"));
            Console.WriteLine(hf("alay"));
            // ayni deger uretilmesi hashing  olumsuz yani collisipn  sorunu
            Console.WriteLine(hashsearch("alay"));
            Console.WriteLine(hashsearch("ayla"));
            
            



        }
    }
}
