namespace lab02.Task3;

public class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument() 
    {
        Console.WriteLine("Document edited");
    }
    
    public override void SaveDocument()
    {
        Console.WriteLine("Saved in old format. Other formats are available in EXPERT version");
    }
}
