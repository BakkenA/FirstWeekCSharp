using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCYOA
{
    public class RobotEncounter
    {
        SFSixteen vettel = new SFSixteen("Seb", 2016);
        SFSixteen raik = new SFSixteen("Kimi", 2016);
        ToroRosso sain = new ToroRosso("Carlos", 2015);
        ToroRosso kvyat = new ToroRosso("Dany", 2015);
        List<Robot> roboHorde;
      
        
        
        
          
        public RobotEncounter()
        {
            roboHorde = new List<Robot> { vettel, raik, sain, kvyat };
            
        }


        public void BeginEncounter()
        {
            foreach(Robot robo in roboHorde)
            {
                Console.WriteLine("The {0} {1} takes to the track!", robo.designation, robo.model);
                Console.ReadLine();
            }
            RollOut();
        }
        public void RollOut()
        {
            int lap = 0;
            while (roboHorde.Count > 1 && lap < 10)
            {
                lap++;
                foreach (Robot robo in roboHorde)
                {
                    robo.March();
                    Console.ReadLine();
                }
                Race();
            }
            Random random = new Random();
            int randomrobo = random.Next(0, 1);
            Console.WriteLine("And {0} wins the race, thank you all for joining us today here at Circuit of the Circuits!", roboHorde[randomrobo].designation);
            Console.ReadLine();
        }
        public void CheckBattery()
        {
            foreach (Robot robo in roboHorde)
            {
                robo.CheckBattery();
                Console.ReadLine();
            }
            Race();
        }
        public void Race()
        { 
                for (int i = 0; i < roboHorde.Count; i++)
                {
                    
                    if (roboHorde[i].powerLevel <= 0)
                    {
                        Console.WriteLine("{0} is unable to finish the race!", roboHorde[i].designation);
                        roboHorde.Remove(roboHorde[i]);
                        i--;
                    }
            }
                
            }
        }
    }


