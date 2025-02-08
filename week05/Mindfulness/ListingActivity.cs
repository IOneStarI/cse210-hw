class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?"
    };

    public ListingActivity() : base("Listing Activity", "This activity helps you list positive things in your life.") { }

    protected override void RunActivity()
    {
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        ShowSpinner(3);
        
        List<string> responses = new List<string>();
        Console.WriteLine("Start listing items: (Press enter after each item, type 'done' to finish)");
        
        int startTime = Environment.TickCount;
        while ((Environment.TickCount - startTime) / 1000 < _duration)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done") break;
            responses.Add(input);
        }
        Console.WriteLine($"You listed {responses.Count} items!");
    }
}