public class House
{
    public Basement Basement { get; } = new Basement();
    public Wall[] Walls { get; } = { new Wall(), new Wall(), new Wall(), new Wall() };
    public Door Door { get; } = new Door();
    public Window[] Windows { get; } = { new Window(), new Window(), new Window(), new Window() };
    public Roof Roof { get; } = new Roof();

    public bool IsComplete()
    {
        return Basement.IsBuilt && Walls.All(w => w.IsBuilt) && Door.IsBuilt && Windows.All(w => w.IsBuilt) && Roof.IsBuilt;
    }
}
