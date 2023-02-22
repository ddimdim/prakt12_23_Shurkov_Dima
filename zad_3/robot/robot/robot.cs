using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot
{
    class robot
    {
        public int kollife;
        public int getlife()
        {
            return kollife;
        }
        public void min(int a)
        {
            Random rn = new Random();
            kollife = a;
            kollife = rn.Next(0, (a * 70 / 100));
            //kollife = (int)kollife / 2;
        }
        public void kol(int a, int k)
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
