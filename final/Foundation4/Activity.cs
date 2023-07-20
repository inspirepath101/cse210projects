public class Activity
{
   List<Activity> activities = new List<Activity>();


     activity.add(new Activity());
     activity.add(new LengthActivity());


     foreach(Activity activity in activities)
{
     float minutes = activity.Minutes();
     Console.WriteLine(minutes);
} 
}