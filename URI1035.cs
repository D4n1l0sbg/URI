﻿using System;

namespace URI1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, x, z;

            String[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);
            d = int.Parse(vet[3]);

            x = c + d;
            z = a + b;

            if (b > c && d > a && d > a && x > z && c >= 0 && d >= 0 && a % 2 == 0)
            {
                Console.WriteLine("Valores Aceitos");

            } else
            {
                Console.WriteLine("Valores não Aceitos");
            }
           
        }
    }
}
