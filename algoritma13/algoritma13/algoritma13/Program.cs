using System;

namespace algoritma13
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
            Array.Sort(bt, (object x, object y)=>
            {
                int a = 0;
                if (x == null && y==null)
                {
                    return 0;
                }
                if (x == null) 
                {
                    return 1;
                }
                if (y== null)
                {
                    return -1;
                }
                if (((Btree)x).data<((Btree)y).data)
                {
                    a = -1;
                }
                if (((Btree)x).data >((Btree)y).data)
                {
                    a = 1;
                }
                return a;
            });
            tree(bt);

        }
        static void yazBtree(Btree bt , string yon)
        {
            if (bt==null)
            {
                return;
            }
            if (bt.left==null)
            {
                bt.hufman = yon;
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
            if (bt.left==null)
            {
                Console.WriteLine("{0}  {1}", (char)bt.ch, bt.hufman);
            }
            yazBtreeSonuc(bt.left);
            yazBtreeSonuc(bt.right);
        }
        static void Main(string[] args)
        {
            Btree[] bts = new Btree[10];
            for (int i = 0; i <10; i++)
            {
                bts[i] = new Btree();
                bts[i].data = i + 1;
                bts[i].ch = (byte)'A' + i;
            }
            tree(bts);
            yazBtree(bts[0], "");
            yazBtreeSonuc(bts[0]);
        }
    }
}
