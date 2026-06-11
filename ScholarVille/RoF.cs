using System;

public class RoF
{    
    private int score = 0;

    private string[] news =
    {
        "BREAKING: Evacuation center opened in Barangay Hall.",
        "URGENT: Send money to this number for relief goods donation.",
        "Weather Alert: Typhoon will make landfall tonight.",
        "FREE CASH assistance from unknown Facebook account, click link.",
        "LGU: Classes suspended tomorrow due to heavy rain forecast.",
        "Message: Share your OTP to receive disaster aid."
    };

    private bool[] isReal =
    {
        true,
        false,
        true,
        false,
        true,
        false
    };

    public void Start()
    {
        Console.WriteLine("====================================");
        Console.WriteLine(" FAKE NEWS CRISIS SIMULATOR PH");
        Console.WriteLine(" SDG 16 - Peace, Justice & Strong Institutions");
        Console.WriteLine("====================================\n");

        Console.WriteLine("Instructions:");
        Console.WriteLine("Type R = Real News");
        Console.WriteLine("Type F = Fake News\n");

        for (int i = 0; i < news.Length; i++)
        {
            AskQuestion(i);
        }

        ShowResults();
    }

    private void AskQuestion(int index)
    {
        Console.WriteLine("------------------------------------");
        Console.WriteLine("NEWS:");
        Console.WriteLine(news[index]);

        Console.Write("\nIs this REAL or FAKE? (R/F): ");
        string answer = Console.ReadLine().ToUpper();

        if ((answer == "R" && isReal[index]) ||
            (answer == "F" && !isReal[index]))
        {
            Console.WriteLine("✔ Correct! You helped stop misinformation.");
            score += 10;
        }
        else
        {
            Console.WriteLine("❌ Wrong! This affects public safety.");
            score -= 5;
        }

        Console.WriteLine($"Current Score: {score}\n");
    }

    private void ShowResults()
    {
        Console.WriteLine("====================================");
        Console.WriteLine(" FINAL RESULT");
        Console.WriteLine("====================================");
        Console.WriteLine($"Final Score: {score}");

        if (score >= 40)
        {
            Console.WriteLine("Excellent! You can detect fake news well.");
        }
        else if (score >= 20)
        {
            Console.WriteLine("Good awareness, but improve fact-checking.");
        }
        else
        {
            Console.WriteLine("High risk of misinformation influence.");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

