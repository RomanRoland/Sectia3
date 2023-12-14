using System;

namespace _29
{
    internal class Program
    {
        static int[] Sort(int[] a, int PozL, int PozR)
        {
            if (PozL < PozR)
            {
                int Mid = PozL + (PozR - PozL) / 2;
                Sort(a, PozL, Mid);
                Sort(a, Mid + 1, PozR);
                MSort(a, PozL, Mid, PozR);
            }
            return a;
        }
        static void MSort(int[] a, int PozL, int Mid, int PozR)
        {
            int PLL = Mid - PozL + 1;
            int PRL = PozR - Mid;
            var al = new int[PLL];
            var ar = new int[PRL];
            int i, j;
            for (i = 0; i < PLL; ++i)
                al[i] = a[PozL + i];
            for (j = 0; j < PRL; ++j)
                ar[j] = a[Mid + 1 + j];
            i = 0;
            j = 0;
            int k = PozL;
            while (i < PLL && j < PRL)
            {
                if (al[i] <= ar[j])
                {
                    a[k++] = al[i++];
                }
                else
                {
                    a[k++] = ar[j++];
                }
            }
            while (i < PLL)
            {
                a[k++] = al[i++];
            }
            while (j < PRL)
            {
                a[k++] = ar[j++];
            }
        }
        static void Main()
        {
            int[] a = new int[1000];
            int n = 0;
            Console.WriteLine("Introduceti o secventa de numere");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                a[n] = int.Parse(token);
                n++;
            }
            Sort(a, 0, n-1);
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
