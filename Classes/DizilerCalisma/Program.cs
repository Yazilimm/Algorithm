using System;

namespace DizilerCalisma
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.In.ReadLine());
            int[] grades = new int[size];
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = Convert.ToInt32(Console.In.ReadLine());
            }
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }
        }
    }
}
