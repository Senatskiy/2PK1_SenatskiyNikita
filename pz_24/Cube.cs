using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_24
{
    internal class Cube: Rectangle, IClonable
    {
        private int _edge;

        public Cube(int edge) : base(edge, edge)
        {
            Edge = edge;
        }

        public int Edge
        {
            get => _edge;
            set
            {
                if (value < 1 || value > 99)
                {
                    Console.WriteLine("Значение должно быть в диапазоне от 1 до 99.");
                }
                A = B = value;
                _edge = value;
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Куб с ребром {Edge} имеет объем  {GetVolume()} и площадь {GetArea()}");
        }
        public new object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
