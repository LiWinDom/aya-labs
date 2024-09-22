namespace lab03;

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
            // case 2:
            //     break;
            case 3:
                break;
            default:
                Console.WriteLine("Invalid task number.");
                break;
        }
    }
}