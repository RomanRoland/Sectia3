using System;

namespace _11
{
    internal class Program
    {
        static void Main()
        {
            int[] a = new int[1000];
            Console.Write("Introduceti un numar: ");
            int n = int.Parse(Console.ReadLine());
            a[0] = 1;
            a[1] = 1;
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
                if (a[i] == 0)
                    for (int j = i; j <= n / i; j++)
                        a[i * j] = 1;
            for (int i = 2; i <= n; i++)
                if (a[i] == 0)
                    Console.Write(i + " ");
        }
    }
}
