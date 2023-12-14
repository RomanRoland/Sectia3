using System;

namespace _12
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
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                    if (a[i] > a[j])
                    {
                        a[i] += a[j];
                        a[j] = a[i] - a[j];
                        a[i] = a[i] - a[j];
                    }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
