using System;

namespace _14
{
    internal class Program
    {
        static void Main()
        {
            int[] a = new int[1000];
            int n = 0, k = 0;
            Console.WriteLine("Introduceti o secventa de numere");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                a[n] = int.Parse(token);
                if (a[n] == 0) { k++; continue; }
                n++;
            }
            //n += k;
            for (int i = 0; i < n + k; i++)
                Console.Write(a[i] + " ");
        }
    }
}
