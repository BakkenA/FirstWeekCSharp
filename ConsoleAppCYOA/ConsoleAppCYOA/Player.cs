using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCYOA
{
    public class Player
    {
        public int rock = 0;
        public int paper = 1;
        public int scissors = 2;
        public int lizard = 4;
        public int spock = 3;
        public string[] gameArray = new string[5] { "ROCK", "PAPER", "SCISSORS", "SPOCK", "LIZARD" };
        public string name;
        public int shoot;
        public int score = 0;

        public virtual void GetName()
        {
            Console.WriteLine("Who is this?");
            name = Console.ReadLine();
        }
        public virtual void GetShoot()
        {
            {
            string choice = Console.ReadLine().ToUpper();
                while (choice != "")
                {

                    switch (choice)
                    {
                        case "ROCK":
                            shoot = rock;
                            break;
                        case "PAPER":
                            shoot = paper;
                            break;
                        case "SCISSORS":
                            shoot = scissors;
                            break;
                        case "LIZARD":
                            shoot = lizard;
                            break;
                        case "SPOCK":
                            shoot = spock;
                            break;
                    }
                }
            }
        }
    }
}