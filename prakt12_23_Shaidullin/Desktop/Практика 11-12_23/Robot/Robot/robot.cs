using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class robot
    {

        public int kollife;

        public int Getlife()
        {
            return kollife;
        }

        public void Min(int a)
        {
            Random rnd = new Random();
            kollife = a;
            kollife = rnd.Next(0, (a * 70 / 100));
        }
        public void Kol(int a, int k)
        {
            if (k == a / 2)
            {
                kollife = kollife + 30;
            }
            else if (k == a * 0.7)
            {
                kollife += 20;
            }
        }
    }
}
