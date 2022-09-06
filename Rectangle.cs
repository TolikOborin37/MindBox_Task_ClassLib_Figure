using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox_Task_ClassLib_Figure
{
    public class Rectangle : Figure //прямоугольник (добавление другой фигуры)
    {
        double a, b; //стороны прямоугольника

        public Rectangle(string name, double a, double b) : base(name)
        {
            this.a = a;
            this.b = b;
        }

        public override double square()
        {

            double S; //площать прямоугольника
            if (a > 0 && b > 0)
            {
                S = a * b;
                return S;
            }
            throw new ArgumentException("Стороны прямоугольника не могут быть меньше или равно нулю");
        }
        private void IsSquare()
        {
            if (a == b)
            {
                Console.WriteLine("Прямоугольник является квадратом");
            }
        }
        public override void Print()
        {
            Console.WriteLine($"Тип фигуры: {Name}\nCтороны прямоугольник a={a} , b={b}\nПлощать прямоугольника = {square()}");
            IsSquare();
        }
    }
}
