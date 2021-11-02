using System;
using System.Globalization;

namespace URI1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste, novoSalario, taxa;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.0)
            {
                taxa = 15.0;
            }
            else if (salario <= 800.0)
            {
                taxa = 12.0;
            }
            else if (salario <= 1200.0)
            {
                taxa = 10.0;
            }
            else if (salario <= 2000.0)
            {
                taxa = 7.0;
            }
            else
            {
                taxa = 4.0;
            }

            reajuste = salario * taxa / 100;
            novoSalario = salario + reajuste;

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste Ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Novo salario: " + taxa.ToString("F0", CultureInfo.InvariantCulture) + " %");
        }
    }
}
