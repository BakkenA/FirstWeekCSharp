using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCYOA
{
    public class HumanPlayer : Player
    {
        public HumanPlayer()
        {
            this.name = NewName();
        }

        public string NewName()
        {
            GetName();
            return name;
        }
    }
}