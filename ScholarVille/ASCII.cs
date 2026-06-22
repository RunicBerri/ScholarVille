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
            Console.WriteLine("|                                   [1] Play Games                                      |");
            Console.WriteLine("|                                   [2] My Scores                                       |");
            Console.WriteLine("|                                   [3] Achievements                                    |");
            Console.WriteLine("|                                   [4] My Collection                                   |");
            Console.WriteLine("|                                   [5] What are SDGs?                                  |");
            Console.WriteLine("|                                   [6] Logout                                          |");
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
            Console.WriteLine("|                                   [1] Eco Snake                                       |");
            Console.WriteLine("|                                   [2] News Detective                                  |");
            Console.WriteLine("|                                   [3] Grow a Tree                                     |");
            Console.WriteLine("|                                   [4] Catch & Conserve                                |");
            Console.WriteLine("|                                   [5] SDG Quiz                                        |");
            Console.WriteLine("|                                   [6] Return                                          |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
        }
        public void Login() 
        {
            Console.ResetColor();
            Console.WriteLine("|                                                                                       |");
            Console.Write("|                         "); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("██╗      ██████╗  ██████╗ ██╗███╗   ██╗"); Console.ResetColor(); Console.Write("                       | \n");
            Console.Write("|                         "); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("██║     ██╔═══██╗██╔════╝ ██║████╗  ██║"); Console.ResetColor(); Console.Write("                       | \n");
            Console.Write("|                         "); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("██║     ██║   ██║██║  ███╗██║██╔██╗ ██║"); Console.ResetColor(); Console.Write("                       | \n");
            Console.Write("|                         "); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("██║     ██║   ██║██║   ██║██║██║╚██╗██║"); Console.ResetColor(); Console.Write("                       | \n");
            Console.Write("|                         "); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("███████╗╚██████╔╝╚██████╔╝██║██║ ╚████║"); Console.ResetColor(); Console.Write("                       | \n");
            Console.Write("|                         "); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("╚══════╝ ╚═════╝  ╚═════╝ ╚═╝╚═╝  ╚═══╝"); Console.ResetColor(); Console.Write("                       | \n");
        }
        public void LoginSelected() 
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                             __________________________                                |");
            Console.WriteLine("|                            |                           |                              |");
            Console.WriteLine("|                            |       Login Selected      |                              |");
            Console.WriteLine("|                            |                           |                              |");
            Console.WriteLine("|                             ---------------------------                               |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
        }
        public void Register()
        {
            Console.ResetColor();
            Console.WriteLine("|                                                                                       |");
            Console.Write("|             "); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("██████╗ ███████╗ ██████╗ ██╗███████╗████████╗███████╗██████╗"); Console.ResetColor(); Console.Write("              | \n");
            Console.Write("|             "); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("██╔══██╗██╔════╝██╔════╝ ██║██╔════╝╚══██╔══╝██╔════╝██╔══██╗"); Console.ResetColor(); Console.Write("             | \n");
            Console.Write("|             "); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("██████╔╝█████╗  ██║  ███╗██║███████╗   ██║   █████╗  ██████╔╝"); Console.ResetColor(); Console.Write("             | \n");
            Console.Write("|             "); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("██╔══██╗██╔══╝  ██║   ██║██║╚════██║   ██║   ██╔══╝  ██╔══██╗"); Console.ResetColor(); Console.Write("             | \n");
            Console.Write("|             "); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("██║  ██║███████╗╚██████╔╝██║███████║   ██║   ███████╗██║  ██║"); Console.ResetColor(); Console.Write("             | \n");
            Console.Write("|             "); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚═╝╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝"); Console.ResetColor(); Console.Write("             | \n");
        }
        public void RegisterSelected()
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                             __________________________                                |");
            Console.WriteLine("|                            |                           |                              |");
            Console.WriteLine("|                            |     Register Selected     |                              |");
            Console.WriteLine("|                            |                           |                              |");
            Console.WriteLine("|                             ---------------------------                               |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
        }
        public void RegisterSuccess()
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                             __________________________                                |");
            Console.WriteLine("|                            |                           |                              |");
            Console.WriteLine("|                            |    Register Successful!   |                              |");
            Console.WriteLine("|                            |                           |                              |");
            Console.WriteLine("|                             ---------------------------                               |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
        }
        public void InvalidInput() 
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                             __________________________                                |");
            Console.WriteLine("|                            |                           |                              |");
            Console.WriteLine("|                            |       Invalid Input.      |                              |");
            Console.WriteLine("|                            |      Please try again.    |                              |");
            Console.WriteLine("|                            |                           |                              |");
            Console.WriteLine("|                             ---------------------------                               |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
        }
        public void LogOut() 
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                             __________________________                                |");
            Console.WriteLine("|                            |                           |                              |");
            Console.WriteLine("|                            |        Logging Out.       |                              |");
            Console.WriteLine("|                            |                           |                              |");
            Console.WriteLine("|                             ---------------------------                               |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
        }

        public void Returning()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("_________________________________________________________________________________________");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                             __________________________                                |");
            Console.WriteLine("|                            |                           |                              |");
            Console.WriteLine("|                            |       Returning to        |                              |");
            Console.WriteLine("|                            |      Game Selection.      |                              |");
            Console.WriteLine("|                            |                           |                              |");
            Console.WriteLine("|                             ---------------------------                               |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|_______________________________________________________________________________________|");
            Console.ResetColor();
        }
        public void ReturningMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("_________________________________________________________________________________________");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                             __________________________                                |");
            Console.WriteLine("|                            |                           |                              |");
            Console.WriteLine("|                            |       Returning to        |                              |");
            Console.WriteLine("|                            |        Main Menu.         |                              |");
            Console.WriteLine("|                            |                           |                              |");
            Console.WriteLine("|                             ---------------------------                               |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|_______________________________________________________________________________________|");
            Console.ResetColor();
        }
        public void Achievement()
        {
            Console.WriteLine("_________________________________________________________________________________________");
            Console.WriteLine("|                                                                                       |");
            Console.Write("|"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write(" ████╗  █████╗██╗ ██╗██╗██████╗██╗  ██╗██████╗███╗   ███╗██████╗███╗   ██╗██████╗█████╗"); Console.ResetColor(); Console.Write("|\n");
            Console.Write("|"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("██╔═██╗██╔═══╝██║ ██║██║██╔═══╝██║  ██║██╔═══╝████╗ ████║██╔═══╝████╗  ██║╚═██╔═╝██╔══╝"); Console.ResetColor(); Console.Write("|\n");
            Console.Write("|"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("██████║██║    ██████║██║████╗  ██║  ██║████╗  ██╔████╔██║████╗  ██╔██╗ ██║  ██║  █████╗"); Console.ResetColor(); Console.Write("|\n");
            Console.Write("|"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("██╔═██║██║    ██╔═██║██║██╔═╝  ╚██╗██╔╝██╔═╝  ██║╚██╔╝██║██╔═╝  ██║╚██╗██║  ██║  ╚══██║"); Console.ResetColor(); Console.Write("|\n");
            Console.Write("|"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("██║ ██║╚█████╗██║ ██║██║██████╗ ╚███╔╝ ██████╗██║ ╚═╝ ██║██████╗██║ ╚████║  ██║  █████║"); Console.ResetColor(); Console.Write("|\n");
            Console.Write("|"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("╚═╝ ╚═╝ ╚════╝╚═╝ ╚═╝╚═╝╚═════╝  ╚══╝  ╚═════╝╚═╝     ╚═╝╚═════╝╚═╝  ╚═══╝  ╚═╝  ╚════╝"); Console.ResetColor(); Console.Write("|\n");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
        }
        //eco snake
        public void trash1() 
        {
            
            Console.WriteLine("|                                 Beginner Trash Collector                              |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                           Collect a total of 20 pieces of trash.                      |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void trash2()
        {

            Console.WriteLine("|                                  Adept Trash Collector                                |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                           Collect a total of 70 pieces of trash.                      |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void trash3()
        {

            Console.WriteLine("|                                 Master Trash Collector                                |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                          Collect a total of 150 pieces of trash.                      |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        //rof
        public void rof1()
        {

            Console.WriteLine("|                                 Beginner News Detective                               |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                       Recognized a total of 15 real and fake news.                    |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void rof2()
        {

            Console.WriteLine("|                                  Adept News Detective                                 |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                       Recognized a total of 60 real and fake news.                    |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void rof3()
        {

            Console.WriteLine("|                                  Master News Detective                                |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                       Recognized a total of 120 real and fake news.                   |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        //treePlanter
        public void treeP1()
        {

            Console.WriteLine("|                                  Beginner Tree Planter                                |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                Plant a total of 3 trees.                              |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void treeP2() 
        {

            Console.WriteLine("|                                   Adept Tree Planter                                  |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                Plant a total of 15 trees.                             |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void treeP3()
        {

            Console.WriteLine("|                                  Master Tree Planter                                  |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                               Plant a total of 30 trees.                              |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void treeC1()
        {

            Console.WriteLine("|                                 Beginner Tree Collector                               |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                              Collect a total of 1 unique tree.                        |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void treeC2()
        {

            Console.WriteLine("|                                   Adept Tree Collector                                |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                              Collect a total of 3 unique tree.                        |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void treeC3()
        {

            Console.WriteLine("|                                  Master Tree Collector                                |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                              Collect a total of 5 unique tree.                        |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        //Fishing
        public void Fishcaught1()
        {

            Console.WriteLine("|                                  Beginner Fisherman                                   |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                               Catch a total of 15 fish.                               |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void Fishcaught2()
        {

            Console.WriteLine("|                                    Adept Fisherman                                    |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                               Catch a total of 60 fish.                               |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void Fishcaught3()
        {

            Console.WriteLine("|                                    Master Fisherman                                   |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                               Catch a total of 120 fish.                              |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void FishCollect1()
        {
            Console.WriteLine("|                               Beginner Fish Collector                                 |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                           Collect a total of 1 unique fish.                           |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void FishCollect2()
        {
            Console.WriteLine("|                               Beginner Fish Collector                                 |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                           Collect a total of 3 unique fish.                           |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void FishCollect3()
        {
            Console.WriteLine("|                               Beginner Fish Collector                                 |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                           Collect a total of 5 unique fish.                           |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        //sdg quiz
        public void sdgScore1()
        {

            Console.WriteLine("|                                 Beginner SDG Learner                                  |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                               Achieve a high score of 10.                             |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void sdgScore2()
        {

            Console.WriteLine("|                                   Adept SDG Learner                                   |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                               Achieve a high score of 14.                             |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void sdgScore3()
        {

            Console.WriteLine("|                                  Master SDG Learner                                   |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                               Achieve a high score of 17.                             |");
            Console.ResetColor();
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void myScore()
        {
            Console.WriteLine("_________________________________________________________________________________________");
            Console.WriteLine("|                                                                                       |");
            Console.Write("|       "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("███╗   ███╗██╗   ██╗    ███████╗ ██████╗ ██████╗ ██████╗ ███████╗███████╗"); Console.ResetColor(); Console.Write("       |\n");
            Console.Write("|       "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("████╗ ████║╚██╗ ██╔╝    ██╔════╝██╔════╝██╔═══██╗██╔══██╗██╔════╝██╔════╝"); Console.ResetColor(); Console.Write("       |\n");
            Console.Write("|       "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("██╔████╔██║ ╚████╔╝     ███████╗██║     ██║   ██║██████╔╝█████╗  ███████╗"); Console.ResetColor(); Console.Write("       |\n");
            Console.Write("|       "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("██║╚██╔╝██║  ╚██╔╝      ╚════██║██║     ██║   ██║██╔══██╗██╔══╝  ╚════██║"); Console.ResetColor(); Console.Write("       |\n");
            Console.Write("|       "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("██║ ╚═╝ ██║   ██║       ███████║╚██████╗╚██████╔╝██║  ██║███████╗███████║"); Console.ResetColor(); Console.Write("       |\n");
            Console.Write("|       "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("╚═╝     ╚═╝   ╚═╝       ╚══════╝ ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚══════╝╚══════╝"); Console.ResetColor(); Console.Write("       |\n");
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void Collection() 
        {
            Console.WriteLine("_________________________________________________________________________________________");
            Console.WriteLine("|                                                                                       |");
            Console.Write("|    "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write(" ██████╗ ██████╗ ██╗     ██╗     ███████╗ ██████╗████████╗██╗ ██████╗ ███╗   ██╗"); Console.ResetColor(); Console.Write("   |\n");
            Console.Write("|    "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("██╔════╝██╔═══██╗██║     ██║     ██╔════╝██╔════╝╚══██╔══╝██║██╔═══██╗████╗  ██║"); Console.ResetColor(); Console.Write("   |\n");
            Console.Write("|    "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("██║     ██║   ██║██║     ██║     █████╗  ██║        ██║   ██║██║   ██║██╔██╗ ██║"); Console.ResetColor(); Console.Write("   |\n");
            Console.Write("|    "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("██║     ██║   ██║██║     ██║     ██╔══╝  ██║        ██║   ██║██║   ██║██║╚██╗██║"); Console.ResetColor(); Console.Write("   |\n");
            Console.Write("|    "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("╚██████╗╚██████╔╝███████╗███████╗███████╗╚██████╗   ██║   ██║╚██████╔╝██║ ╚████║"); Console.ResetColor(); Console.Write("   |\n");
            Console.Write("|    "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write(" ╚═════╝ ╚═════╝ ╚══════╝╚══════╝╚══════╝ ╚═════╝   ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝"); Console.ResetColor(); Console.Write("   |\n");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
        }
        //user collection
        public void PineArt() 
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                           ST                                          |" +
                          "\r\n|                                          SUVSW                                        |" +
                          "\r\n|                                        YSVWWVVRZ                                      |" +
                          "\r\n|                                     USSTVWWWWWVUSSW                                   |" +
                          "\r\n|                                      YRUQJUSTQRVR                                     |" +
                          "\r\n|                                      QSSSSPSTSTSRT                                    |" +
                          "\r\n|                                   YRTTUUVUUUUVUUTTSPO                                 |" +
                          "\r\n|                                   SNMQTROTQKQTOLQLPR                                  |" +
                          "\r\n|                                   ROLNROKNQRRMNORSSQO                                 |" +
                          "\r\n|                                 VOSSSSSSSSTTSSSSSTTSRQMZ                              |" +
                          "\r\n|                                 UMJLSRKQROPSQLSRJRSNLQ                                |" +
                          "\r\n|                                 POLLNMMNMONKLNLLMONNNNM                               |" +
                          "\r\n|                               ROQQPQQQQQQQPOPQQQQQQKQQPONQ                            |" +
                          "\r\n|                               VKJIONJNPLQPMOPMPOHMNLIJKLWZ                            |" +
                          "\r\n|                               MMLKMLIIJIJJKIMIKIJLLJJNNMJS                            |" +
                          "\r\n|                           UNKNMNNOOONNNLMMMMMMMMMMMNNNLMLLKH                          |" +
                          "\r\n|                            UQRQMLLMJNNKLMKKMIJMLJJKFLJKO                              |" +
                          "\r\n|                                   QNU YWOKLLHJ RNZ                                    |" +
                          "\r\n|                                         QMOOOL                                        |" +
                          "\r\n|                                         NMNOPMZ                                       |" +
                          "\r\n|                                       LNQIMNMPPP                                      |");
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void OakArt()
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                       SMMMLPNM                                        |" +
                          "\r\n|                                   WNMLMMKLMMMMLWWX                                    |" +
                          "\r\n|                                  XLMMMKKMMKKKMMMMLP                                   |" +
                          "\r\n|                               SLSKLKMLMMMMMMMIKMMMIXUX                                |" +
                          "\r\n|                              QMMMMMMJJMMMMMMMMLJMMLMMMQ                               |" +
                          "\r\n|                             YKMMLLMLLMMMMMMMMMMKMMMMMML                               |" +
                          "\r\n|                            MMMLLMMJJLMMKKMMMLKMMLKIMILMMQ                             |" +
                          "\r\n|                            LKILMMMMMLMMKMMMMMMKIMMMMMJLKL                             |" +
                          "\r\n|                          XMMMMMMMMMMMMKMMMMMMMLKMMMMMMMMMMY                           |" +
                          "\r\n|                           RLMJMMMMJMMMMJFGFIJMMMMLMMMMJMMN                            |" +
                          "\r\n|                             LMMMMMLHEIIPNFFGMIIHHMMMMMMJ                              |" +
                          "\r\n|                              SLIIIIHGHKOZOJLKGFFHIIJKLMW                              |" +
                          "\r\n|                                WRSXOU   LOJI   MJSJKO                                 |" +
                          "\r\n|                                          MHS                                          |" +
                          "\r\n|                                         ZNHT                                          |" +
                          "\r\n|                                         TOHO                                          |" +
                          "\r\n|                                         PMHH                                          |" +
                          "\r\n|                                       ZRQKHKMY                                        |");
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void NarraArt()
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                       YTYYX                                           |" +
                          "\r\n|                              Y     WTSTSUTUUQU   Z                                    |" +
                          "\r\n|                             TUWVUUPPRQRQRTSPMLTTUTTVZ                                 |" +
                          "\r\n|                        VUWYSQVVVUROKHKJIHJKHGIKNOONNW                                 |" +
                          "\r\n|                         VRRMONQPQMKKOOOSTOLIHMSUTUTTPOW                               |" +
                          "\r\n|                        XWVTPMJIKGIKSUSUVRNRMJKMRRUTQOOR                               |" +
                          "\r\n|                      QQRVUTSSLIGFFGKLIJIIGGLRPOLNSSSRT                                |" +
                          "\r\n|                     QJJLOMNNKJKHLRRSTTTVSQMHGIJNRQTVUUVRU                             |" +
                          "\r\n|                       MIHJFIJMOTRVQRPTQRPTOSIIQHKNLMQURLMS                            |" +
                          "\r\n|                     TQRQKMIFFJJMMNMNPKJKPQPPKOQOIGHHKKKLJQ                            |" +
                          "\r\n|                     YNMLLMIIFEHIIHIJIGHFHLKFHJHJMSQJIJLNOX                            |" +
                          "\r\n|                        WVJJKJHIJIKHFFEEDFEEFFIJIKKOQVT                                |" +
                          "\r\n|                                 Z    IFFEEL                                           |" +
                          "\r\n|                                       KGGFX                                           |" +
                          "\r\n|                                      MIHGU                                            | " +
                          "\r\n|                                      UJJHHM                                           |" +
                          "\r\n|                                   XPLMJIMPOOQ                                         |");
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void BirchArt()
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                    ZVSUUSVW                                           |" +
                          "\r\n|                                   QTUUPRRUUUS                                         |" +
                          "\r\n|                                SMOUTUSOTPQURMSS                                       |" +
                          "\r\n|                              NPPOMUSSTQRUUROOPPO                                      |" +
                          "\r\n|                            YPPPPPLNORMMROMMKNPPNNQZ                                   |" +
                          "\r\n|                             NLMPPPPNMMVUOMLLLLMNPPY                                   |" +
                          "\r\n|                              XKLLKJKLMWSLLJJHMPPK                                     |" +
                          "\r\n|                                   XWSXZXVOQOSTW                                       |" +
                          "\r\n|                                      UW UY                                            |" +
                          "\r\n|                                      ZZX                                              |" +
                          "\r\n|                                      WW                                               |" +
                          "\r\n|                                      YZZZ                                             |" +
                          "\r\n|                                      WZ                                               |" +
                          "\r\n|                                      W Z                                              |" +
                          "\r\n|                                      UW                                               |" +
                          "\r\n|                                      TZZZ                                             |" +
                          "\r\n|                                      RZ                                               |" +
                          "\r\n|                                      STYY                                             |");
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void SakuraArt()
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                   ZZZ     ZZY                                         |" +
                          "\r\n|                                  YYYZZ ZZ   Z ZYY                                     |" +
                          "\r\n|                            XXXYYZ  Z ZZZ  ZZ Z  YY                                    |" +
                          "\r\n|                         ZYYZYYZZZ  ZY Z   ZZZZ  ZY                                    |" +
                          "\r\n|                        Z ZZZ   ZYYWYXZXZXXPOWXYZYYZ                                   |" +
                          "\r\n|                         ZWWXXY   Z  Z XZ   ZZZQYZ                                     |" +
                          "\r\n|                            YXYYZYYXXXWXXSYYX   ZXXZZ                                  |" +
                          "\r\n|                              YZ ZZ   XKKXUQWU Z   ZWVXZ                               |" +
                          "\r\n|                               YYYYYYZYTPNUY Z YYZYYZ                                  |" +
                          "\r\n|                                  ZZYYUJM   ZZYXYXZ                                    |" +
                          "\r\n|                                      NK                                               |" +
                          "\r\n|                                      JL                                               |" +
                          "\r\n|                                      JM                                               |" +
                          "\r\n|                                      JL                                               |" +
                          "\r\n|                                      KKZ                                              |" +
                          "\r\n|                                      MJV                                              |");
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void TilapiaArt() 
        {

            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                              ██                                       |" +
                          "\r\n|                                          ████ ██                                      |" +
                          "\r\n|                                        ███████ ███                                    |" +
                          "\r\n|                                      ███    █ █ ███      █████                        |" +
                          "\r\n|                                   ██     █     █  ██   ███  █                         |" +
                          "\r\n|                                 ███ ██    █  █  █   ████ █ █                          |" +
                          "\r\n|                                 █         █    █       █   █                          |" +
                          "\r\n|                                 ███      █ ██████   ██████  █                         |" +
                          "\r\n|                                   ███  ██  ██  █  ███   ██████                        |" +
                          "\r\n|                                      █████   ██ █████                                 |" +
                          "\r\n|                                           ███ ██                                      |" +
                          "\r\n|                                             ██ █                                      |" +
                          "\r\n|                                               █                                       |");
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void MilkfishArt()
        {

            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                █                                      |" +
                          "\r\n|                                               █ █                                     |" +
                          "\r\n|                                            ██   ██                                    |" +
                          "\r\n|              ██                          █        █                                   |" +
                          "\r\n|                 ██                    ███ █████████████████████                       |" +
                          "\r\n|               ██ █ █        █    ████████████████████████ ███████████                 |" +
                          "\r\n|                ██    █   ████████████████████████      ████     █  █ █ ██             |" +
                          "\r\n|                 █ ██████████                      ████      █   ████   █              |" +
                          "\r\n|                ██   ███████            ████████ ███   ███ █ █ █     ████              |" +
                          "\r\n|               █   █ █        ██████                        █    █████                 |" +
                          "\r\n|                █ ██            █ ███   ██████████████████████                         |" +
                          "\r\n|              ███                         █                                            |");
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void CatfishArt() 
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                        ████  █                                        |" +
                          "\r\n|                          ██████████████████████                       ███             |" +
                          "\r\n|                    ██████   ██            ███                     ████ █              |" +
                          "\r\n|                    █  █ ███ █ ███             ███████    ████   ████  ██              |" +
                          "\r\n|                  ████████   █          ██████        █████  ███████ ██                |" +
                          "\r\n|                ███      ████████ ████   █  ████████████████████   █ █                 |" +
                          "\r\n|              █  █        █   █       ██                           █ █                 |" +
                          "\r\n|                 █    ███  █   ██       ██████████           █  ████ ██                |" +
                          "\r\n|                ██      ████     ██    ███   █   █         ████   ███ ██               |" +
                          "\r\n|                █          █ ███████      ███      ██ ██ ██████     █████              |" +
                          "\r\n|                           █       ███████  ███████   █      █         ██              |");
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void TunaArt()
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                         ██                                            |" +
                          "\r\n|                                     ███                                               |" +
                          "\r\n|                                   █ ██                                                |" +
                          "\r\n|                                   █   █                                               |" +
                          "\r\n|                                  █ █████                              ███             |" +
                          "\r\n|                          █████           ███    ███                ██ █               |" +
                          "\r\n|                      █████████████████████  █ ████  █            ██  █                |" +
                          "\r\n|                   █████████████████████████████     ██         ██   █                 |" +
                          "\r\n|                ████                        █████████  ████    ██   █                  |" +
                          "\r\n|               █      ██      █          ██        █████████████   █                   |" +
                          "\r\n|                ███   ███          ██████                      ███ █                   |" +
                          "\r\n|               ██  ██           █████ █                     ████    █                  |" +
                          "\r\n|                 ██           █ █    █                  ████    █   ██                 |" +
                          "\r\n|                  ███       █   ████                 ██         ██  █                  |" +
                          "\r\n|                      ███ ██                      ██████           █  █                |" +
                          "\r\n|                          ████            ██████ ██ █                ████              |" +
                          "\r\n|                              █████ ████           ██                  █               |" +
                          "\r\n|                               ██  █                                                   |" +
                          "\r\n|                                ██ █                                                   |" +
                          "\r\n|                                 ███                                                   |" +
                          "\r\n|                                    █                                                  |");
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void GoldfishArt()
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                              ███████                                  |" +
                          "\r\n|                                             ████    █████                             |" +
                          "\r\n|                                          ███          ████ █                          |" +
                          "\r\n|                                       ███      █████████ █                            |" +
                          "\r\n|                                  ████     ████████████████                            |" +
                          "\r\n|                  ███████              █ ███                ██                         |" +
                          "\r\n|               ██    ██████████       ████ ████               ████                     |" +
                          "\r\n|                            █████    ███       █                 ████                  |" +
                          "\r\n|                            █  ███           █████    ██     █ ██                      |" +
                          "\r\n|                          █ ██ █ ███       ███    ███   ██ █   ██   ███   █            |" +
                          "\r\n|                         █ █ ███ ██████ ███   █ █  █  █     ██ █    ██    █            |" +
                          "\r\n|                          █ █ █████████ █ ██ ██ ██   ██ █  █   █          █            |" +
                          "\r\n|                                       ███    ██  ███   ██ █    █       ██             |" +
                          "\r\n|                           ██████  ████████████ ██   ███      █  ██  ███               |" +
                          "\r\n|                            ███  ████████      ██   █ █  █████ ██ ████                 |" +
                          "\r\n|                            ██   ██ █ ██        ███  ██ █      █████                   |" +
                          "\r\n|                           ██   ██ █ ███          ████ █ ██ ██   █                     |" +
                          "\r\n|                        ████  █ █ █ ██                ███████████                      |" +
                          "\r\n|              █    █████████  █ ███ ██  ██████████  ██      █████                      |" +
                          "\r\n|                █████████     █ ██ ███  █████    ████      ████                        |" +
                          "\r\n|                            █ █ ████          █████        ██                          |" +
                          "\r\n|                            █   ███       ██████         ███                           |" +
                          "\r\n|                               ███       ██             █                              |" +
                          "\r\n|                          █ █████                                                      |" +
                          "\r\n|                     █████████                                                         |");
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        public void SdgList() 
        {
            Console.WriteLine("_________________________________________________________________________________________");
            Console.WriteLine("|                                                                                       |");
            Console.Write("|                "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("███████╗██████╗  ██████╗     ██╗     ██╗███████╗████████╗"); Console.ResetColor(); Console.Write("              |\n");
            Console.Write("|                "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("██╔════╝██╔══██╗██╔════╝     ██║     ██║██╔════╝╚══██╔══╝"); Console.ResetColor(); Console.Write("              |\n");
            Console.Write("|                "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("███████╗██║  ██║██║  ███╗    ██║     ██║███████╗   ██║"); Console.ResetColor(); Console.Write("                 |\n");
            Console.Write("|                "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("╚════██║██║  ██║██║   ██║    ██║     ██║╚════██║   ██║"); Console.ResetColor(); Console.Write("                 |\n");
            Console.Write("|                "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("███████║██████╔╝╚██████╔╝    ███████╗██║███████║   ██║"); Console.ResetColor(); Console.Write("                 |\n");
            Console.Write("|                "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("╚══════╝╚═════╝  ╚═════╝     ╚══════╝╚═╝╚══════╝   ╚═╝"); Console.ResetColor(); Console.Write("                 |\n");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
        }

    }
}
