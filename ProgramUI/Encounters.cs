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
        bool levelThree = false;

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
            if(levelOne == true && levelTwo == true)
            {
                Console.WriteLine("3) The Toolshed");
            }

            string input = Console.ReadLine();

            if (input == "1" && levelOne == false)
            {
                LevelOne_RedLobster();
            }
            else if (input == "2" && levelTwo == false)
            {
                LevelTwo_DodgingTraffic();
            }
            else if (input == "3" && levelOne == true && levelTwo == true)
            {
                LevelThree_TheToolshed();
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
                                    Console.WriteLine("Kitchen Complete!");
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
                                    Console.WriteLine("Pantry Complete!");
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
            bool street = false;
            bool construction = false;
            bool sidewalk = false;
            
            while (isAlive)
            {
                if (street == true && construction == true && sidewalk == true)
                {
                    Console.WriteLine("Level Complete");
                    Console.WriteLine("Press any key to continue.......");
                    Console.ReadKey();
                    levelTwo = true;
                    LevelSelect();
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sebastian has now found himself in the city and has to navigate the busy streets\n" +
                "Can you help Sebastian dodge traffic?");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1) Busy street\n" +
                    "2) Construction Zone \n" +
                    "3) Sidewalk");

                switch (Input())
                {
                    case "1":
                        Console.WriteLine("Dodging cars on the busy streets...will he make it?");
                        Console.WriteLine("1) Run into oncoming traffic,\n" +
                                "2) Try to outrun the cars,\n" +
                                "3) Jump onto the sidewalk");
                        switch (Input())
                        {
                            case "1":
                                Console.WriteLine("You navigate through the cars and just barely make it. Whew!");
                                Console.WriteLine("Be careful!");
                                Console.WriteLine("Busy Street complete!");
                                street = true;
                                Console.ReadKey();
                                break;
                            case "2":
                                Console.WriteLine("Try to outrun the cars...better luck next time, lil guy!");
                                isAlive = false;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("---YOU DIED---");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case "3":
                                Console.WriteLine("Jump onto the sidewalk! You lucky crab, you!");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Can he manage to not fall into a man hole in the construction zone?");
                        Console.WriteLine("1) Try to jump over\n" +
                            "2) Falls into the hole\n" +
                            "3) Ask a worker for help");
                        switch (Input())
                        {
                            case "1":
                                Console.WriteLine("Sebastian just barely is unable to grab the ledge");
                                isAlive = false;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("---YOU DIED---");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case "2":
                                Console.WriteLine("Falls without warning!!!");
                                isAlive = false;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("---YOU DIED---");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case "3":
                                //Change text to update option.
                                Console.WriteLine("You get saved by a passerby!");
                                Console.WriteLine("Construction Zone complete!");
                                construction = true;
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("But, will he be safe on the busy sidewalks?");
                        Console.WriteLine("1) Weaves between the pedestrians,\n" +
                            "2) RUN!\n" +
                            "3) Ask someone for help");
                        switch (Input())
                        {
                            case "1":
                                Console.WriteLine("Sebastian navigates through the brisk walkers with ease!");
                                Console.WriteLine("Sidewalks complete!");
                                sidewalk = true;
                                Console.ReadKey();
                                break;
                            case "2":
                                Console.WriteLine("Sebastian grows weary and meets his demise!");
                                isAlive = false;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("---YOU DIED---");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case "3":
                                Console.WriteLine("Someone spots Sebastian and picks him up!");
                                isAlive = false;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("---YOU DIED---");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ReadKey();
                                break;
                        }
                        break;
                }
            }
            Console.WriteLine("Press any key to continue.......");
            Console.ReadKey();
            LevelSelect();
        }
        public void LevelThree_TheToolshed()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sebastian finds himself nearing the end of his journey. He has reached the Toolshed!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            bool isAlive = true;
            while (isAlive)
            {
                Console.WriteLine("1) Search the toolbox\n" +
                "2) Search the workshop\n" +
                "3) Search the saw table");
                if(Input() == "1")
                {
                    Console.WriteLine("Testing");
                    Console.ReadKey();
                }
            }
        }
    }
}