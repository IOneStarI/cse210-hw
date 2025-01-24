using System;

class Program
{
    static void Main(string[] args)
    {
        var reference = new Reference("Proverbs", 3, 5, 3, 6);
        var scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            
            if (scripture.AreAllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Good job memorizing!");
                break;
            }

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            var input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}
