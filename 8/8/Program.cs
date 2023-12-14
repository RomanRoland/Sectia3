using System;

namespace _8
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
            int k = a[0];
            for (int i = 0; i < n; i++)
            {
                a[i] = a[i+1];
            }
            a[n-1] = k;
            for (int i = 0;i < n; i++) Console.Write(a[i] + " ");
        }
    }
}
