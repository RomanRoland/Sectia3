using System;

namespace _1
{
    internal class Program
    {
        static void Main()
        {
            int[] a = new int[1000];
            int n = 0, s = 0;
            Console.WriteLine("Introduceti o secventa de numere");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                a[n] = int.Parse(token);
                s += a[n];
                n++;
            }
            Console.WriteLine($"Suma elementelor din vector este {s}");
        }
    }
}
