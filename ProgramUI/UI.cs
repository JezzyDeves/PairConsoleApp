using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUI
{
    public class UI
    {
        public void Run()
        {
            Console.Clear();

            Console.WriteLine(@"  ___         _                  _     _                    ___                      _   
 / __|  ___  | |__   __ _   ___ | |_  (_)  __ _   _ _      / _ \   _  _   ___   ___ | |_ 
 \__ \ / -_) | '_ \ / _` | (_-< |  _| | | / _` | | ' \    | (_) | | || | / -_) (_-< |  _|
 |___/ \___| |_.__/ \__,_| /__/  \__| |_| \__,_| |_||_|    \__\_\  \_,_| \___| /__/  \__|
                                                                                         ");

            Console.WriteLine("Press any key to begin!");
            Console.ReadKey();

            OpeningScene();
        }

        public void OpeningScene()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("This is a story about a crab named Sebastian on a quest to get the legendary screwdriver Philipsbane.");
            Console.WriteLine("Can you help him navigate the trials ahead or will you be his doom?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();

            Encounters encounters = new Encounters();
            encounters.LevelSelect();
        }
    }
}
