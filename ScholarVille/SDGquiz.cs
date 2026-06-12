using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

public class SDGquiz
{
    private int score = 0;

    public void Start(string username)
    {
        Console.Clear();

        Console.WriteLine("=================================");
        Console.WriteLine("          SDG QUIZ GAME");
        Console.WriteLine("=================================");

        AskQuestion("Which SDG aims to end poverty?", "A",
            "A. No Poverty",
            "B. Zero Hunger",
            "C. Quality Education");

        AskQuestion("Which SDG aims to end hunger?", "B",
            "A. Good Health and Well-Being",
            "B. Zero Hunger",
            "C. Climate Action");

        AskQuestion("Which SDG focuses on health?", "C",
            "A. Life Below Water",
            "B. Industry, Innovation and Infrastructure",
            "C. Good Health and Well-Being");

        AskQuestion("Which SDG promotes education for all?", "A",
            "A. Quality Education",
            "B. Gender Equality",
            "C. Reduced Inequalities");

        AskQuestion("Which SDG promotes equal rights for women and men?", "B",
            "A. Peace, Justice and Strong Institutions",
            "B. Gender Equality",
            "C. Affordable and Clean Energy");

        AskQuestion("Which SDG focuses on access to clean water?", "C",
            "A. Climate Action",
            "B. Sustainable Cities and Communities",
            "C. Clean Water and Sanitation");

        AskQuestion("Which SDG promotes renewable energy?", "A",
            "A. Affordable and Clean Energy",
            "B. Responsible Consumption and Production",
            "C. Partnerships for the Goals");

        AskQuestion("Which SDG focuses on decent jobs and economic growth?", "B",
            "A. No Poverty",
            "B. Decent Work and Economic Growth",
            "C. Life on Land");

        AskQuestion("Which SDG promotes innovation and infrastructure?", "C",
            "A. Reduced Inequalities",
            "B. Climate Action",
            "C. Industry, Innovation and Infrastructure");

        AskQuestion("Which SDG aims to reduce inequality?", "A",
            "A. Reduced Inequalities",
            "B. Zero Hunger",
            "C. Clean Water and Sanitation");

        AskQuestion("Which SDG focuses on making cities safer and more sustainable?", "B",
            "A. Responsible Consumption and Production",
            "B. Sustainable Cities and Communities",
            "C. Life Below Water");

        AskQuestion("Which SDG encourages responsible use of resources?", "C",
            "A. Peace, Justice and Strong Institutions",
            "B. Affordable and Clean Energy",
            "C. Responsible Consumption and Production");

        AskQuestion("Which SDG focuses on fighting climate change?", "A",
            "A. Climate Action",
            "B. Life on Land",
            "C. Decent Work and Economic Growth");

        AskQuestion("Which SDG protects oceans and marine life?", "B",
            "A. Life on Land",
            "B. Life Below Water",
            "C. Good Health and Well-Being");

        AskQuestion("Which SDG protects forests and wildlife?", "C",
            "A. Partnerships for the Goals",
            "B. Sustainable Cities and Communities",
            "C. Life on Land");

        AskQuestion("Which SDG promotes peace and justice?", "A",
            "A. Peace, Justice and Strong Institutions",
            "B. No Poverty",
            "C. Quality Education");

        AskQuestion("Which SDG encourages countries to work together?", "B",
            "A. Industry, Innovation and Infrastructure",
            "B. Partnerships for the Goals",
            "C. Climate Action");

        ShowResults();
    }

    private void AskQuestion(string question, string answer,
        string optionA, string optionB, string optionC)
    {
        Console.WriteLine("\n" + question);
        Console.WriteLine(optionA);
        Console.WriteLine(optionB);
        Console.WriteLine(optionC);

        Console.Write("\nAnswer: ");
        string userAnswer = Console.ReadLine().ToUpper();

        if (userAnswer == answer)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }

        Console.WriteLine("\nPress any key...");
        Console.ReadKey();
        Console.Clear();
    }

    private void ShowResults()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("            RESULTS");
        Console.WriteLine("=================================");

        Console.WriteLine($"Score: {score}/17");

        if (score >= 15)
            Console.WriteLine("SDG Master!");
        else if (score >= 10)
            Console.WriteLine("Great Job!");
        else if (score >= 5)
            Console.WriteLine("Keep Learning!");
        else
            Console.WriteLine("Try Again!");

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

}
