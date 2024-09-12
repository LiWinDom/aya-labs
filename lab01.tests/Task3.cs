using lab01.Task3;

namespace lab01.tests;

public class Task3
{
    [SetUp]
    public void Setup()
    {
        _rectangle = new Figure(new Point(0, 0), new Point(0, 5), new Point(7, 5), new Point(7, 0));
    }
    
    [Test]
    public void Test1()
    {
        _rectangle.Name = "Rectangle";

        const String correct = "Rectangle";
        var result = _rectangle.Name;
        
        Assert.That(result.Equals(correct), Is.True, $"Perimeter should be {correct}; Actual: {result}");
    }
    
    [Test]
    public void Test2()
    {
        const int correct = 24;
        var result = _rectangle.PerimeterCalculator();
        
        Assert.That(result.Equals(correct), Is.True, $"Perimeter should be {correct}; Actual: {result}");
    }
    
    Figure _rectangle;
}