using System;

namespace algoritma7
{
    class Program
    {
        static void Main(string[] args)
        {
            // alt kume toplami 2n-1 alt kume vardir

            int k = 1;
            int toplam = 0;
            for (int i = 1; i <= 31; i++)
            {
                k = 1;
                toplam = 0;
                for (int bits = 1; bits <= 5; bits++)
                {
                    
                    if ((i & k)!=0) // ((i&(1<<bits))!=0)
                    {
                        Console.Write(bits+"");
                        toplam += bits;
                       
                    }
                    k <<= 1;
                }
                if (toplam==10)
                {
                    Console.WriteLine("toplam:"+toplam);
                }
                Console.WriteLine();
            }
        }
    }
}
