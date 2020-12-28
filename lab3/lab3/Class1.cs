using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparseMatrix
{
    public class Matrix<T>
    {
        /// <summary>
        /// Словарь для хранения значений
        /// </summary>
        Dictionary<string, T> _matrix = new Dictionary<string, T>();

        int maxX;
        int maxY;
        int maxZ;
        T nullElement;

        public Matrix(int px, int py, int pz)
        {
            this.maxX = px;
            this.maxY = py;
            this.maxZ = pz;
        }

        public Matrix(int px, int py, T nullElementParam)
        {
            this.maxX = px;
            this.maxY = py;
            this.nullElement = nullElementParam;
        }
        /// <summary>
        /// Индексатор для доступа к данных
        /// </summary>
        public T this[int x, int y]
        {
            get
            {
                CheckBounds(x, y);
                string key = DictKey(x, y);
                if (this._matrix.ContainsKey(key))
                {
                    return this._matrix[key];
                }
                else
                {
                    return this.nullElement;
                }
            }
            set
            {
                CheckBounds(x, y);
                string key = DictKey(x, y);
                this._matrix.Add(key, value);
            }
        }

        public T this[int x, int y, int z]
        {
            get
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                if (this._matrix.ContainsKey(key))
                {
                    return this._matrix[key];
                }
                else
                {
                    return this.nullElement;
                }
            }
            set
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                this._matrix.Add(key, value);
            }
        }

        void CheckBounds(int x, int y)
        {
            if (x < 0 || x >= this.maxX) throw new Exception("x=" + x + " выходит за границы");

            if (y < 0 || y >= this.maxY) throw new Exception("y=" + y + " выходит за границы");
        }

        void CheckBounds(int x, int y, int z)
        {
            if (x < 0 || x >= this.maxX) throw new Exception("x = " + x + " выходит за границы");

            if (y < 0 || y >= this.maxY) throw new Exception("y = " + y + " выходит за границы");

            if (z < 0 || z >= this.maxZ) throw new Exception("z = " + z + " выходит за границы");
        }

        /// <summary>
        /// Формирование ключа
        /// </summary>
        string DictKey(int x, int y)
        {
            return x.ToString() + "_" + y.ToString();
        }

        string DictKey(int x, int y, int z)
        {
            return x.ToString() + "_" + y.ToString() + "_" + z.ToString();
        }

        /// <summary>
        /// Приведение к строке
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            /*            StringBuilder b = new StringBuilder();
                        for (int j = 0; j < this.maxY; j++)
                        {
                            b.Append("[");
                            for (int i = 0; i < this.maxX; i++)
                            {
                                if (i > 0) b.Append("\t");
                                b.Append(this[i, j].ToString());
                            }
                            b.Append("]\n");
                        }
                        return b.ToString();
            */

            StringBuilder b = new StringBuilder();

            for (int i = 0; i < this.maxX; i++)
            {
                for (int j = 0; j < this.maxY; j++)
                {
                    for (int k = 0; k < this.maxZ; k++)
                    {
                        if (this[i, j, k] != null)
                        {
                            b.Append("[" + i + ", " + j + ", " + k + "]: ");
                            b.Append(this[i, j, k].ToString());
                            b.Append("\n");
                        }
                        else continue;
                    }
                }
            }

            return b.ToString();
        }
    }
}

namespace FigureCollections
{

    abstract public class Figure : IComparable, IPrint
    {
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
        public abstract double Area();
        public override string ToString()
        {
            return this.Type + " площадью " + this.Area().ToString();
        }
        public abstract void Print();
        public int CompareTo(object obj)

        {
            Figure p = (Figure)obj;
            if (this.Area() < p.Area()) return -1;
            else if (this.Area() == p.Area()) return 0;
            else return 1; //(this.Area() > p.Area())
        }
    }

    public class Rectangle : Figure, IPrint
    {
        protected double height;
        double width;

        public Rectangle(double ph, double pw)
        {
            this.height = ph;
            this.width = pw;

            this.Type = "Прямоугольник";
        }

        public override double Area()
        {
            double Result = this.width * this.height;
            return Result;
        }
        public override string ToString()
        {
            return this.Type + " площадью " + this.Area().ToString() + " и сторонами " + this.height + " и " + this.width;
        }

        public override void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }

    public class Square : Rectangle, IPrint
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

    public class Circle : Figure, IPrint
    {
        double radius;

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

    public class ArrayListItem
    {

        public Figure data { get; set; }

        public ArrayListItem next { get; set; }

        public ArrayListItem(Figure param)
        {
            this.data = param;
        }
    }

    public class ArrayList : IEnumerable
    {

        protected ArrayListItem first = null;

        protected ArrayListItem last = null;
        public int Count
        {
            get { return _count; }
            protected set { _count = value; }
        }
        int _count;

        public void Add(Figure element)
        {
            ArrayListItem newItem = new ArrayListItem(element);
            this.Count++;

            if (last == null)
            {
                this.first = newItem;
                this.last = newItem;

            }

            else
            {
                this.last.next = newItem;
                this.last = newItem;
            }
        }

        public ArrayListItem GetItem(int number)
        {
            if ((number < 0) || (number >= this.Count))
            {
                throw new Exception("Выход за границу индекса");
            }
            ArrayListItem current = this.first;
            int i = 0;

            while (i < number)
            {
                current = current.next;
                i++;
            }
            return current;
        }

        public Figure Get(int number)
        {
            return GetItem(number).data;
        }

        public IEnumerator GetEnumerator()
        {
            ArrayListItem current = this.first;
            //Перебор элементов
            while (current != null)
            {

                //Возврат текущего значения
                yield return current.data;
                //Переход к следующему элементу
                current = current.next;
            }
        }

        System.Collections.IEnumerator
       System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Sort()
        {
            Sort(0, this.Count - 1);
        }

        private void Sort(int low, int high)
        {
            int i = low;
            int j = high;
            Figure x = Get((low + high) / 2);
            do
            {
                while (Get(i).CompareTo(x) < 0) ++i;
                while (Get(j).CompareTo(x) > 0) --j;
                if (i <= j)
                {
                    Swap(i, j);
                    i++; j--;
                }
            } while (i <= j);
            if (low < j) Sort(low, j);
            if (i < high) Sort(i, high);
        }
        private void Swap(int i, int j)
        {
            ArrayListItem ci = GetItem(i);
            ArrayListItem cj = GetItem(j);

            Figure temp = ci.data;
            ci.data = cj.data;
            cj.data = temp;
        }
    }

    /*
    public class ArrayList
    {
        Figure[] f = new Figure[5];
        int count = 0;

        public void Add(Circle c)
        {
            this.f[count] = c;
            count++;
        }
        public void Add(Rectangle r)
        {
            this.f[count] = r;
            count++;
        }
        public void Add(Square s)
        {
            this.f[count] = s;
            count++;
        }

        public IEnumerator GetEnumerator()
        {
            return f.GetEnumerator();
        }

        public void Sort() 
        {
            Figure f1;
            for (int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (this.f[i].Area() > this.f[j].Area())
                    {
                        f1 = this.f[i];
                        this.f[i] = this.f[j];
                        this.f[j] = f1;
                    }
                }
            }

        }

    }*/

    public class SimpleListItem<T>
    {

        public T data { get; set; }

        public SimpleListItem<T> next { get; set; }
       
        public SimpleListItem(T param)
        {
            this.data = param;
        }
    }

    public class SimpleList<T> : IEnumerable<T>
    where T : IComparable
    {

        protected SimpleListItem<T> first = null;

        protected SimpleListItem<T> last = null;
        public int Count
        {
            get { return _count; }
            protected set { _count = value; }
        }
        int _count;

        public void Add(T element)
        {
            SimpleListItem<T> newItem = new SimpleListItem<T>(element);
            this.Count++;
            
            if (last == null)
            {
                this.first = newItem;
                this.last = newItem;

            }
            
            else
            {
                this.last.next = newItem;
                this.last = newItem;
            }
        }

        public SimpleListItem<T> GetItem(int number)
        {
            if ((number < 0) || (number >= this.Count))
            {
                throw new Exception("Выход за границу индекса");
            }
            SimpleListItem<T> current = this.first;
            int i = 0;

            while (i < number)
            {
                current = current.next;
                i++;
            }
            return current;
        }
        public T Get(int number)
        {
            return GetItem(number).data;
        }
        public IEnumerator<T> GetEnumerator()
        {
            SimpleListItem<T> current = this.first;
            //Перебор элементов
            while (current != null)
            {

                //Возврат текущего значения
                yield return current.data;
                //Переход к следующему элементу
                current = current.next;
            }
        }
        System.Collections.IEnumerator
       System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Sort()
        {
            Sort(0, this.Count - 1);
        }

        private void Sort(int low, int high)
        {
            int i = low;
            int j = high;
            T x = Get((low + high) / 2);
            do
            {
                while (Get(i).CompareTo(x) < 0) ++i;
                while (Get(j).CompareTo(x) > 0) --j;
                if (i <= j)
                {
                    Swap(i, j);
                    i++; j--;
                }
            } while (i <= j);
            if (low < j) Sort(low, j);
            if (i < high) Sort(i, high);
        }
        private void Swap(int i, int j)
        {
            SimpleListItem<T> ci = GetItem(i);
            SimpleListItem<T> cj = GetItem(j);

            T temp = ci.data;
            ci.data = cj.data;
            cj.data = temp;
        }
    }

    public class SimpleStack<T> : SimpleList<T>
    where T : IComparable
    {
        public void Push(T element)
        {
            Add(element);
        }
        public T Pop()
        {
            T Result = default(T);
            if (this.Count == 0) return Result;
            if (this.Count == 1)
            {
            Result = this.first.data;
                this.first = null;
                this.last = null;
            }

            else
            {
                SimpleListItem<T> newLast = this.GetItem(this.Count - 2);
                Result = newLast.next.data;
                this.last = newLast;
                newLast.next = null;
            }
            this.Count--;
            return Result;
        }
    



        /*       private T[] items; 
               private int count;

               public bool IsEmpty
               {
                   get { return count == 0; }
               }

               public void Push(T item)
               {
                   if (count == items.Length)
                       throw new InvalidOperationException("Переполнение стека");
                   items[count++] = item;
               }

               public T Pop()
               {
                   if (IsEmpty)
                       throw new InvalidOperationException("Стек пуст");
                   T item = items[--count];
                   items[count] = default(T); // сбрасываем ссылку
                   return item;
               }
       */

    }
}