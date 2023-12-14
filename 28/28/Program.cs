using System;

namespace _28
{
    internal class Program
    {
        static int[] SortQ(int[] a, int PozL, int PozR)
        {
            int i = PozL;
            int j = PozR;
            int p = a[PozL];
            while (i <= j)
            {
                while (a[i] < p)
                {
                    i++;
                }
                while (a[j] > p)
                {
                    j--;
                }
                if (i <= j)
                {
                    int k = a[i];
                    a[i] = a[j];
                    a[j] = k;
                    i++;
                    j--;
                }
            }
            if (PozL < j)
                SortQ(a, PozL, j);
            if (i < PozR)
                SortQ(a, i, PozR);
            return a;
        }
        static void Main()
        {
            int[] a = new int[1000];
            int n = 0, PozL = 0;
            Console.WriteLine("Introduceti o secventa de numere");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                a[n] = int.Parse(token);
                n++;
            }
            int PozR = n - 1;
            SortQ(a,PozL, PozR);
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
    }
}
