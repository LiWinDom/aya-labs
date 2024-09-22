namespace lab02.Task3;

public class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Document saved in .rtf");
    }
}
