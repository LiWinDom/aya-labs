namespace lab04.Task2;

public class Car
{
    public Car(string name, string engine, double maxSpeed)
    {
        Name = name;
        Engine = engine;
        MaxSpeed = maxSpeed;
    }
    
    public string Name { get; set; }
    public string Engine { get; set; }
    public double MaxSpeed { get; set; }
}
