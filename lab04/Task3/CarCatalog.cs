namespace lab04.Task3;

public class CarCatalog
{
    public IEnumerable<Task2.Car> GetEnumerable()
    {
        foreach (var car in _cars)
        {
            yield return car;
        }
        yield break;
    }
    
    // public IEnumerable<Task2.Car> GetEnumerable()
    // {
    //     for (var i = _cars.Length - 1; i >= 0; --i)
    //     {
    //         yield return _cars[i];
    //     }
    //     yield break;
    // }
    
    public Task2.Car this[int i] => _cars[i];
    private Task2.Car[] _cars;
}
