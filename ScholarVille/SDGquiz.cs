using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

public class SDGquiz
{
    //needs better ui
    //tweak to my liking
    //use same logic from real or fake

    int sdgScore = 0;
    static List<string> Users = new List<string>();
    List<SDGQuestion> questions = new List<SDGQuestion>()
    {
        new SDGQuestion("SDG 1: Which SDG aims to end poverty?", "a", new string[]{"A. No Poverty",
            "B. Zero Hunger",
            "C. Quality Education"}
            ),
        new SDGQuestion("SDG 2: Which SDG aims to end hunger?", "b", new string[]{
            "A. Good Health and Well-Being",
            "B. Zero Hunger",
            "C. Climate Action" }),
        new SDGQuestion("SDG 3: Which SDG focuses on health?", "c",new string[]{
            "A. Life Below Water",
            "B. Industry, Innovation and Infrastructure",
            "C. Good Health and Well-Being"}),
        new SDGQuestion("SDG 4: Which SDG promotes education for all?", "a",new string[]{
            "A. Quality Education",
            "B. Gender Equality",
            "C. Reduced Inequalities"}),
        new SDGQuestion("SDG 5: Which SDG promotes equal rights for women and men?", "b",new string[]{
            "A. Peace, Justice and Strong Institutions",
            "B. Gender Equality",
            "C. Affordable and Clean Energy"}),
        new SDGQuestion("SDG 6: Which SDG focuses on access to clean water?", "c",new string[]{
            "A. Climate Action",
            "B. Sustainable Cities and Communities",
            "C. Clean Water and Sanitation"}),
        new SDGQuestion("SDG 7: Which SDG promotes renewable energy?", "a",new string[]{
            "A. Affordable and Clean Energy",
            "B. Responsible Consumption and Production",
            "C. Partnerships for the Goals"}),
        new SDGQuestion("SDG 8: Which SDG focuses on decent jobs and economic growth?", "b", new string[]{
            "A. No Poverty",
            "B. Decent Work and Economic Growth",
            "C. Life on Land"}),
        new SDGQuestion("SDG 9: Which SDG promotes innovation and infrastructure?", "c", new string[]{
            "A. Reduced Inequalities",
            "B. Climate Action",
            "C. Industry, Innovation and Infrastructure"}),
        new SDGQuestion("SDG 10: Which SDG aims to reduce inequality?", "a", new string[]{
            "A. Reduced Inequalities",
            "B. Zero Hunger",
            "C. Clean Water and Sanitation"}),
        new SDGQuestion("SDG 11: Which SDG focuses on making cities safer and more sustainable?", "b", new string[]{
            "A. Responsible Consumption and Production",
            "B. Sustainable Cities and Communities",
            "C. Life Below Water"}),
        new SDGQuestion("SDG 12: Which SDG encourages responsible use of resources?", "c", new string[]{
            "A. Peace, Justice and Strong Institutions",
            "B. Affordable and Clean Energy",
            "C. Responsible Consumption and Production"}),
        new SDGQuestion("SDG 13: Which SDG focuses on fighting climate change?", "a", new string[]{
            "A. Climate Action",
            "B. Life on Land",
            "C. Decent Work and Economic Growth"}),
        new SDGQuestion("SDG 14: Which SDG protects oceans and marine life?", "b", new string[]{
            "A. Life on Land",
            "B. Life Below Water",
            "C. Good Health and Well-Being"}),
        new SDGQuestion("SDG 15: Which SDG protects forests and wildlife?", "c", new string[]{
            "A. Partnerships for the Goals",
            "B. Sustainable Cities and Communities",
            "C. Life on Land"}),
        new SDGQuestion("SDG 16: Which SDG promotes peace and justice?", "a", new string[]{
            "A. Peace, Justice and Strong Institutions",
            "B. No Poverty",
            "C. Quality Education"}),
        new SDGQuestion("SDG 17: Which SDG encourages countries to work together?", "b", new string[]{
            "A. Industry, Innovation and Infrastructure",
            "B. Partnerships for the Goals",
            "C. Climate Action" })
    };

    public void Start(string userName)
    {
        Console.Clear();
        Users = File.ReadAllLines("Users.txt").ToList();

        Console.WriteLine("=========================================================================================");
        Console.WriteLine("                                         SDG QUIZ");
        Console.WriteLine("=========================================================================================\n");
        Console.WriteLine("game desc.");
        Console.WriteLine("\n                                 Press \"X\" to leave the game.");
        Console.WriteLine("                                    Press any key to start.");
        string input1 = Console.ReadLine().ToLower();
        Console.Clear();
        if (input1 == "x")
        {
            Console.Clear();
            Console.WriteLine("Returning to Game Selection.");
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
                Console.WriteLine("Returning to Game Selection.");
                Thread.Sleep(1000);
                Console.Clear();
                return;
            }
        }
        ShowResults();
        UpdateInfo(userName, sdgScore);
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
            Console.WriteLine("=========================================================================================");
            Console.WriteLine(question.Question);
            foreach (string choice in question.Choices)
            {
                Console.WriteLine(choice);
            }
            Console.WriteLine("=========================================================================================");
            Console.WriteLine($"Current Score: {sdgScore}");
            Console.Write("\nAnswer: ");
            string userAnswer = Console.ReadLine().ToLower();

            if (userAnswer == "x")
            {
                return false;
            }

            else if (userAnswer != "a" &&
                userAnswer != "b" &&
                userAnswer != "c")
            {
                Console.WriteLine("\nPlease enter A, B, C, or X.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
                continue;
            }

            else if (userAnswer == question.CorrectAnswer)
            {
                sdgScore++;
                Console.WriteLine("\nYou're Correct! You earned a point!");
            }

            else
            {
                Console.WriteLine("\nYou're Wrong!");
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            return true;
        }
    }

    private void ShowResults()
    {
        Console.WriteLine("=========================================================================================");
        Console.WriteLine("                                          FINAL RESULT");
        Console.WriteLine("=========================================================================================");
        Console.WriteLine($"                                      Final Score: {sdgScore}");

        if (sdgScore == 17)
        {
            Console.WriteLine("Amazing! You have memorized every SDG!");
        }
        else if (sdgScore == 16)
        {
            Console.WriteLine("Wow! You nearly got a perfect score!");
        }
        else if (sdgScore >= 13)
        {
            Console.WriteLine("Great Job! You're know most SDGs!");
        }
        else if (sdgScore >= 9)
        {
            Console.WriteLine("Nice Job! You're gettint the hang of it now!");
        }
        else
        {
            Console.WriteLine("It's alright! Just keep practicing!");
        }
    }

    public void UpdateInfo(string userName, int sdgScore)
    {
        for (int i = 0; i < Users.Count; i++)
        {
            string[] parts = Users[i].Split(',');

            if (parts[1] == userName)
            {
                int oldScore = Convert.ToInt32(parts[8]);

                if (oldScore < sdgScore) 
                {
                    Console.WriteLine("=========================================================================================");
                    Console.WriteLine("                                      NEW HIGH SCORE ACHIEVED!");
                    Console.WriteLine("=========================================================================================");
                    parts[8] = sdgScore.ToString();
                }
                Users[i] = string.Join(",", parts);

                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
                Console.Clear();
                break;
            }
        }
        File.WriteAllLines("Users.txt", Users);
    }
}
