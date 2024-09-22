namespace lab02.Task3;

public class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Document opened");
    }
    
    public virtual void EditDocument()
    {
        Console.WriteLine("Editing is available in PRO version");
    }
    
    public virtual void SaveDocument()
    {
        Console.WriteLine("Saving is available in PRO version");
    }
}
