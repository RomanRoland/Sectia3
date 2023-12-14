using System;

namespace _2
{
    internal class Program
    {
        static void Main()
        {
            int[] a = new int[1000];
            int n = 0;
            bool t = true;
            Console.WriteLine("Introduceti o secventa de numere");
            string x = Console.ReadLine();
            Console.Write("Introduceti o valoare: ");
            int k = int.Parse(Console.ReadLine());
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                a[n] = int.Parse(token);
                if (a[n] == k) { Console.WriteLine($"Elementul apare pentru prima data in pozitia {n}"); t = false; break; }
                n++;
            }
            if (t) Console.WriteLine(-1);
        }
    }
}
