namespace lab02.Task2;

public class Ship : Vehicle
{
    public Ship(int x, int y, int price, int maxSpeed, int manifactureYear, String port, int passangerCapacity)
        : base(x, y, price, maxSpeed, manifactureYear)
    {
        Port = port;
        PassengerCapacity = passangerCapacity;
    }
    
    public String Port { get; set; }
    public int PassengerCapacity { get; set; }
}
