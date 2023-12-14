using System;

namespace _31
{
    internal class Program
    {
        static void Main()
        {
            int[] a = new int[1000];
            int[] b = new int[99999999];
            int n = 0, max = int.MinValue;
            bool t = true;
            Console.WriteLine("Introduceti o secventa de numere");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                a[n] = int.Parse(token);
                if (a[n] > max)
                    max = a[n];
                b[a[n]]++;
                n++;
            }
            for (int i = 0; i <= max; i++)
            {
                if (b[i] > n / 2)
                {
                    int maj = i;
                    t = false;
                    Console.WriteLine("majoritatea este " + maj);
                    break;
                }
            }
            if (t) 
                Console.WriteLine("<nu exista>");
        }
    }
}
