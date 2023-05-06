using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    internal class Rectangle
    {
        private double a;
        private double b;


        private static int count;
        private static int countWith50;
        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
            count++;
            if (Math.Abs(A - B) > 50)
            {
                countWith50++;
            }
        }

        public double A
        {
            get { return a; }
            set
            {
                if (value < 10 || value > 100)
                {
                    Console.WriteLine("Значение должно быть в диапазоне от 10 до 100");
                }
                a = value;
            }
        }

        public double B
        {
            get { return b; }
            set
            {
                if (value < 10 || value > 100)
                {
                    Console.WriteLine("Значение должно быть в диапазоне от 10 до 100");
                }
                b = value;
            }
        }

        public double GetVolume()
        {
            return 0;

        }

        public double GetArea()
        {
            return a * b;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Прямоугольник со сторонами {a} и {b}, площадью {GetArea()}");
        }
    }
}
