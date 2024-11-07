public class Team
{
    private readonly List<IWorker> _workers;

    public Team()
    {
        _workers = new List<IWorker> { new Worker(), new Worker(), new TeamLeader() };
    }

    public void BuildHouse(House house)
    {
        Console.WriteLine("Starting house construction...");

        while (!house.IsComplete())
        {
            foreach (var worker in _workers)
            {
                worker.Work(house);
                if (house.IsComplete())
                {
                    Console.WriteLine("The house is complete! Team celebration time!");
                    DrawHouse();
                    return;
                }
            }

        }
    }

    private static void DrawHouse()
    {
        Console.WriteLine("Final house drawing:");
        Console.WriteLine("        /\\");
        Console.WriteLine("       /  \\");
        Console.WriteLine("      /    \\");
        Console.WriteLine("     /______\\");
        Console.WriteLine("     | .--. |");
        Console.WriteLine("     | |  | |");
        Console.WriteLine("     | |__| |");
        Console.WriteLine("     |______|");
    }
}
