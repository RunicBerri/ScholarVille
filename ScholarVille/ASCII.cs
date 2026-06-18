using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarVille
{
    internal class ASCII
    {
        public void Scholarville() 
        {
            Console.ResetColor();
            Console.WriteLine("|                                                                                       |");
            Console.Write("|    "); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write(" █████╗ ████╗ ██╗ ██╗ █████╗ ██╗    ████╗ █████╗ ██╗   ██╗██╗██╗   ██╗   █████╗"); Console.ResetColor(); Console.Write("    | \n");
            Console.Write("|    "); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("██╔═══╝██╔═██╗██║ ██║██╔══██╗██║   ██╔═██╗██╔═██╗██║   ██║██║██║   ██║   ██╔══╝"); Console.ResetColor(); Console.Write("    | \n");
            Console.Write("|    "); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("╚████╗ ██║ ╚═╝██████║██║  ██║██║   ██████║█████╔╝██║   ██║██║██║   ██║   ████╗"); Console.ResetColor(); Console.Write("     | \n");
            Console.Write("|    "); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write(" ╚══██╗██  ██╗██╔═██║██║  ██║██║   ██╔═██║██╔═██╗╚██╗ ██╔╝██║██║   ██║   ██╔═╝"); Console.ResetColor(); Console.Write("     | \n");
            Console.Write("|    "); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("█████╔╝╚████╔╝██║ ██║╚█████╔╝█████╗██║ ██║██║ ██║ ╚████╔╝ ██║█████╗█████╗█████╗"); Console.ResetColor(); Console.Write("    | \n");
            Console.Write("|    "); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("╚════╝  ╚═══╝ ╚═╝ ╚═╝ ╚════╝ ╚════╝╚═╝ ╚═╝╚═╝ ╚═╝  ╚═══╝  ╚═╝╚════╝╚════╝╚════╝"); Console.ResetColor(); Console.Write("    | \n");
        }

        public void StartMenu() 
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");   
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                     [1] Login                                         |");
            Console.WriteLine("|                                     [2] Register                                      |");
            Console.WriteLine("|                                     [3] Exit                                          |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
        }
        public void MainMenu()
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                              Welcome to ScholarVille!                                 |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                    [1] Play Games                                     |");
            Console.WriteLine("|                                    [2] My Scores                                      |");
            Console.WriteLine("|                                    [3] Achievements                                   |");
            Console.WriteLine("|                                    [4] My Collection                                  |");
            Console.WriteLine("|                                    [5] What are SDGs?                                 |");
            Console.WriteLine("|                                    [6] Logout                                         |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
        }
        public void GameMenu()
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                              Come and play while learning!                            |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                    [1] Eco Snake                                      |");
            Console.WriteLine("|                                    [2] News Detective                                 |");
            Console.WriteLine("|                                    [3] Grow a Tree                                    |");
            Console.WriteLine("|                                    [4] Sea Life Hero                                  |");
            Console.WriteLine("|                                    [5] SDG Quiz                                       |");
            Console.WriteLine("|                                    [6] Return                                         |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
        }

        public void Login() 
        {
            Console.WriteLine("                       ██╗      ██████╗  ██████╗ ██╗███╗   ██╗");
            Console.WriteLine("                       ██║     ██╔═══██╗██╔════╝ ██║████╗  ██║");
            Console.WriteLine("                       ██║     ██║   ██║██║  ███╗██║██╔██╗ ██║");
            Console.WriteLine("                       ██║     ██║   ██║██║   ██║██║██║╚██╗██║");
            Console.WriteLine("                       ███████╗╚██████╔╝╚██████╔╝██║██║ ╚████║");
            Console.WriteLine("                       ╚══════╝ ╚═════╝  ╚═════╝ ╚═╝╚═╝  ╚═══╝");
        }

        public void Register() 
        {
            Console.WriteLine("             ██████╗ ███████╗ ██████╗ ██╗███████╗████████╗███████╗██████╗");
            Console.WriteLine("             ██╔══██╗██╔════╝██╔════╝ ██║██╔════╝╚══██╔══╝██╔════╝██╔══██╗");
            Console.WriteLine("             ██████╔╝█████╗  ██║  ███╗██║███████╗   ██║   █████╗  ██████╔╝");
            Console.WriteLine("             ██╔══██╗██╔══╝  ██║   ██║██║╚════██║   ██║   ██╔══╝  ██╔══██╗");
            Console.WriteLine("             ██║  ██║███████╗╚██████╔╝██║███████║   ██║   ███████╗██║  ██║");
            Console.WriteLine("             ╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚═╝╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝");
        }

        public void Selected() 
        {
            Console.WriteLine("           ███████╗███████╗██╗     ███████╗ ██████╗████████╗███████╗██████╗");
            Console.WriteLine("           ██╔════╝██╔════╝██║     ██╔════╝██╔════╝╚══██╔══╝██╔════╝██╔══██╗");
            Console.WriteLine("           ███████╗█████╗  ██║     █████╗  ██║        ██║   █████╗  ██║  ██║");
            Console.WriteLine("           ╚════██║██╔══╝  ██║     ██╔══╝  ██║        ██║   ██╔══╝  ██║  ██║");
            Console.WriteLine("           ███████║███████╗███████╗███████╗╚██████╗   ██║   ███████╗██████╔╝");
            Console.WriteLine("           ╚══════╝╚══════╝╚══════╝╚══════╝ ╚═════╝   ╚═╝   ╚══════╝╚═════╝");
        }

        public void InvalidInput() 
        {
            //change
            Console.WriteLine("                   ██╗███╗   ██╗██╗   ██╗ █████╗ ██╗     ██╗██████╗");
            Console.WriteLine("                   ██║████╗  ██║██║   ██║██╔══██╗██║     ██║██╔══██╗");
            Console.WriteLine("                   ██║██╔██╗ ██║██║   ██║███████║██║     ██║██║  ██║");
            Console.WriteLine("                   ██║██║╚██╗██║╚██╗ ██╔╝██╔══██║██║     ██║██║  ██║");
            Console.WriteLine("                   ██║██║ ╚████║ ╚████╔╝ ██║  ██║███████╗██║██████╔╝");
            Console.WriteLine("                   ╚═╝╚═╝  ╚═══╝  ╚═══╝  ╚═╝  ╚═╝╚══════╝╚═╝╚═════╝");

            Console.WriteLine("                        ██╗███╗   ██╗██████╗ ██╗   ██╗████████╗");
            Console.WriteLine("                        ██║████╗  ██║██╔══██╗██║   ██║╚══██╔══╝");
            Console.WriteLine("                        ██║██╔██╗ ██║██████╔╝██║   ██║   ██║");
            Console.WriteLine("                        ██║██║╚██╗██║██╔═══╝ ██║   ██║   ██║");
            Console.WriteLine("                        ██║██║ ╚████║██║     ╚██████╔╝   ██║");
            Console.WriteLine("                        ╚═╝╚═╝  ╚═══╝╚═╝      ╚═════╝    ╚═╝");
        }

        public void LogOut() 
        {
            //change
            Console.WriteLine("               ██╗      ██████╗  ██████╗  ██████╗ ██╗███╗   ██╗ ██████╗");
            Console.WriteLine("               ██║     ██╔═══██╗██╔════╝ ██╔════╝ ██║████╗  ██║██╔════╝");
            Console.WriteLine("               ██║     ██║   ██║██║  ███╗██║  ███╗██║██╔██╗ ██║██║  ███╗");
            Console.WriteLine("               ██║     ██║   ██║██║   ██║██║   ██║██║██║╚██╗██║██║   ██║");
            Console.WriteLine("               ███████╗╚██████╔╝╚██████╔╝╚██████╔╝██║██║ ╚████║╚██████╔╝");
            Console.WriteLine("               ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝ ╚═╝╚═╝  ╚═══╝ ╚═════╝");

            Console.WriteLine("                              ██████╗ ██╗   ██╗████████╗");
            Console.WriteLine("                             ██╔═══██╗██║   ██║╚══██╔══╝");
            Console.WriteLine("                             ██║   ██║██║   ██║   ██║");
            Console.WriteLine("                             ██║   ██║██║   ██║   ██║");
            Console.WriteLine("                             ╚██████╔╝╚██████╔╝   ██║");
            Console.WriteLine("                              ╚═════╝  ╚═════╝    ╚═╝");
        }
    }
}
