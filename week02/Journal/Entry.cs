using System;

public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }

    // For CSV storage
    public string ToCsv()
    {
        return $"\"{Date}\",\"{Prompt.Replace("\"", "\"\"")}\",\"{Response.Replace("\"", "\"\"")}\"";
    }

    // Parse from CSV
    public static Entry FromCsv(string csvLine)
    {
        var parts = csvLine.Split(new[] { "\",\"" }, StringSplitOptions.None);
        string date = parts[0].Trim('"');
        string prompt = parts[1].Replace("\"\"", "\"");
        string response = parts[2].Replace("\"\"", "\"").Trim('"');
        return new Entry(prompt, response, date);
    }
}