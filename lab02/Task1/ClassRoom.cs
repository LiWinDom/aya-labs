namespace lab02.Task1;

public class ClassRoom
{
    public ClassRoom(params Pupil[] pupils)
    {
        _pupils = pupils;
    }

    public void PrintInfo()
    {
        foreach (var pupil in _pupils)
        {
            pupil.Study();
            pupil.Read();
            pupil.Write();
            pupil.Relax();
            Console.WriteLine("");
        }
    }
    
    private Pupil[] _pupils;
}