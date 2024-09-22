namespace lab03.Task2;

public class CarsCatalog
{
    public Car[] Cars { get; set; }

    public String this[int key] => $"{Cars[key].Name} - {Cars[key].Engine}";
}
