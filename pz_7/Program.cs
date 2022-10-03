using System;
using System.Linq;

namespace Senatskiy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massiv = { -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int min = massiv.Min();
            int max = massiv.Max();
            int count = massiv.Count(numb => max < -numb);
            if (max >= -min)
                Console.WriteLine($"В массиве минимальным по модулю элементом является число {count}.");

        }
    }
}
