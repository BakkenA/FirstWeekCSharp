using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCYOA
{
    public class CPUPlayer : Player
    {
        public CPUPlayer()
        {
            name = "Doctor Spaetzo";
        }
        public override void GetShoot()
        {
            Random rand = new Random();
            shoot = rand.Next(0, 4);
        }
    }
}
