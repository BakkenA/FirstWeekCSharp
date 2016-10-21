using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCYOA
{
    public class Robot
    {
        Random random;
        public string designation;
        public int model;
        public int powerLevel;
        public int structuralIntegrity = 100;
        public List<string> therobots;
        public Robot()
        {
            powerLevel = 100;
        }
        public virtual int March()
        {
            random = new Random();
            int powerconsumption = random.Next(10, 25);
            powerLevel -= powerconsumption;
            if (powerLevel > 0)
            {
                Console.WriteLine("The {0} moves forward.", designation);
                Console.WriteLine("It's battery is now at {0}%", powerLevel);
                return (powerLevel);
            }
            else if (powerLevel <= 10)
            {
                Console.WriteLine("The {0} might be eliminated from this race!", designation);
                return (powerLevel);
            }
            return (powerLevel);
        }
        public virtual int CheckBattery()
        {
            Console.WriteLine(powerLevel);
            return(powerLevel);
        }
        public int Recharge()
        {
            powerLevel += 10;
            return (powerLevel);
        }
    }
}
