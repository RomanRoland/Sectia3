using System;

namespace _13
{
    internal class Program
    {
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
            for (int i = 1; i < n; i++)
            {
                int nr = a[i];
                int p = i - 1;
                while (p >= 0 && a[p] > nr)
                {
                    a[p + 1] = a[p]; p--;
                }
                a[p+1] = nr;
            }
            for (int i =0; i < n; i++)
                Console.Write(a[i] + " ");
        }
    }
}
