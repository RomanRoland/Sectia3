using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Main()
        {
            int[] a = new int[1000];
            int[] b = new int[1000];
            int n = 0, k2 = 0;
            Console.WriteLine("Introduceti o secventa de numere");
            string x = Console.ReadLine();
            Console.Write("introduceti un numar k: ");
            int k = int.Parse(Console.ReadLine());
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                a[n] = int.Parse(token);
                n++;
            }
            for (int i = 0; i < k; i++)
            { 
                b[k2] = a[i]; 
                k2++; 
            }
            k2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (i + k > n-1)
                {
                    a[i] = b[k2];
                    k2++;
                }
                else
                    a[i] = a[i + k];
            }
            for (int i = 0; i < n; i++) Console.Write(a[i] + " ");
        }
    }
}
