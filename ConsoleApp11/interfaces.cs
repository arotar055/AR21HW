
public interface IPart
{
    bool IsBuilt { get; set; } 
}


public interface IWorker
{
    void Work(House house); 
}
