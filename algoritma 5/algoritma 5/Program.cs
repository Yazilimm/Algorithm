using System;

namespace algoritma_5
{
    class Program
    {
        static uint dn(uint a , uint b , uint d)
        {
            if (d==0)
            {
                return b;
            }
            if ((a&d)!=0)
            {
                b = b + d;
            }
            d = d << 1;
            return dn(a, b, d);
        }
        static int birbul ( uint a)
        {
            if (a==0)
            {
                return 0;

            }
            if ((a&1)==1)
            {
                return 1 + birbul(a >> 1);
            }
            else
            {
                return 0 + birbul(a >> 1);
            }
        }
        static void Main(string[] args)
        {
            //uint a = 0xf0f0f0f0;
            //string s = "";
            //for (int i = 0; i < 32; i++)
            //{
            //    if ((a & 1) == 1)
            //    {
            //        s = "1" + s;
            //    }
            //    else
            //    {
            //        s = "0" + s;
            //    }
            //    a = a >> 1;
            //}
            //Console.WriteLine(s);
            //Console.WriteLine(a);

            //uint a = 0xf0f0f0f0;
            //string s = "";
            //uint b = 1;
            //for (int i = 0; i < 32; i++)
            //{
            //    if ((a & b) == b) // ((a & b) != 0 )
            //    {
            //        s = "1" + s;
            //    }
            //    else
            //    {
            //        s = "0" + s;
            //    }
            //    b = b << 1;
            //}
            //Console.WriteLine(s);

            // recursive ile cozme
            //uint a = 0xf0f0f0f0;
            //Console.WriteLine(birbul(a));

            // State Ile Cozme
            //int[,] q = new int[5, 2];
            //q[0, 0] = 0; q[0, 1] = 1;
            //q[1, 0] = 0; q[1, 1] = 2;
            //q[2, 0] = 3; q[2, 1] = 1;
            //q[3, 0] = 4; q[3, 1] = 1;
            //q[4, 0] = 4; q[4, 1] = 4;
            //int state = 0;
            //uint b = 0xffffff;
            //for (int i = 0; i < 32; i++)
            //{
            //    state = q[state, (b & 1)];
            //    b = b >> 1;
            //}
            //if (state==4)
            //{
            //    Console.WriteLine("tamam");
            //}
            //else
            //{
            //    Console.WriteLine("bulunamadi");
            //}

            // b=a bitwise islemler ile cozme uint a = 1234; uint b =0;
            //uint a = 1234;
            //uint b = 0;
            //uint d = 1;
            //for (int i = 0; i < 32; i++)
            //{
            //    if ((a & d) != 0)
            //    {
            //        b = b | d;
            //    }
            //    d = d << 1;
            //}
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            // recursive
            uint a = 1234;
            uint b = 5;
            uint d = 1;
            Console.WriteLine(dn(a, 0, 1));

            //bir 32 bitlik sayinin  en yuksek seviyeli 4 bitini 1 arttiriniz
            //    uint a = 0x00000001;
            //    uint b = a;
            //    b = b >> 28;
            //    b = b + 1;
            //    a = a << 4;
            //    a = a >> 4;
            //    b = b << 28;
            //    a = a | b;
            //    Console.WriteLine(a);
            //    //cozum 2
            //    b = 0x1000000;
            //    a = a + b;


            //uint a = 1234;
            //uint b = 0;
            //for (int i = 0; i < 32; i++)
            //{
            //    if ((a<<1)>>1!=a)
            //    {
            //        b = b + 1;
            //    }
            //    a = a << 1;
            //    if (a!=31)
            //    b = b << 1;
            //}
            //Console.WriteLine(a);
            //Console.WriteLine(b);

        }
    }
}
