namespace lab04.Task2;

public class NameComparer : IComparer<Car>
{
    public int Compare(Car x, Car y)
    {
        return x.Name.CompareTo(y.Name);
    }
}

public class EngineComparer : IComparer<Car>
{
    public int Compare(Car x, Car y)
    {
        return x.Engine.CompareTo(y.Engine);
    }
}

public class MaxSpeedComparer : IComparer<Car>
{
    public int Compare(Car x, Car y)
    {
        return x.MaxSpeed.CompareTo(y.MaxSpeed);
    }
}
