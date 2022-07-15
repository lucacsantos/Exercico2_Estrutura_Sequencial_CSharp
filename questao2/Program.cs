using System;
using System.Globalization;
namespace questao2
{
    class Program
    {/*
      Fórmula da área: area = π . raio2
      Considere o valor de π = 3.14159
      */
        static void Main(string[] args)
        {
            double raio;
            double pi = 3.14159;
            
            Console.WriteLine("digite o raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area;

            area = (raio * raio) * pi;

            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
