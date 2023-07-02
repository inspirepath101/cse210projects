class BreathingActivity : Activity
{
    private string _activityTitle;
    public BreathingActivity(string activityTitle, string topic,)
        :base(activityTitle, topic)
    {

        _activityTitle = activityTitle;
    }
     public string GetBreathingActivityInformation()
    {
        // Notice that we are calling the getter here because _activityTitle is private in the base class
        string activityTitle = GetActivityTitle();

        return $"{_activityTitle} by {activitytName}";
    }
}
      


   