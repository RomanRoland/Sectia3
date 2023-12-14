using System;

namespace _15
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
                for (int i = 0; i < n; i++) 
                { 
                    if (a[i] == a[n]) 
                    { 
                        n--;
                        break; 
                    } 
                }
                n++;
            }
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
        }
    }
}
