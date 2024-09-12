namespace lab01.Task3;

public static class Functions
{
    public static void Run()
    {
        var rectangle = new Figure(new Point(0, 0), new Point(0, 5), new Point(7, 5), new Point(7, 0));
        rectangle.Name = "Rectangle";
        Console.WriteLine($"Name: {rectangle.Name}");
        Console.WriteLine($"Perimeter: {rectangle.PerimeterCalculator()}");
    }

    public static double LengthSide(Point A, Point B)
    {
        return double.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
    }
}

public class Point
{
    public Point(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public int X
    {
        get => _x;
    }

    public int Y
    {
        get => _y;
    }

    private readonly int _x;
    private readonly int _y;
}

public class Figure
{
    public Figure(Point p1, Point p2, Point p3)
    {
        Array.Resize(ref _points, 3);
        _points[0] = p1;
        _points[1] = p2;
        _points[2] = p3;
    }

    public double PerimeterCalculator()
    {
        double perimeter = 0;
        for (var i = 0; i < _points.Length - 1; i++)
        {
            perimeter += Functions.LengthSide(_points[i], _points[i + 1]);
        }

        perimeter += Functions.LengthSide(_points[0], _points[_points.Length - 1]);
        return perimeter;
    }

    public Figure(Point p1, Point p2, Point p3, Point p4) : this(p1, p2, p3)
    {
        Array.Resize(ref _points, 4);
        _points[3] = p4;
    }

    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5) : this(p1, p2, p3, p4)
    {
        Array.Resize(ref _points, 5);
        _points[4] = p5;
    }

    public string Name { get; set; }

    private readonly Point[] _points;
}
