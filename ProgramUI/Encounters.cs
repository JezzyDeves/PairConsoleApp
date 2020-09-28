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

            string input = Console.ReadLine();

            if(input == "1" && levelOne == false)
            {
                LevelOne_RedLobster();
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
                            Console.WriteLine("After escaping the Dining Room, Sebastian now finds himself in the kitchen\n"+
                                "Can he dodge the chef?");
                            Console.WriteLine("1) Hide in the cabinet\n" +
                                "2) Caught by Chef\n" +
                                "3) Run to another area");
                            switch (Input())
                            {
                                case "1":
                                    Console.WriteLine("Sebastian sees an open cabinet to hide inside.");
                                    kitchen = true;
                                    Console.ReadKey();
                                    break;
                            }
                            break;
                        case "3":
                            break;
                        default:
                            Console.WriteLine("Select a valid menu option");
                            break;
                    }
                }
            }

            Console.WriteLine("You are dead try again!");
            Console.ReadKey();
            LevelSelect();
        }
        

    }
}
