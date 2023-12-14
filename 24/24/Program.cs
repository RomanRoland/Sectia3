using System;

namespace _24
{
    internal class Program
    {
        static void Main()
        {
            int[] v1 = new int[1000];
            int[] v2 = new int[1000];
            int[] U = new int[1000];
            int[] A = new int[1000];
            int[] D1 = new int[1000];
            int[] D2 = new int[1000];
            int n = 0, m = 0, max = 0;
            Console.Write("Introduceti prima secventa de numere: ");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                v1[n] = int.Parse(token);
                D1[n] = v1[n];
                n++;
            }
            Console.Write("Introduceti a doua secventa de numere: ");
            x = Console.ReadLine();
            string[] tokens2 = x.Split(' ');
            foreach (string token in tokens2)
            {
                v2[m] = int.Parse(token);
                D2[m] = v2[m];
                m++;
            }
            if (m > n)
                max = m;
            else
                max = n;
            for (int i = 0; i < max; i++)
            {
                if (v1[i] == 1 || v2[i] == 1)
                {
                    U[i] = 1;
                    if (v1[i] == 1 && v2[i] == 1)
                    {
                        A[i] = 1;
                        D1[i] = 0;
                        D2[i] = 0;
                    }
                }
            }
            Console.Write("Reuniunea multimilor este: ");
            for (int i = 0;i < max;i++)
                Console.Write(U[i] + " ");
            Console.WriteLine();
            Console.Write("Intersectia multimilor este: ");
            for (int i = 0; i < max; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine();
            Console.Write("Diferenta dintre V1 si V2 multimilor este: ");
            for (int i = 0; i < max; i++)
                Console.Write(D1[i] + " ");
            Console.WriteLine();
            Console.Write("Diferenta dintre V2 si V1 multimilor este: ");
            for (int i = 0; i < max; i++)
                Console.Write(D2[i] + " ");
            Console.WriteLine();
        }
    }
}
