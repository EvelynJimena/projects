public class Entry 
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public List<PromptGenerator> _prompts = new List<PromptGenerator>();

    public void Display()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");

        foreach(PromptGenerator promptGenerator in _promptText)
        {
            promptGenerator.Display();
        }
        
    
    }

}