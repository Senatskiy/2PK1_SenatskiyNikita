using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Patrol
    {
        public void OnSpeedChanged(int speed)
        {
            if (speed > 80 && speed <= 120)
            {
                Console.WriteLine("Превышена скорость! Снизьте скорость до 80 км/ч");
            }
            else if (speed > 120)
            {
                Console.WriteLine("Превышена скорость! Активизируется режим задержания.");
            }
        }
    }
}
