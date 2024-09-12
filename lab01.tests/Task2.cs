using lab01.Task2;

namespace lab01.tests;

public class Task2
{
    [SetUp]
    public void Setup()
    {
        _rectangle = new Rectangle(2, 5);
    }
    
    [Test]
    public void Test1()
    {
        const int correct = 14;
        var result = _rectangle.Perimeter;
        
        Assert.That(result.Equals(correct), Is.True, $"Perimeter should be {correct}; Actual: {result}");
    }
    
    [Test]
    public void Test2()
    {
        const int correct = 10;
        var result = _rectangle.Area;
        
        Assert.That(result.Equals(correct), Is.True, $"Perimeter should be {correct}; Actual: {result}");
    }
    
    Rectangle _rectangle;
}