using System;

public class TreePlanter
{
	private int seeds = 0;
	private int water = 0;
	private int growth = 0;

	private Random random = new Random();

    public void Start()
    {
        Console.Clear();

        Console.WriteLine("=================================");
        Console.WriteLine("      TREE COLLECTION GAME");
        Console.WriteLine("=================================");
        Console.WriteLine("\nCollect Seeds and Water");
        Console.WriteLine("Avoid Trash and Pests");
        Console.WriteLine("Reach 100% Growth to Win!");

        while (growth < 100)
        {
            Console.WriteLine("\n-------------------------");
            Console.WriteLine($"Tree Growth : {growth}%");
            Console.WriteLine($"Seeds       : {seeds}");
            Console.WriteLine($"Water       : {water}");
            Console.WriteLine("-------------------------");

            Console.WriteLine("\nPress any key to explore...");
            Console.ReadKey();

            int item = random.Next(1, 5);

            switch (item)
            {
                case 1:
                    Console.WriteLine("\n🌱 You found a Seed!");
                    seeds++;
                    break;

                case 2:
                    Console.WriteLine("\n💧 You found Water!");
                    water++;
                    break;

                case 3:
                    Console.WriteLine("\n🗑️ You found Trash!");
                    growth -= 10;

                    if (growth < 0)
                        growth = 0;
                    break;

                case 4:
                    Console.WriteLine("\n🐛 Pests attacked your tree!");
                    growth -= 15;

                    if (growth < 0)
                        growth = 0;
                    break;
            }

            // Grow tree when player has both resources
            if (seeds > 0 && water > 0)
            {
                seeds--;
                water--;

                growth += 20;

                Console.WriteLine("\n🌳 Your tree grew by 20%!");
            }

            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
            Console.Clear();
        }

        Console.WriteLine("=================================");
        Console.WriteLine("          YOU WIN!");
        Console.WriteLine("=================================");

        Console.WriteLine("\n🌳 Congratulations!");
        Console.WriteLine("Your tree is fully grown.");

        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }
}
