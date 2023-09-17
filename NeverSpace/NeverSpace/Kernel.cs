using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace NeverSpace
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("NeverDOS Cosmos Edition Runned Successfully.");
            Console.WriteLine("Important: This Is Not Affilated With Microsoft");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        protected override void Run()
        {
            string input = "";

            Console.Beep();
            while (true)
            {
                input = Console.ReadLine();
                HandleThisCommand(input);
            }
        }


        private void HandleThisCommand(string input) {
            string inputTheme = "";
            if (input == "help" || input == "h")
            {
                Console.WriteLine("help / h -- List Of Commands");
                Console.WriteLine("ver / v -- Version Of The OS");
                Console.WriteLine("echo / p -- echoes the command");
                Console.WriteLine("NeverOS / NOS -- Not Implemented");
                Console.WriteLine("time / t -- Shows The Current Time");
                Console.WriteLine("theme / th -- Change Text Theme");
                Console.WriteLine("beep / b -- Play The 'Beep' Sound");
                Console.WriteLine("shutdown / s -- Shut Down The Computer/VM");
                Console.WriteLine("reboot / r -- Restart The Computer/VM");
            }
            else if (input == "ver" || input == "v")
            {
                Console.WriteLine("NeverDOS Version 1.3 Public Pre-Alpha");
                Console.WriteLine("Made Using COSMOS User Kit");
                Console.WriteLine();
                Console.WriteLine("Started Development On 15.09.2023 (Probably)");
            }
            else if (input == "echo" || input == "p")
            {
                Console.WriteLine("Text To Echo");
                string echoinput = Console.ReadLine();
                Console.WriteLine(echoinput);
            }
            else if (input == "time" || input == "t")
            {
                Console.WriteLine("Current Time Is " + DateTime.Now.ToString("dd.MM.yyyy"));
            }
            else if (input == "NeverOS" || input == "NOS")
            {
                Console.WriteLine("Command Not Supported/Implemented");
            }
            else if (input == "theme" || input == "th")
            {
                Console.WriteLine("Choose Theme: Dark, Light, Blue, Dark Blue");
                inputTheme = Console.ReadLine();
                if (inputTheme == "Dark")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.BackgroundColor = ConsoleColor.Black;
                } else if (inputTheme == "Light")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Gray;
                } else if (inputTheme == "Dark Blue")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                } else if (inputTheme == "Blue")
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Black;
                } else
                {
                    Console.WriteLine("Theme Does Not Exist/Its Case Sensitive");
                }
            } else if (input == "beep" || input == "b")
            {
                Console.WriteLine("Playing The 'Beep' Sound");
                Console.Beep();
            } else if (input == "shutdown" || input == "s")
            {
                Cosmos.System.Power.Shutdown();
            } else if (input == "reboot" || input == "r")
            {
                Cosmos.System.Power.Reboot();
            }
            else
            {
                Console.WriteLine("Command Not Found, type 'help' for list of commands/Commands Are Case Sensitive.");
            }
        }

    }
}