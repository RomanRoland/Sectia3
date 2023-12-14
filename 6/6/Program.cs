using System;

namespace _6
{
    internal class Program
    {
        static void Main()
        {
            int[] a = new int[1000];
            int n = 0;
            Console.WriteLine("Introduceti o secventa de numere");
            string x = Console.ReadLine();
            Console.Write("Introduceti pozitia care vreti sa o eliminati: ");
            sbyte k = sbyte.Parse(Console.ReadLine());
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                a[n] = int.Parse(token);
                n++;
            }
            for (int i = k; i < n - 1; i++) { a[i] = a[i + 1];};
            n--;
            for (int i = 0; i < n; i++) Console.Write(a[i] + " ");
        }
    }
}
