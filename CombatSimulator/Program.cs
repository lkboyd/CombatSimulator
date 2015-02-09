using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSimulator
{
    class Program
    {

        //defining the varriables that need to be global for the entire program. 

        static Random rng = new Random();
        static bool gamePlaying = true;
        static int userHits = 100;
        static int dragonHits = 200;

        /// <summary>
        /// Main function that contains the loop for the game play.  If conditions continue to be true the game continues
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //intro to the game and the rules
            
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
                //clears the rules and asks for the user to choose their attack
                Console.Clear();
                Console.WriteLine("Choose a. Sword, b. Magic, or c. Health");
                string userInput = Console.ReadLine();
            }

            if (userHits == 0)
            {
                Console.WriteLine("The Dragon Wins!  You have been burnt to a crisp...");
            }
            else
            {
                Console.WriteLine("You killed the Dragon!  The Kingdom is saved!! :) ");
            }


        }



        /// <summary>
        /// Taking the input from the gamer and vaildating if it is one of th three options that they can choose. 
        /// </summary>
        /// <param name="userInput">a b or c is an acceptable input</param>
        /// <returns>if a b c then the game continues, if not returns invalid input try again</returns>
        public static string ValidateInput(string userInput)
        {

            if (userInput.ToLower() != "a" || userInput.ToLower() != "b" || userInput.ToLower() != "c")
            {
                return "Invalid option, try again!";
            }
            else
            {
                return ("You picked option " + userInput + "lets see how well you do!"); 
            }
            
        }

        /// <summary>
        /// Playing of the Game function, goes throught the gamers turn, then the dragons turn.  
        /// </summary>
        /// <param name="userInput">user input is the choice they pick sword magic or healing</param>
        public static void PlayingGame(string userInput)
        {
            //defining my varriables

            int numberOfHitsPoints = 0;
            int percentageOfTime = 0;
            int numberOfHealth = 0;

            //the start of the game play option a (sword)
            if (userInput == "a")
            {

                //rng needed to define the percentage of time the hits actually work
                percentageOfTime = rng.Next(1, 11);

                //if it is within the 70 percent of the time this code will enact a second rng to find out how many hit point it will cause the dragon.  
                if (percentageOfTime <= 7)
                {
                    numberOfHitsPoints = rng.Next(20, 36);
                    dragonHits = dragonHits - numberOfHitsPoints;
                    Console.WriteLine("You hit the Dragon!  Good Job!  The Dragon still has " + dragonHits + "left.  Keep it up!");
                }
                //if it is not in the 70 % then the gamer has missed.  
                else
                {
                    Console.WriteLine("You Missed!  Try again");
                }
            }
            //this is the magic section.  only needed one rng for this section because it always hit.  just need to define how much of a hit it causes.  
            else if (userInput == "b")
            {
                numberOfHitsPoints = rng.Next(10, 16);
                dragonHits = dragonHits - numberOfHitsPoints;
                Console.WriteLine("You hit the Dragon! The Dragon is now at " + dragonHits);
            }

            //this is the option to heal yourself.  
            else
            {
                numberOfHealth = rng.Next(10, 21);
                userHits = userHits + numberOfHealth;
                Console.WriteLine("Good choice healing yourself, better be healthy to be able to attack!  You now have " + userHits + "life left.");
            }

            //after the gamers play it is the dragons play.  useing the rng to see if he hits you or not and then another one to see by how much if he did.  
            numberOfHitsPoints = rng.Next(1, 11);

            if (numberOfHitsPoints >= 8)
            {
                numberOfHitsPoints = rng.Next(5, 16);
                userHits = userHits - numberOfHitsPoints;
                Console.WriteLine("The Dragon's Attack has cost you " + numberOfHitsPoints + ".  You now have " + userHits + " left!  Be Careful!");
            }
            else
            {
                Console.WriteLine("Wahoo!  The Dragon Missed!  Now it is your turn again...go at it!");
            }


        }

    }
}

