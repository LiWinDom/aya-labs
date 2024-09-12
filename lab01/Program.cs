namespace lab01;

public static class Program
{
    public static void Main()
    {
        Console.Write("Enter task number: ");
        var taskNumber = Convert.ToInt16(Console.ReadLine());

        switch (taskNumber)
        {
            case 1:
                Task1.Functions.Run();
                break;
            case 2:
                Task2.Functions.Run();
                break;
            case 3:
                Task3.Functions.Run();
                break;
            default:
                Console.WriteLine("Invalid task number.");
                break;
        }
    }
}
