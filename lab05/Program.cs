namespace lab05;

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
                var map = new Task3.Map<string, int>(10);
                map["81-717"] = 1983;
                map["81-720"] = 1993;
                map["81-740"] = 2003;
                map["81-760"] = 2010;
                map["81-765"] = 2016;
                Console.WriteLine(map["81-717"]);
                Console.WriteLine(map["81-720"]);
                Console.WriteLine(map["81-740"]);
                Console.WriteLine(map["81-760"]);
                Console.WriteLine(map["81-765"]);
                break;
            default:
                Console.WriteLine("Invalid task number.");
                break;
        }
    }
}