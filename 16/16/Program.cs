using System;

namespace _16
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
            for (int i = 0; i < n-1; i++)
            {
                while (a[i] != a[i+1])
                {
                    if (a[i] < a[i+1])
                        a[i + 1] -= a[i];
                    else
                        a[i] -= a[i + 1];
                }
            }
            Console.WriteLine("cmmdc= " + a[n-1]);
        }
    }
}
