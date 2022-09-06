using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox_Task_ClassLib_Figure
{
    public abstract class Figure
    {
        //поле название фигуры
        private string name;
        //конструктор класса
        public Figure(string name)
        {
            this.name = name;
        }
        //для доступа к полю необходимо свойство 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //метод для подсчета площади фигуры
        public abstract double square();
        //метод для вывода информации о фигуре
        public virtual void Print()
        {
            Console.WriteLine($"Name = {Name}");
        }
    }
}
