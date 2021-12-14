using System;
using System.Globalization;

namespace ExercicioDeClasses
{
    class Program {
        static void Main() {
            TriangleEntity x, y;
            x = new TriangleEntity();
            y = new TriangleEntity();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.calculateArea();
            Console.WriteLine("Área de X: {0}", areaX);
            double areaY = y.calculateArea();
            Console.WriteLine("Área de Y: {0}", areaY);

            if (areaY > areaX) {
                Console.WriteLine("Maior Área: Y");
            } else if (areaX > areaY) {
                Console.WriteLine("Maior Área: X");
            } else {
                Console.WriteLine("Áreas iguais!");
            }
        }
    }
}
