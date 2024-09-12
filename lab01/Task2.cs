namespace lab01.Task2;

public static class Functions
{
    public static void Run()
    {
        Console.Write("Enter first side: ");
        var sideA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second side: ");
        var sideB = Convert.ToDouble(Console.ReadLine());
        var rectangle = new Rectangle(sideA, sideB);
        Console.WriteLine($"Perimeter: {rectangle.Perimeter}; Area: {rectangle.Area}");
    }
}

public class Rectangle
{
    public Rectangle(double sideA, double sideB)
    {
        _sideA = sideA;
        _sideB = sideB;
    }

    private double CalculatePerimeter()
    {
        return 2 * (_sideA + _sideB);
    }

    private double CalculateArea()
    {
        return _sideA * _sideB;
    }

    public double Perimeter
    {
        get => CalculatePerimeter();
    }

    public double Area
    {
        get => CalculateArea();
    }

    private readonly double _sideA;
    private readonly double _sideB;
}
