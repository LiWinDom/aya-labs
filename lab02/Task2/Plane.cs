namespace lab02.Task2;

public class Plane : Vehicle
{
    public Plane(int x, int y, int price, int maxSpeed, int manifactureYear, int height, int passangerCapacity)
        : base(x, y, price, maxSpeed, manifactureYear)
    {
        Height = height;
        PassengerCapacity = passangerCapacity;
    }
        
    public double Height { get; set; }
    public int PassengerCapacity { get; set; }
}
