using System;
using System.Globalization;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e a altura do retângulo:");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Área = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
