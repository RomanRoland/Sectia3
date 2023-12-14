using System;

namespace _27
{
    internal class Program
    {
        static void Main()
        {
            int[] a = new int[1000];
            int n = 0, p = 0, poz = 0;
            Console.WriteLine("Introduceti o secventa de numere");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            Console.WriteLine("Introduceti pozitia indexului (numaratoarea se va incepe de la 0)");
            p = int.Parse(Console.ReadLine());
            foreach (string token in tokens)
            {
                a[n] = int.Parse(token);
                n++;
            }
            poz = a[p];
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                    if (a[i] > a[j])
                    {
                        a[i] += a[j];
                        a[j] = a[i] - a[j];
                        a[i] = a[i] - a[j];
                    }
            }
            Console.WriteLine($"Indexul {poz} este {a[poz]}");
        }
    }
}
