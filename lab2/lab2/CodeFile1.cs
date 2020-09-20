using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCollections
{
    /// <summary>
    /// Класс фигура
    /// </summary>
    abstract class Figure : IComparable, IPrint
    {
        /// <summary>
        /// Тип фигуры
        /// </summary>
        public string Type
        {
            get //C:\Users\Xiaomi\source\repos\lab2\lab2\App.config
            {
                return this._Type;
            }
            protected set
            {
                this._Type = value;
            }
        }
        string _Type;
        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns></returns>
        public abstract double Area();
        /// <summary>
        /// Приведение к строке, переопределение метода Object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Type + " площадью " + this.Area().ToString();
        }
        /// <summary>
        /// Вывод объекта на консоль
        /// </summary>
        /// <returns></returns>
        public abstract void Print();
        /// <summary>
        /// Сравнение элементов (для сортировки списка)
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)

        {
            Figure p = (Figure)obj;
            if (this.Area() < p.Area()) return -1;
            else if (this.Area() == p.Area()) return 0;
            else return 1; //(this.Area() > p.Area())
        }
    }

    class Rectangle : Figure, IPrint
    {
        /// <summary>
        /// Высота
        /// </summary>
        protected double height;
        /// <summary>
        /// Ширина
        /// </summary>
        double width;
        /// <summary>
        /// Основной конструктор
        /// </summary>
        /// <param name="ph">Высота</param>
        /// <param name="pw">Ширина</param>
        public Rectangle(double ph, double pw)
        {
            this.height = ph;
            this.width = pw;

            this.Type = "Прямоугольник";
        }
        /// <summary>
        /// Вычисление площади
        /// </summary>
        public override double Area()
        {
            double Result = this.width * this.height;
            return Result;
        }
        public override string ToString() {
            return this.Type + " площадью " + this.Area().ToString()+ " и сторонами " + this.height + " и " + this.width;
        }


        public override void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }

    class Square : Rectangle, IPrint
    {
        public Square(double size)
        : base(size, size)
        {
            this.Type = "Квадрат";
        }
        public override string ToString()
        {
            return this.Type + " площадью " + this.Area().ToString() + " и стороной " + this.height;
        }
        public override void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }


    class Circle : Figure, IPrint
    {
        /// <summary>
        /// Ширина
        /// </summary>
        double radius;
        /// <summary>

        /// Основной конструктор
        /// </summary>
        /// <param name="ph">Высота</param>
        /// <param name="pw">Ширина</param>
        public Circle(double pr)
        {
            this.radius = pr;
            this.Type = "Круг";
        }
        public override double Area()
        {
            double Result = Math.PI * this.radius * this.radius;
            return Result;
        }
        public override string ToString()
        {
            return this.Type + " площадью " + Math.Round(this.Area(), 3).ToString() + " и радиусом " + this.radius;
        }
        public override void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }


    interface IPrint
    {
        void Print();
    }

    internal class Program
    {
        private static void Main()
        {
            Figure figure1 = new Circle(4);

            Figure figure2 = new Rectangle(5, 6);

            figure1.Print();
            figure2.Print();

            Console.ReadLine();
        }
    }
}