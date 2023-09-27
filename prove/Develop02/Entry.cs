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

        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.WriteLine("What would you like to do?");
        string choices = Console.ReadLine();

        if (choices == "1")
        {
        
            Console.WriteLine("What are you grateful for right now?");
            string answer =Console.ReadLine();
            
        }

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();


        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
        string[] parts = line.Split(",");

        string firstName = parts[0];
        string lastName = parts[1];
        }


        
    
    }

}