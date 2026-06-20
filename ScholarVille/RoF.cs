using ScholarVille;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class RoF
{
    //needs better ui

    int rofScore = 0;
    static List<string> Users = new List<string>();
    Random rnd = new Random();
    static ASCII ascii = new ASCII();
    List<NewsQuestion> questions = new List<NewsQuestion>()
    {
        new NewsQuestion("School Announcement: Classes are suspended tomorrow because of heavy rain.", true, "Official"),
        new NewsQuestion("Message: Share this post 20 times or bad luck will follow you for a year.", false, "Chain"),
        new NewsQuestion("Weather Alert: A typhoon is expected to arrive this weekend.", true, "Official"),
        new NewsQuestion("Post: Eating 10 candies every day makes you grow taller instantly.", false, "Impossible"),
        new NewsQuestion("Principal's Notice: Bring your ID during the school field trip.", true, "Official"),
        new NewsQuestion("Viral Post: Dinosaurs were found alive in a nearby city.", false, "Impossible"),
        new NewsQuestion("Library Announcement: New books are available for students to borrow.", true, "Official"),
        new NewsQuestion("Message: Click here to win a free gaming laptop.", false, "Giveaway"),
        new NewsQuestion("Barangay Notice: Free tree planting activity this Saturday.", true, "Official"),
        new NewsQuestion("Post: The moon will disappear forever next week.", false, "Impossible"),

        new NewsQuestion("School Nurse: Wash your hands before eating to stay healthy.", true, "Official"),
        new NewsQuestion("Message: A cartoon character is secretly living in your school.", false, "Impossible"),
        new NewsQuestion("PAGASA Alert: Strong winds are expected this afternoon.", true, "Official"),
        new NewsQuestion("Post: You can breathe underwater if you hold your breath long enough.", false, "Impossible"),
        new NewsQuestion("Teacher's Reminder: Submit your project on Friday.", true, "Official"),
        new NewsQuestion("Message: A dragon was seen flying over the city last night.", false, "Impossible"),
        new NewsQuestion("Health Advisory: Drink plenty of water during hot weather.", true, "Official"),
        new NewsQuestion("Post: All dogs can speak English at midnight.", false, "Impossible"),
        new NewsQuestion("School Notice: The sports festival starts next week.", true, "Official"),
        new NewsQuestion("Message: Forward this to 10 friends to get free Robux.", false, "Giveaway"),

        new NewsQuestion("Barangay Announcement: Community clean-up drive this Sunday.", true, "Official"),
        new NewsQuestion("Post: The Earth is actually shaped like a cube.", false, "Impossible"),
        new NewsQuestion("Weather Update: Thunderstorms may occur later today.", true, "Official"),
        new NewsQuestion("Message: A secret button on your phone gives unlimited money.", false, "Giveaway"),
        new NewsQuestion("School Advisory: Bring an umbrella because rain is expected.", true, "Official"),
        new NewsQuestion("Post: Sharks can live comfortably on trees.", false, "Impossible"),
        new NewsQuestion("Library Notice: Reading contest registration is now open.", true, "Official"),
        new NewsQuestion("Message: This magical sticker can charge your phone instantly.", false, "Giveaway"),
        new NewsQuestion("Health Tip: Fruits and vegetables help keep your body healthy.", true, "Official"),
        new NewsQuestion("Post: Drinking soda makes you invisible.", false, "Impossible"),

        new NewsQuestion("School Announcement: Fire drill scheduled this afternoon.", true, "Official"),
        new NewsQuestion("Message: A famous superhero will visit every school tomorrow.", false, "Impossible"),
        new NewsQuestion("Weather Advisory: Flooding is possible in low-lying areas.", true, "Official"),
        new NewsQuestion("Post: Cats can naturally fly if they flap their tails.", false, "Impossible"),
        new NewsQuestion("Teacher's Notice: Quiz moved to next Monday.", true, "Official"),
        new NewsQuestion("Message: Send your password to unlock a secret game level.", false, "Giveaway"),
        new NewsQuestion("Barangay Notice: Recycling bins have been placed near the park.", true, "Official"),
        new NewsQuestion("Post: The sun rises in the west every Sunday.", false, "Impossible"),
        new NewsQuestion("Health Center: Get enough sleep to stay healthy and focused.", true, "Official"),
        new NewsQuestion("Message: Everyone who shares this gets a free bicycle.", false, "Giveaway"),

        new NewsQuestion("School Notice: Parent-teacher meeting scheduled next week.", true, "Official"),
        new NewsQuestion("Post: Fish can survive for years without water.", false, "Impossible"),
        new NewsQuestion("Weather Alert: Stay indoors during lightning storms.", true, "Official"),
        new NewsQuestion("Message: This website can predict your future perfectly.", false, "Giveaway"),
        new NewsQuestion("Community Notice: Volunteers are planting trees in the park.", true, "Official")
    };

    public void Start(string userName)
    {
        Console.Clear();
        Users = File.ReadAllLines("Users.txt").ToList();

        Console.WriteLine("_________________________________________________________________________________________");
        Console.WriteLine("|                                                                                       |");
        Console.WriteLine("|                                     News Detective                                    |");
        Console.WriteLine("|_______________________________________________________________________________________|");
        Console.WriteLine("|                                                                                       |");
        Console.WriteLine("|                     SDG 16 - Peace, Justice & Strong Institutions                     |");
        Console.WriteLine("|     Put on your detective hat and uncover which stories are real and which are fake!  |");
        Console.WriteLine("|                                                                                       |");
        Console.WriteLine("|                                                                                       |");
        Console.WriteLine("|                                         Controls:                                     |");
        Console.WriteLine("|                                    Type R = Real News                                 |");
        Console.WriteLine("|                                    Type F = Fake News                                 |");
        Console.WriteLine("|                                Press \"X\" to leave the game.                           |");
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

        for (int i = 0; i < 5; i++)
        {
            bool continueGame = AskQuestion();

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
        UpdateInfo(userName, rofScore);
        Restart(userName);
    }

    public class NewsQuestion
    {
        public string Question { get; set; }
        public bool IsReal { get; set; }
        public string TipType { get; set; }

        public NewsQuestion(string question, bool isReal, string tipType)
        {
            Question = question;
            IsReal = isReal;
            TipType = tipType;
        }
    }

    private void ShowTip(string tipType)
    {
        switch (tipType)
        {
            case "Official":
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|            Tip: Official announcements from schools, weather agencies,  and           |");
                Console.WriteLine("|            community leaders are usually reliable.                                    |");
                break;

            case "Chain":
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                Tip: Messages asking you to share them are often fake.                 |");
                break;

            case "Giveaway":
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|          Tip: Be careful of posts promising free prizes, money, or game items.        |");
                break;

            case "Impossible":
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|          Tip: If something sounds impossible or magical, it is probably fake.         |");
                break;
        }
    }

    private bool AskQuestion()
    {
        int color = rnd.Next(1,6);
        var question = questions[rnd.Next(questions.Count)];
        while(true)
        {
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
            }
            
            Console.WriteLine("_________________________________________________________________________________________");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|  NEWS:                                                                                |");
            Console.WriteLine($"   {question.Question}");
            Console.WriteLine("|_______________________________________________________________________________________|");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine($"|                                   Current Score: {rofScore}                                    |");
            Console.WriteLine("|                               Is this REAL or FAKE? (R/F)                             |");
            Console.WriteLine("|                               Press \"X\" to leave the game.                            |");
            string answer = Console.ReadLine().ToLower();

            if ((answer == "r" && question.IsReal) || (answer == "f" && !question.IsReal))
            {
                rofScore++;
                ShowTip(question.TipType);
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                               Nice! You earned point.                                 |");
                Console.WriteLine("|                              Press any key to continue.                               |");
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            else if ((answer == "r" && !question.IsReal) || (answer == "f" && question.IsReal))
            {
                if (rofScore <= 0)
                {
                    rofScore = 0;
                }
                else
                {
                    rofScore--;
                }
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                           Wrong! This affects public safety.                          |");
                Console.WriteLine("|                              Press any key to continue.                               |");
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            else if (answer == "x") 
            {
                return false;
            }
            else
            {
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                             Please enter a valid answer.                              |");
                Console.WriteLine("|                              Press any key to continue.                               |");
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ReadKey();
                Console.Clear();
            }
        }
        return true;
    }

    private void ShowResults()
    {
        Console.WriteLine("_________________________________________________________________________________________");
        Console.WriteLine("|                                                                                       |");
        Console.WriteLine("|                                      FINAL RESULT                                     |");
        Console.WriteLine("|_______________________________________________________________________________________|");
        Console.WriteLine("|                                                                                       |");
        Console.WriteLine($"|                                   Final Score: {rofScore}                                        |");

        if (rofScore >= 5)
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                      Excellent! You can detect fake news well.                        |");
        }
        else if (rofScore >= 3)
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                       Good awareness, but improve fact-checking.                      |");
        }
        else
        {
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                       High risk of misinformation influence.                          |");
        }

        Console.WriteLine("|                                                                                       |");
        Console.WriteLine("|                              Press any key to continue.                               |");
        Console.WriteLine("|_______________________________________________________________________________________|");
        Console.ReadKey();
        Console.Clear();
    }

    public void UpdateInfo(string userName, int rofScore)
    {
        for (int i = 0; i < Users.Count; i++)
        {
            string[] parts = Users[i].Split(',');

            if (parts[1] == userName)
            {
                int newScore = Convert.ToInt32(parts[4]);
                newScore+= rofScore;

                parts[4] = newScore.ToString();
                Users[i] = string.Join(",", parts);

                break;
            }
        }
        File.WriteAllLines("Users.txt", Users);
    }

    private void Restart(string userName) 
    {
        while (true)
        {
            Console.WriteLine("_________________________________________________________________________________________");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                         Play Again?                                   |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                         Enter (Y/N)                                   |");
            Console.WriteLine("|_______________________________________________________________________________________|");
            
            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                Start(userName);
            }
            else if (input == "x")
            {
                Console.Clear();
                ascii.Returning();
                Thread.Sleep(1000);
                return;
            }
            else 
            {
                Console.WriteLine("_________________________________________________________________________________________");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                              Please enter valid option.                               |");
                Console.WriteLine("|                              Press any key to continue.                               |");
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.Clear();
                Console.ReadKey();
            }
        } 
    }
}

