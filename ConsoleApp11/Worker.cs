public class Worker : IWorker
{
    public void Work(House house)
    {
        if (!house.Basement.IsBuilt)
            house.Basement.IsBuilt = true;
        else if (house.Walls.Any(w => !w.IsBuilt))
            house.Walls.First(w => !w.IsBuilt).IsBuilt = true;
        else if (!house.Door.IsBuilt)
            house.Door.IsBuilt = true;
        else if (house.Windows.Any(w => !w.IsBuilt))
            house.Windows.First(w => !w.IsBuilt).IsBuilt = true;
        else if (!house.Roof.IsBuilt)
            house.Roof.IsBuilt = true;
    }
}
public class TeamLeader : IWorker
{
    public void Work(House house)
    {
        Console.WriteLine("Construction Report:");
        Console.WriteLine($"Basement: {(house.Basement.IsBuilt ? "Built" : "Not Built")}");
        Console.WriteLine($"Walls: {house.Walls.Count(w => w.IsBuilt)} out of 4");
        Console.WriteLine($"Door: {(house.Door.IsBuilt ? "Built" : "Not Built")}");
        Console.WriteLine($"Windows: {house.Windows.Count(w => w.IsBuilt)} out of 4");
        Console.WriteLine($"Roof: {(house.Roof.IsBuilt ? "Built" : "Not Built")}");
    }
}
