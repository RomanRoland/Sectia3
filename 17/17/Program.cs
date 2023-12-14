using System;

namespace _17
{
    internal class Program
    {
        static string Above9(long a)
        {
            string L = "A";
            switch (a)
            {
                case 0: L = "0"; break;
                case 1: L = "1"; break;
                case 2: L = "2"; break;
                case 3: L = "3"; break;
                case 4: L = "4"; break;
                case 5: L = "5"; break;
                case 6: L = "6"; break;
                case 7: L = "7"; break;
                case 8: L = "8"; break;
                case 9: L = "9"; break;
                case 10: L = "A"; break;
                case 11: L = "B"; break;
                case 12: L = "C"; break;
                case 13: L = "D"; break;
                case 14: L = "E"; break;
                case 15: L = "F"; break;
            }
            return L;
        }
        static void Main()
        {
            Console.WriteLine("Introduceti numarul in baza 10");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti o baza de la 2 la 16");
            sbyte b = sbyte.Parse(Console.ReadLine());
            if (10 > b)
            {
                double n2 = n1;
                long n = (long)n1;
                if (n1 == n)
                {
                    long nr = 0, p = 1;
                    while (n != 0)
                    {
                        nr = (n % b) * p + nr;
                        p *= 10;
                        n /= b;
                    }
                    Console.WriteLine($"Numarul {n2} in baza {b} este: {nr}");
                }
                else
                {
                    int p = 1;
                    float n3 = (float)((float)n1 - (int)n1);
                    long n4 = n;
                    while (n4 != 0)
                    {
                        p++;
                        n4 /= b;
                    }
                    int p1 = p;
                    string[] i = new string[100];
                    while (n != 0)
                    {
                        i[p - 1] = $"{n % b}";
                        p--;
                        n /= b;
                    }
                    p = 1;
                    string[] ii = new string[100];
                    while ((n3 != 0 && p < 30) && n3 != 0)
                    {
                        ii[p] = $"{(long)(n3 * b)}";
                        p++;
                        n3 = (n3 * b) - (int)(n3 * b);
                    }
                    int p2 = p;
                    Console.Write($"Numarul {n2} in baza {b} este: ");
                    for (p = 0; p < p1; p++)
                        Console.Write(i[p]);
                    Console.Write(".");
                    for (p = 0; p < p2; p++)
                        Console.Write(ii[p]);
                    Console.WriteLine();
                }
            }
            if (10 < b)
            {
                double n2 = n1;
                long n = (long)n1;
                if (n1 == n)
                {
                    int p = 1;
                    long bi10 = n;
                    while (bi10 != 0)
                    {
                        p++;
                        bi10 /= b;
                    }
                    int p1 = p;
                    string[] i = new string[100];
                    while (n != 0)
                    {
                        i[p - 1] = $"{Above9(n % b)}";
                        p--;
                        n /= b;
                    }
                    Console.Write($"Numarul {n} in baza {b} este: ");
                    for (p = 0; p < p1; p++)
                        Console.Write(i[p]);
                    Console.WriteLine();
                }
                else
                {
                    int p = 1;
                    float n3 = (float)((float)n1 - (int)n1);
                    long n4 = n;
                    while (n4 != 0)
                    {
                        p++;
                        n4 /= b;
                    }
                    int p1 = p;
                    string[] i = new string[100];
                    while (n != 0)
                    {
                        i[p - 1] = $"{Above9(n % b)}";
                        p--;
                        n /= b;
                    }
                    p = 1;
                    string[] ii = new string[100];
                    while ((n3 != 0 && p < 20) && n3 != 0)
                    {
                        ii[p] = $"{Above9((long)(n3 * b))}";
                        p++;
                        n3 = (n3 * b) - (int)(n3 * b);
                    }
                    int p2 = p;
                    Console.Write($"Numarul {n2} in baza {b} este: ");
                    for (p = 0; p < p1; p++)
                        Console.Write(i[p]);
                    Console.Write(".");
                    for (p = 0; p < p2; p++)
                        Console.Write(ii[p]);
                    Console.WriteLine();
                }
            }
        }
    }
}
