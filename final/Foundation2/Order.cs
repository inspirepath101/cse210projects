public class Order
{
    private List<int> _transactions = new List<int>(); 

    public void Purchase(int amount)
    {
        _transactions.Add(amount);
    }
}