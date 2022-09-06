using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox_Task_ClassLib_Figure
{
    public class Triangle : Figure //треугольник
    {

        double a, b, c; // стороны прямоугольника

        public Triangle(string name, double a, double b, double c) : base(name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double square()
        {
            double p; //полупериметр
            double S; //площадь

            //проверка треугольника на существование и значения должны быть больше нуля
            if ((a + b > c && a + c > b && b + c > a) && (a > 0 && b > 0 && c > 0))
            {

                p = (a + b + c) / 2;
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return S;


            }
            throw new ArgumentException("Такой треугольник не существует, так как сумма любых двух его сторон должна быть больше третьей стороны");

        }
        private void IsStraightAngle()
        {
            if (c > a && c > b)
            {
                if (c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)))
                {
                    Console.WriteLine("Треугольник прямоугольный");
                }
            }
        }
        public override void Print()
        {
            Console.WriteLine($"Тип фигуры: {Name}\nCтороны треугольникика a={a}, b={b}, c={c}\nПлощадь = {square():0.000}");
            IsStraightAngle();
        }
    }
}
