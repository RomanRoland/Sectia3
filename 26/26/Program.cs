using System;
using System.Diagnostics.Eventing.Reader;

namespace _26
{
    internal class Program
    {
        static sbyte CharToNumber(char a)
        {
            sbyte L = 0;
            switch (a)
            {
                case (char)48: L = 0; break;
                case (char)49: L = 1; break;
                case (char)50: L = 2; break;
                case (char)51: L = 3; break;
                case (char)52: L = 4; break;
                case (char)53: L = 5; break;
                case (char)54: L = 6; break;
                case (char)55: L = 7; break;
                case (char)56: L = 8; break;
                case (char)57: L = 9; break;
            }
            return L;
        }
        static void Main()
        {
            int[] a = new int[9999];
            int[] b = new int[9999];
            int[] s = new int[9999];
            int[] d = new int[9999];
            int[,] p = new int[9999, 9999];
            int[] pr = new int[9999];
            int n = 1, m = 1, max,min = 0, j = 0, k = 0, g = 1;
            bool t = true, y = false;
            Console.Write("Introduceti primul numar: ");
            string x = Console.ReadLine();
            foreach (char c in x)
            {
                a[n] = CharToNumber(c);
                n++;
            }
            Console.Write("Introduceti al doilea numar: ");
            x = Console.ReadLine();
            foreach (char c in x)
            {
                b[m] = CharToNumber(c);
                m++;
            }
            if (a[1] == 0 || b[1] == 0)
                y = true;
            if (m > n)
            {
                max = m;
                for (int i = n;i > 0;i--)
                {
                    a[max - j] = a[i];
                    a[i] = 0;
                    j++;
                }
            }
            else
            {
                max = n;
                if (n > m)
                {
                    for (int i = m; i > 0; i--)
                    {
                        b[max - j] = b[i];
                        b[i] = 0;
                        j++;
                    }
                } 
            }
            //Suma numere
            int maxi = max;
            while (maxi >= 0)
            {
                s[maxi] = a[maxi] + b[maxi];
                maxi--;
            }
            while (t)
            {
                t = false;
                for (int i = 1; i <= max; i++)
                {
                    if (s[i] > 9)
                    {
                        s[i] %= 10;
                        s[i-1]++;
                        t = true;
                    }
                }
            }
            Console.Write("Suma numerelor este: ");
            for (int i = 0; i < max; i++)
            {
                if (s[i] == 0 && i == 0)
                    continue;
                Console.Write(s[i]);
            }
            Console.WriteLine();
            //Diferenta numere
            maxi = max;
            t = true;
            while (maxi >= 0)
            {
                d[maxi] = a[maxi] - b[maxi];
                maxi--;
            }
            while (t)
            {
                t = false;
                for (int i = 1; i <= max; i++)
                {
                    if (d[i] < 0 && d[i-1] > 0 && i > 1)
                    {
                        d[i] += 10;
                        d[i - 1]--;
                        t = true;
                    }
                }
            }
            for (int i = 2; i <= max; i++)
            {
                if (d[i] < 0)
                    d[i] *= -1;
            }
            t = true;
            Console.Write("Diferenta numerelor este: ");
            for (int i = 0; i < max; i++)
            {
                if (d[i] == 0 && t)
                {
                    if (d[i + 1] != 0) 
                        t = false;
                    continue;
                }
                Console.Write(d[i]);
            }
            if (t) Console.Write("0");
            Console.WriteLine();
            //Produsul numerelor
            if (y)
            {
                Console.WriteLine("Produsul numerelor este: 0");
                Console.WriteLine();
            }
            else
            {
                t = true;
                for (int i = max - 1; i > 0; i--)
                {
                    for (j = max - 1; j >= 0; j--)
                    {
                        p[i, j] = a[j] * b[i];
                    }
                }
                while (t)
                {
                    t = false;
                    for (int i = max - 1; i >= 1; i--)
                    {
                        for (j = max; j >= 1; j--)
                        {
                            if (p[i, j] > 9)
                            {
                                p[i, j - 1] += p[i, j] / 10;
                                p[i, j] %= 10;
                                t = true;
                            }
                        }
                    }
                }
                g = max + 1;
                for (int i = max; i >= 0; i--)
                {
                    for (j = max; j >= 0; j--)
                    {
                        p[i, max + g - k] = p[i, j];
                        p[i, j] = 0;
                        k++;
                    }
                    k = 0;
                    g--;
                }
                for (int i = max - 1; i > 0; i--)
                {
                    for (j = 0; j <= 2*max; j++)
                    {
                        if (p[i, j] != 0)
                        {
                            min = j;
                            break;
                        }
                    }
                }
                for (int i = max - 1; i > 0; i--)
                {
                    for (j = min; j < 2 * max; j++)
                    {
                        pr[j] += p[i, j];
                    }
                }
                t = true;
                while (t)
                {
                    t = false;
                    for (int i = min; i < 2 * max; i++)
                    {
                        if (pr[i] > 9)
                        {
                            pr[i] %= 10;
                            pr[i - 1]++;
                            t = true;
                        }
                    }
                }
                Console.Write("Produsul numerelor este: ");
                for (int i = min - 1; i < 2 * max; i++)
                {
                    if (pr[i] == 0 && i == min - 1)
                        continue;
                    Console.Write(pr[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
