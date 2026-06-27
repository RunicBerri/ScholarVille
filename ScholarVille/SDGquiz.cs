using ScholarVille;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class SDGquiz
{
    //needs better ui
    //tweak to my liking
    //use same logic from real or fake

    int sdgScore = 0;
    static List<string> Users = new List<string>();
    Random rnd = new Random();
    static ASCII ascii = new ASCII();
    List<SDGQuestion> questions = new List<SDGQuestion>()
    {
        new SDGQuestion("Which SDG aims to end poverty?", "a", new string[]{"" +
            "A. SDG 1: No Poverty",
            "B. SDG 2: Zero Hunger",
            "C. SDG 4: Quality Education"}
            ),
        new SDGQuestion("Which SDG aims to end hunger?", "b", new string[]{
            "A. SDG 3: Good Health and Well-Being",
            "B. SDG 2: Zero Hunger",
            "C. SDG 13: Climate Action" }),
        new SDGQuestion("Which SDG focuses on health?", "c",new string[]{
            "A. SDG 14: Life Below Water",
            "B. SDG 9: Industry, Innovation and Infrastructure",
            "C. SDG 3: Good Health and Well-Being"}),
        new SDGQuestion("Which SDG promotes education for all?", "a",new string[]{
            "A. SDG 4: Quality Education",
            "B. SDG 5: Gender Equality",
            "C. SDG 10: Reduced Inequalities"}),
        new SDGQuestion("Which SDG promotes equal rights for women and men?", "b",new string[]{
            "A. SDG 16: Peace, Justice and Strong Institutions",
            "B. SDG 5: Gender Equality",
            "C. SDG 7: Affordable and Clean Energy"}),
        new SDGQuestion("Which SDG focuses on access to clean water?", "c",new string[]{
            "A. SDG 13: Climate Action",
            "B. SDG 11: Sustainable Cities and Communities",
            "C. SDG 6: Clean Water and Sanitation"}),
        new SDGQuestion("Which SDG promotes renewable energy?", "a",new string[]{
            "A. SDG 7: Affordable and Clean Energy",
            "B. SDG 12: Responsible Consumption and Production",
            "C. SDG 17: Partnerships for the Goals"}),
        new SDGQuestion("Which SDG focuses on decent jobs and economic growth?", "b", new string[]{
            "A. SDG 1: No Poverty",
            "B. SDG 8: Decent Work and Economic Growth",
            "C. SDG 15: Life on Land"}),
        new SDGQuestion("Which SDG promotes innovation and infrastructure?", "c", new string[]{
            "A. SDG 10: Reduced Inequalities",
            "B. SDG 13: Climate Action",
            "C. SDG 9: Industry, Innovation and Infrastructure"}),
        new SDGQuestion("Which SDG aims to reduce inequality?", "a", new string[]{
            "A. SDG 10: Reduced Inequalities",
            "B. SDG 2: Zero Hunger",
            "C. SDG 6: Clean Water and Sanitation"}),
        new SDGQuestion("Which SDG focuses on making cities safer and more sustainable?", "b", new string[]{
            "A. SDG 12: Responsible Consumption and Production",
            "B. SDG 11: Sustainable Cities and Communities",
            "C. SDG 14: Life Below Water"}),
        new SDGQuestion("Which SDG encourages responsible use of resources?", "c", new string[]{
            "A. SDG 16: Peace, Justice and Strong Institutions",
            "B. SDG 7: Affordable and Clean Energy",
            "C. SDG 12: Responsible Consumption and Production"}),
        new SDGQuestion("Which SDG focuses on fighting climate change?", "a", new string[]{
            "A. SDG 13: Climate Action",
            "B. SDG 15: Life on Land",
            "C. SDG 8: Decent Work and Economic Growth"}),
        new SDGQuestion("Which SDG protects oceans and marine life?", "b", new string[]{
            "A. SDG 15: Life on Land",
            "B. SDG 14: Life Below Water",
            "C. SDG 3: Good Health and Well-Being"}),
        new SDGQuestion("Which SDG protects forests and wildlife?", "c", new string[]{
            "A. SDG 17: Partnerships for the Goals",
            "B. SDG 11: Sustainable Cities and Communities",
            "C. SDG 15: Life on Land"}),
        new SDGQuestion("Which SDG promotes peace and justice?", "a", new string[]{
            "A. SDG 16: Peace, Justice and Strong Institutions",
            "B. SDG 1: No Poverty",
            "C. SDG 4: Quality Education"}),
        new SDGQuestion("Which SDG encourages countries to work together?", "b", new string[]{
            "A. SDG 9: Industry, Innovation and Infrastructure",
            "B. SDG 17: Partnerships for the Goals",
            "C. SDG 13: Climate Action" })
    };

    public void Start(string userName)
    {
        Console.Clear();
        Users = File.ReadAllLines("Users.txt").ToList();

        Console.WriteLine("_________________________________________________________________________________________");
        Console.WriteLine("|                                                                                       |");
        Console.WriteLine("|                                         SDG QUIZ                                      |");
        Console.WriteLine("|_______________________________________________________________________________________|");
        Console.WriteLine("|                                                                                       |");
        Console.WriteLine("|                                SDG 4 - Quality Education                              |");
        Console.WriteLine("|                  Test your knowledge of the Sustainable Development Goals             |");
        Console.WriteLine("|                and discover how you can help make the world a better place!           |");
        Console.WriteLine("|                                                                                       |");
        Console.WriteLine("|                                                                                       |");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("|                                Press \"X\" to leave the game.                           |");
        Console.ResetColor();
        Console.WriteLine("|                                   Press any key to start.                             |");
        Console.WriteLine("|_______________________________________________________________________________________|");
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();

        if (input == ConsoleKey.X)
        {
            Console.Clear();
            ascii.Returning();
            Thread.Sleep(1000);
            Console.Clear();
            return;
        }
        for (int i = 0; i < questions.Count; i++)
        {
            bool continueGame = AskQuestion(i);

            if (!continueGame)
            {
                Console.Clear();
                ascii.Returning();
                Thread.Sleep(1000);
                Console.Clear();
                return;
            }
        }
        ShowResults();
        UpdateInfo(userName, sdgScore);
        Restart(userName);
    }

    public class SDGQuestion
    {
        public string Question { get; set; }
        public string[] Choices { get; set; }
        public string CorrectAnswer { get; set; }

        public SDGQuestion(string question, string correctAnswer, string[] choices)
        {
            Question = question;
            CorrectAnswer = correctAnswer;
            Choices = choices; 
        }
    }

    private bool AskQuestion(int i)
    {
        
        var question = questions[i];
        while (true)
        {
            Console.WriteLine("_________________________________________________________________________________________");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine($"   {question.Question}");
            foreach (string choice in question.Choices)
            {
                Console.WriteLine($"   { choice}");
            }
            int color = rnd.Next(1, 4);
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
            }
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine($"|                                          Score: {sdgScore}                                    ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|                                Press \"X\" to leave the game.                           |");
            Console.ResetColor();
            string userAnswer = Console.ReadLine().ToLower();
            Console.ResetColor();
            if (userAnswer == "x")
            {
                return false;
            }

            else if (userAnswer != "a" &&
                userAnswer != "b" &&
                userAnswer != "c")
            {
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                             Please enter A, B, C, or X.                               |");
                Console.WriteLine("|                              Press any key to continue.                               |");
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ReadKey();
                Console.Clear();
                continue;
            }

            else if (userAnswer == question.CorrectAnswer)
            {
                sdgScore++;
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                          You're Correct! You earned a point!                          |");
                
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                    You're Wrong!                                      |");
                Console.ResetColor();
            }

            Console.WriteLine("|                              Press any key to continue.                               |");
            Console.WriteLine("|_______________________________________________________________________________________|");
            Console.ReadKey();
            Console.Clear();
            return true;
        }
    }

    private void ShowResults()
    {
        Console.WriteLine("_________________________________________________________________________________________");
        Console.WriteLine("|                                                                                       |");
        Console.WriteLine("|                                    FINAL RESULT                                       |");
        Console.WriteLine("|_______________________________________________________________________________________|");
        Console.WriteLine("|                                                                                       |");
        Console.WriteLine($"|                                   Final Score: {sdgScore}                                      |");
        Console.WriteLine("|                                                                                       |");
        Console.WriteLine("|            By learning about the SDGs, you've taken a step toward helping             |");
        Console.WriteLine("|                          build a better future for everyone!                          |");

        if (sdgScore == 17)
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                         Amazing! You have memorized every SDG!                        |");
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        else if (sdgScore == 16)
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                          Wow! You nearly got a perfect score!                         |");
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        else if (sdgScore >= 13)
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                           Great Job! You're know most SDGs!                           |");
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        else if (sdgScore >= 9)
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                        Nice Job! You're gettint the hang of it now!                   |");
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
        else
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                          It's alright! Just keep practicing!                          |");
            Console.WriteLine("|_______________________________________________________________________________________|");
        }
    }

    private void Restart(string userName)
    {
        while (true)
        {
            Console.WriteLine("_________________________________________________________________________________________");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                     Play Again?                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                     Enter (Y/N)                                       |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                sdgScore = 0;
                Start(userName);
            }
            else if (input == "n")
            {
                Console.Clear();
                ascii.Returning();
                Thread.Sleep(1000);
                Console.Clear();
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("_________________________________________________________________________________________");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                              Please enter valid option.                               |");
                Console.WriteLine("|                              Press any key to continue.                               |");
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

            }
        }
    }

    public void UpdateInfo(string userName, int sdgScore)
    {
        for (int i = 0; i < Users.Count; i++)
        {
            string[] parts = Users[i].Split(',');

            if (parts[1] == userName)
            {
                int oldScore = Convert.ToInt32(parts[9]);

                if (oldScore < sdgScore) 
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("_________________________________________________________________________________________");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                                 NEW HIGH SCORE ACHIEVED!                              |");
                    parts[9] = sdgScore.ToString();
                }
                Users[i] = string.Join(",", parts);

                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                              Press any key to continue.                               |");
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ReadKey();
                Console.ResetColor();
                Console.Clear();
                break;
            }
        }
        File.WriteAllLines("Users.txt", Users);
    }
}
