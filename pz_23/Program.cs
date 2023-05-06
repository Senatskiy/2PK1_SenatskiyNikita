using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(20, 30);
            Rectangle rectangle2 = new Rectangle(50, 70);
            Rectangle rectangle3 = new Rectangle(80, 90);
            rectangle1.PrintInfo();
            rectangle2.PrintInfo();
            rectangle3.PrintInfo();

            Cube cube1 = new Cube(10);
            Cube cube2 = new Cube(40);
            Cube cube3 = new Cube(70);
            cube1.PrintInfo();
            cube2.PrintInfo();
            cube3.PrintInfo();
            Console.ReadKey();
        }
    }
}
