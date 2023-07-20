
class Swimming : Activity
{
    private string _activityTitle;
    public Swimming(string activityTitle, int minutes,)
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
