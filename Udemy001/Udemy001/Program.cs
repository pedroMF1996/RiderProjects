using System;
using System.Globalization;
using Udemy001.ClaseTriangulos;

namespace Udemy001
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Entre com os lados do triângulo 1: ");
      Triangulo triangulo1 = new Triangulo(
        double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture),
        double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture),
        double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture)
        );
      
      Console.WriteLine("Entre com os lados do triângulo 2: ");
      Triangulo triangulo2 = new Triangulo(
        double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture),
        double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture),
        double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture)
      );

      Console.WriteLine($"Area do triangulo 1: {triangulo1.Area().ToString("F2",CultureInfo.InvariantCulture)} \nArea do triangulo 2: {triangulo2.Area().ToString("F2",CultureInfo.InvariantCulture)}  ");
      
      string maiorArea = (triangulo1.Area()>triangulo2.Area())?
        $"O triângulo 1 tem a maior area e é {triangulo1.Area().ToString("F2",CultureInfo.InvariantCulture)}" :
        $"O triangulo 2 tem a maior area e é {triangulo2.Area().ToString("F2",CultureInfo.InvariantCulture)}";
      
      Console.WriteLine(maiorArea);
    }
  }
}