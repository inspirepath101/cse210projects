class Journal
{
    private List<Entry> entries = new List<Entry>();

 
    public void AddEntry(string date, string text)
    {
        entries.Add(new Entry(date, text));
    }

 
    public void DeleteEntry(int index)
    {
        entries.RemoveAt(index - 1);
    }

 
    public void DisplayEntries()
    {
        for (int i = 0; i < entries.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {entries[i].Date} - {entries[i].Text}");
        }
    }
   
}
