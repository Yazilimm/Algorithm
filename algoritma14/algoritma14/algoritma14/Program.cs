using System;

namespace algoritma14
{
   
        class Program
        {
            class Btree
            {
                public int data;
                public int ch;
                public string hufman;
                public Btree left;
                public Btree right;
            }
            static Btree local(Btree a, Btree b)
            {
                Btree bt = new Btree();
                bt.data = a.data + b.data;
                bt.left = a;
                bt.right = b;
                return bt;
            }
            static void tree(Btree[] bt)
            {
                if (bt[1] == null)
                {
                    return;
                }
                bt[0] = local(bt[0], bt[1]);
                bt[1] = null;
                Array.Sort(bt, (object x, object y) =>
                {
                    int a = 0;
                    if (x == null && y == null)
                    {
                        return 0;
                    }
                    if (x == null)
                    {
                        return 1;
                    }
                    if (y == null)
                    {
                        return -1;
                    }
                    if (((Btree)x).data < ((Btree)y).data)
                    {
                        a = -1;
                    }
                    if (((Btree)x).data > ((Btree)y).data)
                    {
                        a = 1;
                    }
                    return a;
                });
                tree(bt);

            }
            static void yazBtree(Btree bt, string yon)
            {
                if (bt == null)
                {
                    return;
                }
                if (bt.left == null)
                {
                    bt.hufman = yon;
                    chars[bt.ch] = bt.ch;
                    hf[bt.ch] = yon;
                }
                yazBtree(bt.left, yon + "0");
                yazBtree(bt.right, yon + "1");
            }
            static void yazBtreeSonuc(Btree bt)
            {
                if (bt == null)
                {
                    return;
                }
                if (bt.left == null)
                {
                    Console.WriteLine("{0}  {1}", (char)bt.ch, bt.hufman);
                }
                yazBtreeSonuc(bt.left);
                yazBtreeSonuc(bt.right);
            }
            static int[] chars = new int[(byte)'H'+1];
            static string[] hf = new string[(byte)'H'+1];
            static void Main(string[] args)
            {
                string data = "AABBABBAAAAAABAAAAACDEFCCGHHHH";
                Btree[] bts = new Btree[10];
                int[] frekans = new int[(byte)'H'+1];
                for (int j = 0; j < data.Length; j++)
                {
                    frekans[data[j]]++;
                }
                int indis = 0;
                for (int i = 0; i < frekans.Length; i++)
                {
                    if (frekans[i]==0)
                    {
                        continue;
                    }
                    bts[indis] = new Btree();
                    bts[indis].data = frekans[i];
                    bts[indis].ch = i;
                    indis++;
                }
   
                tree(bts);
                yazBtree(bts[0], "");
                yazBtreeSonuc(bts[0]);
                string huffman = "";
                for (int i = 0; i < data.Length; i++)
                {
                    huffman = huffman + hf[data[i]];
                }
                Console.WriteLine(huffman);
                
                
            }
        }
}



