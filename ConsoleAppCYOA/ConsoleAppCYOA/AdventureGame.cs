using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCYOA
{
    public class AdventureGame
    {
        public void BeginStory()
        {
            Console.WriteLine("The plane has landed and the seatbelt indicator has dimmed. As you unfasten your seatbelt and arch you back you consider the flight you just had.\n How was your flight? Choose: good/bad");
            string response=Console.ReadLine();
            if (response=="good")
            {
                Console.WriteLine("The flight from Milwaukee to D.C. is only about 3 hours, and soon you'll be back in your apartment.");
                Console.Write("Press Enter to Continue");
                Console.Read();
                ParkingStructure();
            }
            else if (response!="good")
            {
                Console.WriteLine("It really doesn't matter how big a plane is does it? Seven and a half hours seated inside an aluminum tube 39,000 ft above sea level and no combination of mobile games, movies and half-inch think foam cushioning is going to ever make that a truly pleasant experience.");
            }
        }
        public void ParkingStructure()
        {
            Console.WriteLine("After retrieving your bag from the baggage claim carousel you head to the parking structure to find your car.");
            string response ="";
            do
            {
                response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        Console.WriteLine("As you cross the road in front of the baggage claim terminal you fail to notice that you've stepped out directly in front of a bus.\nLuckily the driver noticed you and honks at you while making rude gestures from behind the windshield.\nYou look around embarrassed and return to the baggage claim");
                        break;
                    case "2":
                        Console.WriteLine("You take the escalator up to the walkway and enter the parking structure.\nYou go to where you remember having parked, but there's a red pea-green Pontiac Aztek where your car should be");
                        break;
                    case "3":
                        Console.WriteLine("As you step out of the elevator area you look to where you remember having parked and see the butt of your car sticking out next to a black Oldsmobile Alero");
                        break;
                    case "4":
                        Console.WriteLine("You step out of the elevator area and look up to see the amber light of the city reflected off the cloudy night sky.\nLooking across the Potomac you see the illuminated scaffolding surrounding the Washington Monument.\nYou remember hearing about the earthquake while you were away.\nBut you definitely did not park on this level.");
                        break;
                    case "5":
                        Console.WriteLine("You jab you're finger at where the '5' button should be on the elevator panel, but fail to find any button.\nIt was only a three hour flight.\nMaybe you should just take the Metro...");
                        break;
                }
                Console.WriteLine("What level did you park on again?\nchoose 1 / 2 / 3 / 4 / 5");
            } while (response != "3");
            Console.Clear();
            DriveHome();
        }
        public void DriveHome()
        {
            Console.WriteLine("As you descend the spiralling ramp of the parking structure you're mind drifts back to the events of the past few weeks.\nHow does that make you feel? choose good/bad");
            string response = Console.ReadLine();
            if (response == "good")
            {
                Console.WriteLine("It was nice seeing family again, but you've always enjoyed being on your own.\n You attentively make your way home through D.C.'s surface streets");
                Console.ReadLine();
                HomeAtLast();
            }
            if (response == "bad")
            {
                Console.WriteLine("As soon as you got there you couldn't wait to get back to your self-imposed isolation in D.C.\nYou chance a yellow light while turning onto K Street and get clipped by a police car.");
                Console.ReadLine();
                Jail();
            }
        }
        public void HomeAtLast()
        {
            Console.WriteLine("As you pull into the parking lot of your apartment building you feel a moment of irritation well-up in you");
            Console.ReadLine();

        }
        public void Jail()
        {

        }
    }
}
