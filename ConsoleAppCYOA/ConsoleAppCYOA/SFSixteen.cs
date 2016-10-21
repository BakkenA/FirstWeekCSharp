using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCYOA
{
    public class SFSixteen : Robot
    {
        public SFSixteen(string designation, int model)
        {
            this.designation = designation;
            this.model = model;
            Random random = new Random();
            powerLevel = random.Next(90, 170);
            structuralIntegrity = 100;
        }
        //Kinetic Energy Recovery System
        public override int March()
        {
            if (powerLevel >= 50)
            {
                base.March();
            }
            else if (powerLevel <= 50)
            {
                powerLevel += 5;
                Console.WriteLine("The {0} slows down slightly, but its battery slightly recharges!", designation);
                
            }
            return (powerLevel);
        }
        //Smart Battery
        public override int CheckBattery()
        {
            base.CheckBattery();
            if(powerLevel <= 30)
            {
                powerLevel += 10;
                Console.WriteLine("The {0}'s battery is now at " + powerLevel, designation);
            }
            return (powerLevel);
        }


    }
}
