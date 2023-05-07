using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(); //3вариант
            Patrol patrol = new Patrol();
            car.SpeedChanged += patrol.OnSpeedChanged;
            car.Accelerate();
            Console.ReadKey();
        }
    }
}
