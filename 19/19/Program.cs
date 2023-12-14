using System;

namespace _19
{
    internal class Program
    {
        static void Main()
        {
            int[] s = new int[1000], p = new int[1000];
            int a = 0, b = 0, k = 0, l = 0;
            Console.WriteLine("Introduceti secventa s de numere(separarea se va face prin virgula)");
            string x = Console.ReadLine();
            Console.WriteLine("Introduceti secventa p de numere");
            string y = Console.ReadLine();
            string[] tokens2 = y.Split(',');
            foreach (string token in tokens2)
            {
                p[b] = int.Parse(token);
                b++;
            }
            string[] tokens = x.Split(',');
            foreach (string token in tokens)
            {
                s[a] = int.Parse(token);
                a++;
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (s[i + j] != s[j]) break;
                    else k++;
                }
                if (k == b) l++;
                k = 0;
            }
            Console.WriteLine(l);
        }
    }
}
