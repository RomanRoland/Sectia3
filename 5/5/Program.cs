using System;

namespace _5
{
    internal class Program
    {
        static void Main()
        {
            int[] a = new int[1000];
            int n = 0;
            Console.WriteLine("Introduceti o secventa de numere");
            string x = Console.ReadLine();
            Console.Write("Introduceti o valoare: ");
            int e = int.Parse(Console.ReadLine());
            Console.Write("Introduceti pozitia in care vreti ca numarul sa se schimbe: ");
            sbyte k = sbyte.Parse(Console.ReadLine());
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                a[n] = int.Parse(token);
                n++;
            }
            a[k] = e;
            for (int i = 0; i < n; i++) Console.Write(a[i] + " ");
        }
    }
}
