using System;
using System.Globalization;

namespace URI1002
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {

                double n = 3.14159;
                double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double a = Math.Pow(raio, 2.0);
                double area = a * n;
                Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
            }
        }
    }
}
