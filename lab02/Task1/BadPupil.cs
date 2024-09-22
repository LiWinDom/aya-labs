namespace lab02.Task1;

public class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("I am playing CS2");
    }

    public override void Read()
    {
        Console.WriteLine("I am playing OSU");
    }

    public override void Write()
    {
        Console.WriteLine("I am playing DOTA2");
    }

    public override void Relax()
    {
        Console.WriteLine("I am playing WOW");
    }
}
