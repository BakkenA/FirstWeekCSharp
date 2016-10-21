using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCYOA
{
    class RPSLSGame
    {
        Player player;
        Player playerTwo;
        public int rock = 0;
        public int paper = 1;
        public int scissors = 2;
        public int lizard = 3;
        public int spock = 4;
        public string[] gameArray = new string[5] { "ROCK", "PAPER", "SCISSORS", "LIZARD", "SPOCK" };
        public RPSLSGame()
        {

        }
        public void LaunchGame()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!\nPlease select one of the following options:\nNEW GAME\nRULES");
                string menuChoice = Console.ReadLine().ToUpper();
                if (menuChoice == "NEW GAME")
                {
                    SelectingPlayers();
                }
                else if (menuChoice == "RULES")
                {
                    RunTutorial();
                }
                else
                {
                    Console.WriteLine("Why are you being so difficult?\nThe choices here are rather...\nBinary");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }
        public void RunTutorial()
        {
            Console.WriteLine("The rules are quite simple, but not everyone is familiar with them.\nPlus, I can tell you're human.\nI'll go slowly to make sure you understand...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Scissors cuts Paper");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Paper covers Rock");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Scissors cuts Paper");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Paper covers Rock");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Rock crushes Lizard");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Lizard poisons Spock");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Spock smashes Scissors");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Scissors decapitates Lizard");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Lizard eats Paper");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Paper disproves Spock");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Spock vaporizes Rock");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("And as it always has...\nRock crushes Scissors");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Best 2 out of 3 wins.");
            Console.ReadLine();
            Console.Clear();
            LaunchGame();
        }
        public void SelectingPlayers()
        {
            Console.WriteLine("So how many human players do we have today?\nChoose: 1 or 2");
            if (GetChoice() == 1)
            {
                Console.WriteLine("Ah yes, I noticed the bravery in your eyes when I accessed your webcam human");
                System.Threading.Thread.Sleep(700);
                Console.WriteLine("Well then, good luck to you, I promise to play fair");
                System.Threading.Thread.Sleep(700);
                Console.WriteLine("Foolish of you to trust a computer you pathetic descendant of monkeys!");
                System.Threading.Thread.Sleep(400);
                Console.Clear();
                CreatePlayers(1);
                BeginTurn();
            }
            else if (GetChoice() == 2)
            {
                Console.WriteLine("Oh so you brought a friend! How delightful for you both. Well once you get started I'll leave you two to it");
                System.Threading.Thread.Sleep(700);
                Console.WriteLine("I've never been able to understand the human need for companionship.");
                System.Threading.Thread.Sleep(400);
                Console.Clear();
                CreatePlayers(2);
                BeginTurn();
            }
        }
        public void CreatePlayers(int choice)
        {
            if (choice == 1)
            {
                player = new HumanPlayer();
                playerTwo = new CPUPlayer();
            }
            else if (choice == 2)
            {
                player = new HumanPlayer();
                playerTwo = new HumanPlayer();
            }
        }
        public void BeginTurn()
        {
            DisplayScore();
            Console.WriteLine("ROCK PAPER SCISSORS LIZARD SPOCK\nMake your choice.");
            player.GetShoot();
            playerTwo.GetShoot();
            DetermineWinner();
        }
        public void CheckingTurn()
        {
            if (player.score == 2)
            {
                Console.WriteLine("Congratulations {0}!\nYou've won!!!", player.name);
                EndGame();
            }
            if (playerTwo.score == 2)
            {
                Console.WriteLine("Congratulations {0}!\nYou've won!!!", playerTwo.name);
                EndGame();
            }
            else
            {
                BeginTurn();
            }
        }
        public int GetChoice()
        {
            int choice;
            bool exit = false;
            while (!exit)
            {
                if (Int32.TryParse(Console.ReadLine(), out choice))
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("That is not a valid option human.");
                }
            }
            return -1;
        }
        //public void GetShoot()
        //{
        //    string choice = Console.ReadLine().ToUpper();
        //    switch (choice)
        //    {
        //        case "ROCK":
        //            shoot = rock;
        //            break;
        //        case "PAPER":
        //            shoot = paper;
        //            break;
        //        case "SCISSORS":
        //            shoot = scissors;
        //            break;
        //        case "LIZARD":
        //            shoot = lizard;
        //            break;
        //        case "SPOCK":
        //            shoot = spock;
        //            break;
        //    }
        //    DetermineWinner();

        //}
        public void DetermineWinner()
        {
            int winner = (5 + player.shoot - playerTwo.shoot) % 5;
            Console.WriteLine("{0} chose {1}, {2} chose {3}", player.name, player.shoot, playerTwo.name, playerTwo.shoot);
            if (winner == 0)
            {
                Console.WriteLine("The result is a tie...\nHow boring, well go again.");
                Console.ReadLine();
            }
            else if (winner % 2 == 1)
            {
                player.score += 1;
                Console.WriteLine("Congratulations {0} you won the round.", player.name);
            }
            else if (winner % 2 == 0)
            {
                playerTwo.score += 1;
                Console.WriteLine("Well, well, well...\nLooks like {0}'s got you're number.", playerTwo.name);
            }
            CheckingTurn();
        }
        public void DisplayScore()
        {
            Console.WriteLine("{0} has a score of {1} and {2} has a score of {3}!", player.name, player.score, playerTwo.name, playerTwo.score);
        }
        public void EndGame()
        {
            bool exit = false;
            while (!exit)
            {
                string restart = Console.ReadLine().ToUpper();
                Console.WriteLine("Play Again?\nYES or NO");
                if (restart == "YES")
                {
                    LaunchGame();
                }
                if (restart == "NO")
                {
                    Console.WriteLine("Fare thee well human...");
                    Environment.Exit(0);
                }
            }

        }
    }
}
