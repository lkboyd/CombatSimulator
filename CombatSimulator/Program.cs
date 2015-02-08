using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSimulator
{
    class Program
    {
        static Random rng = new Random();
        static bool gamePlaying = true;
        static int userHits = 100;
        static int dragonHits = 200;


        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Dragon Slayer!");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("\nHere's how you play:");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(" \nYou are fighting a horrible dragon!  You are charged with saving the kingdom of Butterfly Land.");
            Console.WriteLine("\n\nYou have three options available to you.  Your Sword, Your Magic and Healing \nyourself");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("\n You will have 100 HP (hit points), and the Dragon will have 200 HP");
            Console.WriteLine("\n Option A (Your Sword) will give between 20 and 35 HP to the Dragon, but only \n70% of the time!");
            Console.WriteLine("\n Option B (Your Magic) will give you a FIREBALL that will always hit the \nDragon but only gives 10-15 HP");
            Console.WriteLine("\n Option C (Healing) will give you back 10-20 HP for any damage the horrible \nDragon does to you!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\n\nIf you dare choose your first option!");
            Console.ReadLine();

            while (gamePlaying)
            {
                Console.Clear();
                Console.WriteLine("Choose a. Sword, b. Magic, or c. Health");
                GetUserInput();

            }

            if (userHits == 0)
            {
                Console.WriteLine("The Dragon Wins!  You have been burnt to a crisp...")
            }
            else (dragonHits == 0)
            {
                Console.WriteLine("You killed the Dragon!  The Kingdom is saved!! :) ")
            }


        }





        public static void GetUserInput()
        {
            Console.Write("Choose a. Sword, b. Magic, or c. Health");
            string userInput = Console.ReadLine();

        }


        /// <summary>
        /// Taking the input from the gamer and vaildating if it is one of th three options that they can choose. 
        /// </summary>
        /// <param name="userInput">a b or c is an acceptable input</param>
        /// <returns>if a b c then the game continues, if not returns invalid input try again</returns>
        public static string ValidateInput(string userInput)
        {

            if (userInput.ToLower() != "a" || userInput != "b" || userInput != "c")
            {
                return "Invalid option, try again!";
            }
        }


        public static void Options(string userInput)
        {

            int numberOfHitsPoints = 0;
            while (userInput == "a")
            {
                numberOfHitPoints = rng.Next(1, 11);

            }

        }

    }
}

