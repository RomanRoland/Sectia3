using System;
using System.Threading;

namespace _10
{
    internal class Program
    {
        static void Main()
        {
            int[] a = new int[1000];
            int n = 0, poz = -1;
            Console.WriteLine("Introduceti o secventa de numere");
            string x = Console.ReadLine();
            Console.Write("Introduceti o valoare: ");
            int k = int.Parse(Console.ReadLine());
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                a[n] = int.Parse(token);
                n++;
            }
            int max = n-1, min = 0;
            while (true)
            {
                if (a[(max + min) / 2] < k)
                    min = (max + min) / 2;
                else if (a[(max + min) / 2] > k)
                    max = (max + min) / 2 - 1;
                else if (a[(max + min) / 2] == k)
                {
                    poz = (max + min) / 2;
                    break;
                }
                if (min + 1 == max)
                {
                    if (a[min] != k && a[max] != k)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(poz);
        }
    }
}
