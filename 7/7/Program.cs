using System;

namespace _7
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
            n--;
            for (int i = 0; i <= n / 2; i++)
            {
                a[i] += a[n-i];
                a[n-i] = a[i] - a[n-i];
                a[i] = a[i] - a[n-i];
            }
            for (int i = 0; i <= n; i++) Console.Write($"{a[i]} ");
        }
    }
}
