using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    internal class Program
    {
        static void Main()
        {
            int[] E = new int[9999];
            int[] W = new int[9999];
            int n = 0, m = 0;
            Console.WriteLine("Introduceti o secventa de numere");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                E[n] = int.Parse(token);
                n++;
            }
            Console.WriteLine("Introduceti o secventa de numere");
            string y = Console.ReadLine();
            string[] tokens2 = y.Split(' ');
            foreach (string token in tokens2)
            {
                W[m] = int.Parse(token);
                m++;
            }
            for (int i = 1; i < n; i++)
            {
                int nr = E[i];
                int nr2 = W[i];
                int p = i - 1;
                while (p >= 0 && E[p] > nr)
                {
                    E[p + 1] = E[p];
                    W[p + 1] = W[p];
                    p--;
                }
                E[p + 1] = nr;
                W[p + 1] = nr2;
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (E[i] == E[i + 1] && W[i] < W[i + 1])
                {
                    int temp = E[i];
                    E[i] = E[i + 1];
                    E[i + 1] = temp;
                    int temp2 = W[i];
                    W[i] = W[i + 1];
                    W[i + 1] = temp2;
                }
            }
            for (int i = 0; i <= n - 1; i++)
            {
                Console.Write(E[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i <= n - 1; i++)
            {
                Console.Write(W[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
