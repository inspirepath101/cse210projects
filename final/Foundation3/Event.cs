public class Event
{
    private string _title;

    public Event(string title)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }
}