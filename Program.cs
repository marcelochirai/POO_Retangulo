using Retangulo;
using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Rectangle x;

            x = new Rectangle();
            
            Console.WriteLine("Informe as medidas da altura e largura do retângulo: ");
            x.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
