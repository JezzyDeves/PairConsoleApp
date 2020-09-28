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

            Console.WriteLine("---------------");
            Console.WriteLine("|  Adventure  |");
            Console.WriteLine("---------------");

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
        }
    }
}
