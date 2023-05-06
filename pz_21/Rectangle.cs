using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    internal class Rectangle
    {
        private double a;
        private double b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double GetVolume()
        {
            return 0;

        }

        public double GetArea()
        {
            return a * b;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Прямоугольник со сторонами {a} и {b}, площадью {GetArea()}");
        }
    }
}
