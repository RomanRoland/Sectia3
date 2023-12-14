using System;

namespace _18
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Introduceti gradul polinomului: ");
            int n = int.Parse(Console.ReadLine());
            double[] c = new double[n + 1];
            Console.WriteLine("Introduceti coeficientii polinomului (Aceasta se va face de la cea mai mica la cea mai mare grad):");
            for (int i = 0; i <= n; i++)
            {
                Console.Write($"Coeficient pentru x^{i}: ");
                c[i] = double.Parse(Console.ReadLine());
            }
            Console.Write("Introduceti punctul x in care se va verifica polinomul: ");
            double pX = double.Parse(Console.ReadLine());
            double rezultat = 0;
            for (int i = 0; i < c.Length; i++)
            {
                rezultat += c[i] * Math.Pow(pX, i);
            }
            Console.WriteLine($"Valoarea polinomului in punctul {pX} este: {rezultat}");
        }
    }
}
