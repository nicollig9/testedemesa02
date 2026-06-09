using System;

class Tabela2
{
    static void Main()
    {
        int a = 7;
        int b = a - 6; // b = 1

        int[] v = new int[8];

        while (b < a)
        {
            v[b] = b + a;
            b = b + 2;
        }

        Console.WriteLine("qual o vetor:");

        for (int i = 0; i < v.Length; i++)
        {
            Console.WriteLine($"v[{i}] = {v[i]}");
        }

        Console.ReadKey();
    }
} 