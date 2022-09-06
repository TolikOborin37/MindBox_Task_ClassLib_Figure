using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox_Task_ClassLib_Figure
{
    public class Circle : Figure //круг
    {
        double radius;

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double square()
        {
            double S; // площадь круга
            if (radius > 0)
            {
                S = Math.PI * Math.Pow(radius, 2);
                return S;
            }
            throw new ArgumentException("радиус не может быть меньше или равным нулю");
        }
        public override void Print()
        {
            Console.WriteLine($"Тип фигуры: {Name}\nРадиус = {radius}\nПлощадь круга = {square()}");

        }
    }
}
