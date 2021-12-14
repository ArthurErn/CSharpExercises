using System;
using System.Globalization;

namespace VectorExercise {
    class Program {
        static void Main() {

            int n = int.Parse(Console.ReadLine());

            double[] vector = new double[n];
            double total = 0;
            for (int i = 0; i < n; i++) {
                vector[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                total += vector[i];   
            }
            double media = calcularMedia(n, total);
            Console.WriteLine(media.ToString("F2"));
        }

        static public double calcularMedia(int quantidade, double total) {
            return total / quantidade;
        }
    }
}
