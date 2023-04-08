using System;

namespace Algoritma3
{
    class Program
    {
        static void Main(string[] args)
        {
            // sayiyi yaziya cevirme
            //string[,] ss = { { "", "bir", "iki", "uc", "dort", "bes", "alti","yedi","sekiz","dokuz", }, { "", "on", "yirmi", "otuz", "kirk", "elli", "atmis", "yetmis", "seksen", "doksan", },
            //    { "","yuz","ikiyuz","ucyuz","dortyuz","besyuz","altiyuz","yediyuz","sekizyuz","dokuzyuz"},{"","bin","ikibin","ucbin","dortbin","besbin","altibin","yedibin","sekizbin","dokuzbin"},
            //    { "", "on", "yirmi", "otuz", "kirk", "elli", "atmis", "yetmis", "seksen", "doksan", },{ "","yuz","ikiyuz","ucyuz","dortyuz","besyuz","altiyuz","yediyuz","sekizyuz","dokuzyuz"}};

            //string sayi = "123456";
            //string yazi = "";
            //for (int i = 0; i < sayi.Length; i++)
            //{
            //    yazi += ss[sayi.Length - i - 1, (byte)sayi[i] - (byte)'0'];
            //}
            //Console.WriteLine(yazi);

            //11 den sonra 00 ya da 10  gelen stringler kabul edilecekti. RED


            //int[,] Q = new int[5, 2];
            //Q[0, 0] = 0; Q[0, 1] = 1;
            //Q[1, 0] = 0; Q[1, 1] = 2;
            //Q[2, 0] = 3; Q[2, 1] = 4;
            //Q[3, 0] = 0; Q[3, 1] = 2;
            //Q[4, 0] = 4; Q[4, 1] = 4;

            //string sayi = "10100000011001100011000001";
            //int state = 0;
            //string finalstate = "01";
            //for (int i = 0; i < sayi.Length; i++)
            //{
            //    state = Q[state, (byte)sayi[i] - (byte)'0'];
            //}
            //if (state >= 2)
            //{
            //    Console.WriteLine("olmadi");
            //}
            //else
            //{
            //    Console.WriteLine("oldu");
            //    Console.WriteLine(state);
            //}

            //int[,] Q = new int[6, 2];
            //Q[0, 0] = 0; Q[0, 1] = 1;
            //Q[1, 0] = 0; Q[1, 1] = 2;
            //Q[2, 0] = 3; Q[2, 1] = 5;
            //Q[3, 0] = 0; Q[3, 1] = 4;
            //Q[4, 0] = 4; Q[4, 1] = 4;
            //Q[5, 0] = 0; Q[5, 1] = 4;

            //string sayi = "1010000001100110001100010";
            //int state = 0;
            //string finalstate = "01";
            //for (int i = 0; i < sayi.Length; i++)
            //{
            //    state = Q[state, (byte)sayi[i] - (byte)'0'];
            //}
            //if (state >= 2)
            //{
            //    Console.WriteLine("olmadi");
            //}
            //else
            //{
            //    Console.WriteLine("oldu");
            //    Console.WriteLine(state);
            //}


            //int[,] Q = new int[5, 2];
            //Q[0, 0] = 0; Q[0, 1] = 1;
            //Q[1, 0] = 2; Q[1, 1] = 3;
            //Q[2, 0] = 4; Q[2, 1] = 0;
            //Q[3, 0] = 1; Q[3, 1] = 2;
            //Q[4, 0] = 3; Q[4, 1] = 4;

            //string sayi = "111100101";
            //int state = 0;
            //for (int i = 0; i < sayi.Length; i++)
            //{
            //    state = Q[state, (byte)sayi[i] -(byte)'0'];
            //}
            //Console.WriteLine(state);
        }
    }
}