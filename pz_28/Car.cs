using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Car
    {
        public delegate void MethodContainer();
        public event MethodContainer opovesh;
        public event MethodContainer zader;
        public event MethodContainer umer;
        public int speed = 0;

        public void Razgon()
        {
            while (speed != 200)
            {
                speed += 5;
                Console.WriteLine(speed);
                if (speed == 60)
                {
                    opovesh();
                }
                else if (speed == 120)
                {
                    zader();
                }
                else if (speed == 200)
                {
                    umer();
                }

            }
        }
    }
}
