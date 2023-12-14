using System;

namespace _22
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
            int[] D1Del = new int[1000];
            int[] D2 = new int[1000];
            int[] D2Del = new int[1000];
            int n = 0, m = 0, k = 0;
            Console.Write("Introduceti prima secventa de numere: ");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                v1[n] = int.Parse(token);
                D1[n] = v1[n];
                U[n] = v1[n];
                for (int i = 0; i < n; i++)
                    if (v1[i] == v1[n])
                    {
                        n--;
                        break;
                    }
                n++;
            }
            if (v1[n - 1] != 0 && v1[n - 1] == v1[n])
            {
                D1[n] = 0;
                v1[n] = 0;
            }
            Console.Write("Introduceti a doua secventa de numere: ");
            x = Console.ReadLine();
            string[] tokens2 = x.Split(' ');
            foreach (string token in tokens2)
            {
                v2[m] = int.Parse(token);
                D2[m] = v2[m];
                U[n + m] = v2[m];
                for (int i = 0; i < m; i++)
                    if (v2[i] == v2[m])
                    {
                        m--;
                        break;
                    }
                m++;
            }
            if (v2[m - 1] != 0 && v2[m - 1] == v2[m])
            {
                D2[m] = 0;
                v2[m] = 0;
            }
            int kd1 = n, kd2 = m, k1 = m + n;
            Array.Sort(U, 0, k1);
            for (int i = 0; i < k1 - 1; i++)
            {
                if (U[i] == U[i + 1])
                {
                    ArrayDel(ref U, ref k1, i);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (v1[i] == v2[j])
                    {
                        A[k] = v1[i];
                        D1Del[k] = i;
                        D2Del[k] = j;
                        k++;
                        break;
                    }
                }
            }
            Array.Sort(D2Del, 0, k);
            for (int i = 0; i < k; i++)
            {
                ArrayDel(ref D1, ref kd1, D1Del[i]);
                for (int j = i; j < k; j++)
                    D1Del[j]--;
            }
            for (int i = 0; i < k; i++)
            {
                ArrayDel(ref D2, ref kd2, D2Del[i]);
                for (int j = i; j < k; j++)
                    D2Del[j]--;
            }
            Console.Write("Reuniunea multimilor este:{ ");
            for (int i = 0; i < k1; i++)
                Console.Write(U[i] + " ");
            Console.Write("}");
            Console.WriteLine();
            Console.Write("Intersectia multimilor este:{ ");
            for (int i = 0; i < k; i++)
                Console.Write(A[i] + " ");
            Console.Write("}");
            Console.WriteLine();
            Console.Write("Diferenta dintre V1 si V2 multimilor este:{ ");
            for (int i = 0; i < kd1; i++)
                Console.Write(D1[i] + " ");
            Console.Write("}");
            Console.WriteLine();
            Console.Write("Diferenta dintre V2 si V1 multimilor este:{ ");
            for (int i = 0; i < kd2; i++)
                Console.Write(D2[i] + " ");
            Console.Write("}");
            Console.WriteLine();
        }

        static void ArrayDel(ref int[] a, ref int k1, int p)
        {
            for (int i = p; i < k1 - 1; i++)
                a[i] = a[i + 1];
            k1--;
        }
    }
}