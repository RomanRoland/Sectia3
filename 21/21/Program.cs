using System;

namespace _21
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Introduceti prima secventa: ");
            string x = Console.ReadLine();
            Console.Write("Introduceti a doua secventa: ");
            string y = Console.ReadLine();
            int max = Math.Max(x.Length, y.Length);
            x.ToLower();
            y.ToLower();
            for (int i = 0; i < max; i++)
            {
                if (x[i] == y[i])
                    continue;
                else
                {
                    if (x[i] < y[i])
                    {
                        Console.WriteLine(x);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(y);
                        break;
                    }                        
                }
            }
        }
    }
}
