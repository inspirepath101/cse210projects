
class Running : Activity
{
    private string _activityTitle;
    public Running(string activityTitle, int minutes,)
        :base(activityTitle, minutes)
    {

        _activityTitle = activityTitle;
    }
     public string GetCyclingInformation()
    {
       
        string activityTime = GetActivityTime();

        return $"{_activityTitle} by {activitytTime}";
    }
}
      