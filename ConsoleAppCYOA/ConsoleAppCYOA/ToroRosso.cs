using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCYOA
{
    public class ToroRosso : Robot
    {
        Random random = new Random();
        public ToroRosso(string designation, int model)
        {
            this.designation = designation;
            this.model = model;
            powerLevel = random.Next(90, 170);
            structuralIntegrity = 100;
        }
        public override int March()
        {
            base.March();
            if (powerLevel >= 70)
            {
                powerLevel -= 13;
                Console.WriteLine("The {0} sprints forward at an alarming speed!", designation);
            }
            else if (powerLevel < 20)
            {
                SideSwipe();
            }
            return (powerLevel);
        }
        public void SideSwipe()
        {
            Console.WriteLine("The {0} darts to the right attempting to run his opponent off the track!\nWhat a dirty move!", designation);
            base.March();
        }
    }
}
