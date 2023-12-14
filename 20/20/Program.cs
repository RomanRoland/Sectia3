using System;

namespace _20
{
    internal class Program
    {
        static void Main()
        {
            int[] s1 = new int[1000];
            int[] s2 = new int[1000];
            bool t = false;
            int n = 0, m = 0;
            Console.WriteLine("Introducerea sireagurilor se va introduce prin numarul 1 pentru margele albe si numarul 0 pentru margelele negre");
            Console.Write("Introduceti prima sireaga de margele: ");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                s1[n] = int.Parse(token);
                n++;
            }
            Console.Write("Introduceti a doua sireaga de margele: ");
            x = Console.ReadLine();
            string[] tokens2 = x.Split(' ');
            foreach (string token in tokens2)
            {
                s2[m] = int.Parse(token);
                m++;
            }
            if (m == n)
            {
                for (int i = 0; i < n; i++)
                {
                    if (t)
                        break;
                    t = true;
                    for (int j = 0; j < m; j++)
                    {
                         if (s1[j] != s2[j])
                         {
                             t = false;
                             Rotate(ref s2, m);
                             break;
                         }
                    }
                }
            }
            if (t)
                Console.WriteLine("sireagurile se pot suprapune");
            else
                Console.WriteLine("Acestestea nu se pot suprapune");
        }

        private static void Rotate(ref int[] s2, int m)
        {
            int p = s2[0];
            for (int i = 0; i < m - 1; i++)
                s2[i] = s2[i+ 1];
            s2[m-1] = p;
        }
    }
}
