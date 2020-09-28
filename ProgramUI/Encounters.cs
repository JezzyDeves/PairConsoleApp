using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUI
{
    public class Encounters
    {
        bool levelOne = false;
        bool levelTwo = false;

        public string Input()
        {
            string userInput = Console.ReadLine();
            return userInput;
        }
        public void LevelSelect()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(@"   __                __  ____    __        __ 
  / /  ___ _  _____ / / / __/__ / /__ ____/ /_
 / /__/ -_) |/ / -_) / _\ \/ -_) / -_) __/ __/
/____/\__/|___/\__/_/ /___/\__/_/\__/\__/\__/ 
                                              
");

            switch (levelOne)
            {
                case false:
                    Console.WriteLine("1) Panic at the Red Lobster");
                    break;
                case true:
                    Console.WriteLine("1) Completed");
                    break;
            }
            switch (levelTwo)
            {
                case false:
                    Console.WriteLine("2) Dodging Traffic");
                    break;
                case true:
                    Console.WriteLine("2) Completed");
                    break;
            }

            string input = Console.ReadLine();

            if (input == "1" && levelOne == false)
            {
                LevelOne_RedLobster();
            }
            else if(input == "2" && levelTwo == false)
            {
                LevelTwo_DodgingTraffic();
            }
            else
            {
                Console.WriteLine("Enter a valid level number");
                Console.WriteLine("Press any key to continue.......");
                Console.ReadKey();
                LevelSelect();
            }
        }
        public void LevelOne_RedLobster()
        {
            Console.Clear();
            bool isAlive = true;
            bool diningRoom = false;
            bool kitchen = false;
            bool pantry = false;

            while (isAlive)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sebastian finds himself in the midst of the greatest enemy of all sea life.\n" +
                    "The accursed Red Lobster.\n" +
                    "Sebastian knows he must complete his quest to find Philipsbane but it probably wouldn't hurt to save some of his fellow sea friends.\n" +
                    "...I mean he probably should save them cause like...he's the hero and all that.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press any key to continue.......");
                Console.Clear();

                bool inLevel = true;
                while (inLevel)
                {
                    if (diningRoom == true && kitchen == true && pantry == true)
                    {
                        levelOne = true;
                        Console.WriteLine("You win the level!");
                        Console.ReadKey();
                        LevelSelect();
                        break;
                    }
                    Console.WriteLine("1) Go to the Dining Area\n" +
                        "2) Go to the Kitchen\n" +
                        "3) Go to the Pantry");

                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Sebastian finds himself in the Dining Area hoping he isn't on the menu\n" +
                                "Customers are eating all his friends!\n" +
                                "What ever is he to do?");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();

                            Console.WriteLine("1) Attack the customers\n" +
                                "2) Debate the ethics of their food choice\n" +
                                "3) Be a crab");
                            switch (Input())
                            {
                                case "1":
                                    Console.WriteLine("You attack the customers\n" +
                                        "A shocked customer steps on you!");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("---YOU DIED---");
                                    inLevel = false;
                                    isAlive = false;
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.WriteLine("Sebastian suggests that they eat shrimp instead");
                                    diningRoom = true;
                                    Console.WriteLine("Dining Room complete!");
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    Console.WriteLine("Poor Sebastian!");
                                    inLevel = false;
                                    isAlive = false;
                                    Console.ReadKey();
                                    break;

                            }
                            break;
                        case "2":
                            Console.WriteLine("After escaping the Dining Room, Sebastian now finds himself in the kitchen\n" +
                                "Can he dodge the chef?");
                            Console.WriteLine("1) Hide in the cabinet\n" +
                                "2) Try to run past the chef\n" +
                                "3) Run to another area");
                            switch (Input())
                            {
                                case "1":
                                    Console.WriteLine("Sebastian sees an open cabinet to hide inside.");
                                    kitchen = true;
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.WriteLine("You got caught!");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("---YOU DIED---");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    inLevel = false;
                                    isAlive = false;
                                    break;
                                case "3":
                                    break;
                            }
                            break;
                        case "3":
                            Console.WriteLine("Sebastian makes his way to the pantry and sees his crab buddies trapped in a jar");
                            Console.WriteLine("1) Eat some crab food\n" +
                                "2) Try to free your buddies\n" +
                                "3) Hide");
                            switch (Input())
                            {
                                case "1":
                                    Console.WriteLine("Sebastian eats some crab food.\n" +
                                        "While he is distracted eating his friends get cooked!");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("---YOU FAILED TO HELP YOUR FRIENDS!---");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    inLevel = false;
                                    isAlive = false;
                                    break;
                                case "2":
                                    Console.WriteLine("You free your buddies");
                                    pantry = true;
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    Console.WriteLine("You hide...and your friends get cooked. You coward!!!");
                                    inLevel = false;
                                    isAlive = false;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("---YOU FAILED TO HELP YOUR FRIENDS!---");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Select a valid menu option");
                            break;
                    }
                }
            }

            Console.WriteLine("Press any key to continue........");
            Console.ReadKey();
            LevelSelect();
        }
        public void LevelTwo_DodgingTraffic()
        {
            Console.Clear();
            bool isAlive = true;
            bool hitByCar = false;
            bool manHole = false;
            bool stepOn = false;

            while (isAlive)
            {

                Console.WriteLine("Sebastian has now found himself in the city and has to navigate the busy streets\n" +
                "Can you help Sebastian dodge traffic?");

                Console.WriteLine("1) Busy street\n" +
                    "2) Construction Zone \n" +
                    "3) Sidewalk");

                switch (Input())
                {
                    case "1":
                        Console.WriteLine("Sebastian has to dodge all of the traffic...will he make it?");
                        break;
                    case "2":
                        Console.WriteLine("Can he manage to not fall into a man hole in the construction zone?");
                        break;
                    case "3":
                        Console.WriteLine("");
                        break;
                }
            }
        }

    }
}
