using System;

namespace AreaDoTriangulo
{
    class Triangulo
    {
        private double _ladoA, _ladoB, _ladoC;
        public Triangulo( double ladoA, double ladoB, double ladoC)
        {
            _ladoA = ladoA;
            _ladoB = ladoB;
            _ladoC = ladoC;
        }

        public double GetArea()
        {
            double p = (_ladoA + _ladoB + _ladoC) / 2;
            double area = Math.Sqrt(p * (p - _ladoA) * (p - _ladoB) * (p - _ladoC));
            return area;
        }
    }
}
