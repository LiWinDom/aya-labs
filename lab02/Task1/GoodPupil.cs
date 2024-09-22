namespace lab02.Task1;

public class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("I am styding, sometimes...");
    }

    public override void Read()
    {
        Console.WriteLine("I am reading, sometimes...");
    }

    public override void Write()
    {
        Console.WriteLine("I am writing, sometimes...");
    }

    public override void Relax()
    {
        Console.WriteLine("I am playing");
    }
}
