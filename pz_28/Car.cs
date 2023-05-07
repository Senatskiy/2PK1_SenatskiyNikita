using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Car
    {
        private int speed = 0;
        public event Action<int> SpeedChanged;

        public void Accelerate()
        {
            for (int i = 0; i <= 200; i += 10)
            {
                speed = i;
                SpeedChanged?.Invoke(speed);
            }
        }
    }
}
