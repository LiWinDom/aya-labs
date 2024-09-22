namespace lab03.Task2;

public class Car : IEquatable<Car>
{
    public Car(string name, string engine, double maxSpeed)
    {
        Name = name;
        Engine = engine;
        MaxSpeed = maxSpeed;
    }
    
    public override string ToString()
    {
        return Name;
    }
    
    public bool Equals(Car other)
    {
        return Name == other.Name && Engine == other.Engine && MaxSpeed == other.MaxSpeed;
    }

    public override bool Equals(Object other)
    {
        Car car = other as Car;
        return car == null ? false : Equals(car);
    }
    
    public string Name { get; set; }
    public string Engine { get; set; }
    public double MaxSpeed { get; set; }
}
