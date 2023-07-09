public class CheckListGoal : Goal
{
    private  int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, string points, string target, string bonus);
}