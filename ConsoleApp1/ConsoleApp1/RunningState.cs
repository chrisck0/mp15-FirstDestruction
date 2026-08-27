namespace ConsoleApp1;

public interface RunningState
{
    int Speed { get; set; }
    
    void PrintSpeed(int speed);
}