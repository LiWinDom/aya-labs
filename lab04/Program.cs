namespace lab04;

public static class Program
{
    public static void Main()
    {
        Console.Write("Enter task number: ");
        var taskNumber = Convert.ToInt16(Console.ReadLine());

        switch (taskNumber)
        {
            // case 1:
            //     break;
            case 2:
                Task2.Car[] cars =
                {
                    new Task2.Car("Zhiguli", "4.44", 50),
                    new Task2.Car("S-Class", "2", 200),
                    new Task2.Car("Bicycle", "1", 30),
                };
                
                Array.Sort(cars, new Task2.NameComparer());
                Array.Sort(cars, new Task2.EngineComparer());
                Array.Sort(cars, new Task2.MaxSpeedComparer());
                break;
            // case 3:
            //     break;
            default:
                Console.WriteLine("Invalid task number.");
                break;
        }
    }
}