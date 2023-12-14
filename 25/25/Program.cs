using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    internal class Program
    {
        static void Main()
        {
            int[] a = new int[1000];
            int[] b = new int[1000];
            int[] c = new int[1000];
            int n = 0, k = 0, l = 0, p = 0;
            Console.WriteLine("Introduceti pirma secventa de numere");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                a[n] = int.Parse(token);
                n++;
            }
            Console.WriteLine("Introduceti a doua secventa de numere");
            x = Console.ReadLine();
            tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                b[k] = int.Parse(token);
                k++;
            }
            for (int i = 0; i < n + k; i++)
            {
                if (l != n && p != k)
                {
                    if (a[l] <= b[p])
                    {
                        c[i] = a[l];
                            l++;
                    }  
                    else
                    {
                        c[i] = b[p];
                            p++;
                    }   
                }
                else
                {
                    if (l == n) 
                    {
                        c[i] = b[p]; 
                        p++; 
                    }
                    else
                    {
                        c[i] = a[l];
                        l++;
                    }
                }
                Console.Write($"{c[i]} ");
            }
        }
    }
}
