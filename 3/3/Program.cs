using System;

class Program
{

    static void Main()
    {
        int[] a = new int[1000];
        int n = 0;
        Console.WriteLine("Introduceti o secventa de numere");
        string x = Console.ReadLine();
        string[] tokens = x.Split(' ');
        foreach (string token in tokens)
        {
            a[n] = int.Parse(token);
            n++;
        }
        int minPos = 0, maxPos = 0, min, max;
        if (a[0] < a[1])
        {
            min = a[0];
            max = a[1];
            maxPos = 1;
        }
        else
        {
            min = a[1];
            max = a[0];
            minPos = 1;
        }
        for (int i = 2; i < n - 1; i += 2)
        {
            int Min2, Max2, MinPos2, MaxPos2;
            if (a[i] < a[i + 1])
            {
                Min2 = a[i];
                Max2 = a[i + 1];
                MinPos2 = i;
                MaxPos2 = i + 1;
            }
            else
            {
                Min2 = a[i + 1];
                Max2 = a[i];
                MinPos2 = i + 1;
                MaxPos2 = i;
            }
            if (Min2 < min)
            {
                min = Min2;
                minPos = MinPos2;
            }
            if (Max2 > max)
            {
                max = Max2;
                maxPos = MaxPos2;
            }
        }
        if (n % 2 == 1)
        {
            if (a[n - 1] < min)
            {
                min = a[n - 1];
                minPos = n - 1;
            }
            else if (a[n - 1] > max)
            {
                max = a[n - 1];
                maxPos = n - 1;
            }
        }
        Console.WriteLine($"Cel mai mic element este {a[minPos]} si cel mai mare este {a[maxPos]}");
    }
}
