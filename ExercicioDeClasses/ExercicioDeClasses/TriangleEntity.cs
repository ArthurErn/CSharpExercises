using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeClasses {
    class TriangleEntity {
        public double ladoA;
        public double ladoB;
        public double ladoC;

        public double calculateArea() {
            double p = (ladoA + ladoB + ladoC) / 2.0;
            double raiz = Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));
            return raiz;
        }
    }
}
