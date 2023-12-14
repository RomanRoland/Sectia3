using System;

namespace _4
{
    internal class Program
    {
        static void Main()
        {
            int[] a = new int[1000];
            int n = 0, i = 0, i2 = 0,min = 2147483647, max = -2147483647;
            Console.WriteLine("Introduceti o secventa de numere");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                a[n] = int.Parse(token);
                if (a[n] < min) {min = a[n]; i = 0; }
                if (a[n] > max) {max = a[n]; i2 = 0; }
                if (a[n] ==  min) { i++; }
                if (a[n] == max) { i2++; }
                n++;
            }
            Console.WriteLine($"Cel mai mic numar din secventa este {min} si acesta apare de {i} ori respectiv cel mai mare numar este {max} si apare de {i2} ori");
        }
    }
}
