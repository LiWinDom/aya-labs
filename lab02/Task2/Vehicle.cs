namespace lab02.Task2;

public class Vehicle
{
    public Vehicle(double x, double y, int price, int maxSpeed, int manifactureYear)
    {
        X = x;
        Y = y;
        Price = price;
        MaxSpeed = maxSpeed;
        ManifactureYear = manifactureYear;
    }
    
    public double X { get; set; }
    public double Y { get; set; }

    public int Price { get; set; }
    public int MaxSpeed { get; set; }
    public int ManifactureYear { get; set; }
}
