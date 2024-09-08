using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationArea
{
    public sealed class Triangle: IShape
    {
        public double ASide { get; }
        public double BSide { get; }
        public double CSide { get; }

        private const double littleDig = 1e-11;

        public Triangle(double aside, double bside, double cside)
        {
            if (aside <= 0 || bside <= 0 || cside <= 0)
            {
                throw new ArgumentException("Стороны треугольника должны быть больше 0");
            }

            if (aside + bside <= cside || aside + cside <= bside || cside + bside <= aside)
            {
                throw new ArgumentException("Такого треугольника не может существовать");
            }

            ASide = aside;
            BSide = bside;
            CSide = cside;
        }

        public double CalculateArea()
        {
            double semiPer = (ASide + BSide + CSide) / 2;
            return Math.Sqrt(semiPer * (semiPer - ASide) * (semiPer - BSide) * (semiPer - CSide));
        }

        public bool IsRightTriangle()
        {
            List<double> sides = new List<double> {ASide, BSide, CSide };
            sides.Sort();
            double hypotenuse = sides[2];
            double katet1 = sides[1];
            double katet2 = sides[0];
            return Math.Abs(Math.Pow(hypotenuse, 2) - Math.Pow(katet1,2) - Math.Pow(katet2,2)) < littleDig;
            //Вычисляем по Пифагору прямоугольный ли треугольник. Т.к. список со сторонами отсортирован, sides[2] - наибольшая стороны, которая может являться гипотенузой
            //return Math.Abs(sides[2] * sides[2] - sides[1] * sides[1] - sides[0] * sides[0]) < littleDig;
        }
    }
}
